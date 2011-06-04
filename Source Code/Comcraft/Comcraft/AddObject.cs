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
        XmlNodeList name;
        XmlNodeList hex;
        XmlNodeList img;
        XmlNodeList sizeX;
        XmlNodeList sizeY;
        XmlNodeList stack;
        int loadFailCount = 0;
        int height;
        int width;
        ImageList imgs;



        public AddObject()
        {
            InitializeComponent();
            //DisplayObject();
        }

        public AddObject(XmlDocument resXml)
        {
            InitializeComponent();
            loadFailCount = LoadObjects(resXml);
        }
        public AddObject(String resXmlLocation)
        {
            InitializeComponent();
            XmlDocument resXml = new XmlDocument();
            resXml.Load(resXmlLocation);
            loadFailCount = LoadObjects(resXml);
        }

        private int LoadObjects(XmlDocument resXml)
        {
            int failCount = 0;
            float xSize, ySize;
            height = 0;//AddObject.ActiveForm.Size.Height;
            width = 0;//AddObject.ActiveForm.Size.Width;


            name = resXml.GetElementsByTagName("name");
            hex = resXml.GetElementsByTagName("hex");
            img = resXml.GetElementsByTagName("img");
            sizeX = resXml.GetElementsByTagName("sizex");
            sizeY = resXml.GetElementsByTagName("sizey");
            stack = resXml.GetElementsByTagName("stack");
            XmlNodeList resLoc = resXml.GetElementsByTagName("imgLocation");


            imgs = new ImageList();

            for (int x = 0; x < name.Count; x++)
            {
                float.TryParse(sizeX[x].InnerText, out xSize);
                float.TryParse(sizeY[x].InnerText, out ySize);
                if (DisplayObject(resLoc[0].InnerText + @"\" + img[x].InnerText,
                                name[x].InnerText,
                                Convert.ToInt32(hex[x].InnerText),
                                Convert.ToInt32(stack[x].InnerText),
                                xSize, ySize))
                    failCount++;
            }
            return failCount;
        }


        private Boolean DisplayObject(String bitmapURL, String name, int hex, int stack, float xSize, float ySize)
        {
            //Image img = Image.FromFile(@"C:\Users\Scott\Documents\Repository\Comcraft\Source Code\Comcraft\Comcraft\Resources\items\Stone.png");
            //Bitmap bm = new Bitmap(@"C:\Users\Scott\Documents\Repository\Comcraft\Source Code\Comcraft\Comcraft\Resources\items\Stone.png");


            if ((bitmapURL == "") || (bitmapURL == null) || (!File.Exists(bitmapURL)))
                return false;
            else
            {
                Bitmap bitmap = new Bitmap(bitmapURL);
                bitmap = ResizeBitmap(bitmap, 50, 50);
                //this.Controls.Add(bm);

                int index = ObjectLV.Items.Count;
                imgs.Images.Add(index.ToString(), bitmap);
                ObjectLV.LargeImageList = imgs;

                ObjectLV.BeginUpdate();
                ListViewItem item = new ListViewItem(name);
                item.ImageIndex = index;
                ObjectLV.Items.Add(item);

                /*PictureBox pic = new PictureBox();
                pic.Image = bitmap;
                //pic.ImageLocation = @"C:\Users\Scott\Documents\Repository\Comcraft\Source Code\Comcraft\Comcraft\Resources\items\Stone.png";
                pic.Location = new Point(height,width);
                pic.Size = new Size(50, 50);
                pic.Visible = true;
                //pic.BorderStyle = BorderStyle.Fixed3D;
                this.Controls.Add(pic);
                DragMoveExtensions.EnableDragMove(pic, true); */

                //ObjectLV.Items.Add(name);
                //ObjectLV.Items[ObjectLV.Items.Count - 1].StateImageIndex = 1;
                
                //ObjectLV.StateImageList = imgs;

                //ObjectLV.BeginUpdate();
                //ObjectLV.LargeImageList = imgs;


                //if (height + 50 > AddObject.ActiveForm.Size.Height)
                //{
                //    height = 0;
                //    width += 50;
               // }
               // else
                    height += 50;
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
    }
}
