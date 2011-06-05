using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace Comcraft
{
    public partial class AddObject : Form
    {
        #region Class Variables
        private XmlNodeList name;               //String Name of objects
        private XmlNodeList dec;                //Int value of object
        private XmlNodeList img;                //String Image name of object
        private XmlNodeList sizeX;              //Int size of X value of image
        private XmlNodeList sizeY;              //Int size of Y value of image
        private XmlNodeList stack;              //Int value of how many objects can stack
        private String objectTypeStr = "";      //Type of Objects being loaded
        private String resourceImgLoc;          //Resourse Image Location
        private ImageList imgs;                 //Store images to be loaded into the listview
        private SortOrder listViewSort = SortOrder.Ascending;       //Stores how the listview will be sorted
        #endregion

        #region Constructors
        public AddObject()
        {
            InitializeComponent();
        }

        public AddObject(XmlDocument resXml)
        {
            InitializeComponent();
            try
            {
                LoadObjects(resXml);
            }
            catch
            {
                MessageBox.Show("Error loading the resource XML file");
                this.Text = "Add Objects - Error loading XML file";
            }
        }

        public AddObject(String resXmlLocation)
        {
            InitializeComponent();
            XmlDocument resXml = new XmlDocument();
            try
            {
                resXml.Load(resXmlLocation);
                LoadObjects(resXml);
            }
            catch
            {
                MessageBox.Show("Error loading the resource XML file (" + resXmlLocation + ")");
                this.Text = "Add Objects - Error loading XML file";
            }
        }
        #endregion

        private void LoadObjects(XmlDocument resXml)
        {
            int loadFailCount = 0;
            float xSize, ySize;
            imgs = new ImageList();

            //Load nodes for processing
            name = resXml.GetElementsByTagName("name");
            dec = resXml.GetElementsByTagName("dec");
            img = resXml.GetElementsByTagName("img");
            sizeX = resXml.GetElementsByTagName("sizex");
            sizeY = resXml.GetElementsByTagName("sizey");
            stack = resXml.GetElementsByTagName("stack");
            
            resourceImgLoc = resXml.GetElementsByTagName("imgLocation")[0].InnerText;
            objectTypeStr = resXml.GetElementsByTagName("type")[0].InnerText;

            for (int x = 0; x < name.Count; x++)        //Add each item to the listview and combo box
            {
                try
                {
                    float.TryParse(sizeX[x].InnerText, out xSize);
                    float.TryParse(sizeY[x].InnerText, out ySize);
                    if (DisplayObject(resourceImgLoc + @"\" + img[x].InnerText,
                                    name[x].InnerText,
                                    Convert.ToInt32(dec[x].InnerText),
                                    Convert.ToInt32(stack[x].InnerText),
                                    xSize, ySize))
                    {
                        if (!SearchCoB.Items.Contains(name[x].InnerText))
                            SearchCoB.Items.Add(name[x].InnerText);
                    }
                    else
                        loadFailCount++;        //Failed to add item to listview
                }
                catch
                {
                    loadFailCount++;        //Failed to add item to listview
                }
            }

            ObjectLV.Sorting = listViewSort;    //Sort listview

            if (loadFailCount > 0)              //Update title based on errors
                this.Text = "Add " + objectTypeStr + " - Loaded with " + loadFailCount.ToString() + " Errors";
            else
                this.Text = "Add " + objectTypeStr;
        }

        private Boolean DisplayObject(String bitmapURL, String name, int dec, int stack, float xSize, float ySize)  //Add object to listview
        {
            if ((bitmapURL == "") || (bitmapURL == null) || (!File.Exists(bitmapURL)))  //Check preconditions
                return false;
            else
            {
                Bitmap bitmap = new Bitmap(bitmapURL);

                int index = ObjectLV.Items.Count;
                imgs.Images.Add(index.ToString(), bitmap);
                imgs.ImageSize = new Size(50, 50);              //Set image size for listview
                ObjectLV.LargeImageList = imgs;                 

                ObjectLV.BeginUpdate();
                ListViewItem item = new ListViewItem(name);
                item.ImageIndex = index;
                ObjectLV.Items.Add(item);
                ObjectLV.EndUpdate();

                return true;
            }
        }

        public Bitmap ResizeBitmap(Bitmap bitmap, float width, float height)
        {
            return ResizeBitmap(bitmap, new Point(0, 0), width, height);
        }
        private Bitmap ResizeBitmap(Bitmap bitmap, Point point, float width, float height)
        {
            Bitmap newBitmap = new Bitmap(Convert.ToInt32(width), Convert.ToInt32(height));
            using (Graphics g = Graphics.FromImage((Image)newBitmap))
                g.DrawImage(bitmap, point.X, point.Y, width, height);
            return newBitmap;
        }
        private void ObjectLV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
