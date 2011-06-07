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

        //TODO:  Remake into data structure
        #region Class Variables
        private XmlNodeList name;               //String Name of objects
        private XmlNodeList dec;                //Int value of object
        private XmlNodeList img;                //String Image name of object
        private XmlNodeList sizeX;              //Int size of X value of image
        private XmlNodeList sizeY;              //Int size of Y value of image
        private XmlNodeList stack;              //Int value of how many objects can stack
        private XmlNodeList username;
        private XmlNodeList privilege;
        private XmlNodeList id;
        private String objectTypeStr = "";      //Type of Objects being loaded
        private String resourceImgLoc;          //Resourse Image Location
        private ImageList imgs;                 //Store images to be loaded into the listview
        private SortOrder listViewSort = SortOrder.Ascending;       //Stores how the listview will be sorted
        private String errorText = "";
        private Boolean error = false;
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
                DisplayError();
            }
            catch
            {
                MessageBox.Show("Error with the resource XML file");
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
                DisplayError();
            }
            catch
            {
                MessageBox.Show("Error loading the resource XML file (" + resXmlLocation + ")");
                this.Text = "Add Objects - Error loading XML file";
            }
        }
        #endregion

        private void DisplayError()
        {
            if (error)              //Update title based on errors
            {
                this.Text = "Add " + objectTypeStr + " - " + errorText;
                error = false;
            }
            else
                this.Text = "Add " + objectTypeStr;
        }

        private void LoadNodes(String typeStr, XmlDocument resXml)
        {
            if (typeStr.ToLower() == "items")
                LoadNodes(Type.items, resXml);
            else if (typeStr.ToLower() == "commands")
                LoadNodes(Type.commands, resXml);
            else if (typeStr.ToLower() == "users")
                LoadNodes(Type.users, resXml);
            else if (typeStr.ToLower() == "privilege")
                LoadNodes(Type.privilege, resXml);
            else
                LoadNodes(Type.none, null);  //Type not found
        }

        private void LoadNodes(Type type, XmlDocument resXml)
        {
            switch(type)
            {
                case Type.items:
                    name = resXml.GetElementsByTagName("name");
                    dec = resXml.GetElementsByTagName("dec");
                    stack = resXml.GetElementsByTagName("stack");
                    break;
                case Type.users:
                    id = resXml.GetElementsByTagName("id");
                    username = resXml.GetElementsByTagName("username");
                    privilege = resXml.GetElementsByTagName("privilege");
                    img = resXml.GetElementsByTagName("img");
                    sizeX = resXml.GetElementsByTagName("sizex");
                    sizeY = resXml.GetElementsByTagName("sizey");
                    break;
                case Type.commands:
                    break;
                default:
                    error = true;
                    errorText = "XML type is invalid";
                    break;
            }
        }

        private void LoadObjects(XmlDocument resXml)
        {
            int loadFailCount = 0;
            imgs = new ImageList();

            //Load nodes for processing
            resourceImgLoc = resXml.GetElementsByTagName("imgLocation")[0].InnerText;
            objectTypeStr = resXml.GetElementsByTagName("type")[0].InnerText;
            name = resXml.GetElementsByTagName("name");
            img = resXml.GetElementsByTagName("img");
            sizeX = resXml.GetElementsByTagName("sizex");
            sizeY = resXml.GetElementsByTagName("sizey");
            LoadNodes(objectTypeStr, resXml);

            for (int x = 0; x < name.Count; x++)        //Add each item to the listview and combo box
            {
                try
                {
                    if (DisplayObject(resourceImgLoc + @"\" + img[x].InnerText, name[x].InnerText, 
                                        Convert.ToInt32(sizeX[x].InnerText), Convert.ToInt32(sizeY[x].InnerText)))
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
            {
                error = true;
                errorText = "Loaded with " + loadFailCount.ToString() + " Errors";
            }
        }

        private Boolean DisplayObject(String bitmapURL, String name, int xSize, int ySize)  //Add object to listview
        {
            if ((bitmapURL == "") || (bitmapURL == null) || (!File.Exists(bitmapURL)))  //Check preconditions
                return false;
            else
            {
                Bitmap bitmap = new Bitmap(bitmapURL);

                int index = ObjectLV.Items.Count;
                imgs.Images.Add(index.ToString(), bitmap);
                imgs.ImageSize = new Size(xSize/3, ySize/3);              //Set image size for listview
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

        private void AddObject_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void AddObject_Load(object sender, EventArgs e)
        {

        }
    }
}
