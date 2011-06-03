using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Comcraft
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //MessageBox.Show(Directory.GetCurrentDirectory());
            AddObject AO = new AddObject(@"C:\Users\Scott\Documents\Repository\Comcraft\Source Code\Comcraft\Comcraft\Resources\items\items.xml");
            AO.Show();
        }
    }
}
