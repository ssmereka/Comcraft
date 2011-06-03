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



        public AddObject()
        {
            InitializeComponent();
            //DisplayObject();
        }

        public AddObject(String resXmlLocation)
        {
            InitializeComponent();
            float xSize, ySize;
            String resLocation = "";
            XmlDocument resXml = new XmlDocument();
            XmlNodeList objects = resXml.GetElementsByTagName("Object");
            for (int y = 0; y < objects.Count; y++)
            {
                String obj = objects[y].InnerXml;
                
            }
            resXml.Load(resXmlLocation);
            name = resXml.GetElementsByTagName("name");
            hex = resXml.GetElementsByTagName("hex");
            img = resXml.GetElementsByTagName("img");
            sizeX = resXml.GetElementsByTagName("sizex");
            sizeY = resXml.GetElementsByTagName("sizey");
            stack = resXml.GetElementsByTagName("stack");

            MessageBox.Show(stack.Count.ToString());//stack[0].Value.ToString());
            XmlNode resLoc = resXml.GetElementById("imgLocation");

            //resLocation = resLoc.Value;
            foreach (XmlNode node in name)
            {
                int x = 0;
                float.TryParse(sizeX[x].Value, out xSize);
                float.TryParse(sizeY[x].Value, out ySize);
                DisplayObject(resLocation + @"\" + img[x].Value,
                              node.Value,
                              Convert.ToInt32(hex[x].Value),
                              Convert.ToInt32(stack[x].Value),
                              xSize,
                              ySize);
            }
           /* for (int x = 0; x < name.Count; x++)
            {
                float.TryParse(sizeX[x].Value, out xSize);
                float.TryParse(sizeY[x].Value, out ySize);
                DisplayObject(resLocation + @"\" + img[x].Value, 
                              name[x].Value,
                              Convert.ToInt32(hex[x].Value),
                              Convert.ToInt32(stack[x].Value),
                              xSize,
                              ySize);
            } */
        }

        private Boolean DisplayObject(String bitmapURL, String name, int hex, int stack, float xSize, float ySize)
        {
            //Image img = Image.FromFile(@"C:\Users\Scott\Documents\Repository\Comcraft\Source Code\Comcraft\Comcraft\Resources\items\Stone.png");
            //Bitmap bm = new Bitmap(@"C:\Users\Scott\Documents\Repository\Comcraft\Source Code\Comcraft\Comcraft\Resources\items\Stone.png");
            Bitmap bitmap = new Bitmap(bitmapURL);
            bitmap = ResizeBitmap(bitmap, 50, 50);
            //this.Controls.Add(bm);

            PictureBox pic = new PictureBox();
            pic.Image = bitmap;
            //pic.ImageLocation = @"C:\Users\Scott\Documents\Repository\Comcraft\Source Code\Comcraft\Comcraft\Resources\items\Stone.png";
            pic.Location = new Point(SearchCoB.Left + 1, SearchCoB.Top);
            pic.Size = new Size(50, 50);
            pic.Visible = true;
            //pic.BorderStyle = BorderStyle.Fixed3D;
            this.Controls.Add(pic);
            DragMoveExtensions.EnableDragMove(pic, true);
            return true;
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
