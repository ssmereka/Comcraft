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
    public partial class Main : Form
    {
        private AddObject addObjectForm;
        BuildCommand buildCommandForm;
        public Main()
        {
            InitializeComponent();
            //MessageBox.Show(Directory.GetCurrentDirectory());
            
        }

        private void ExitMMI_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ItemsMMI_Click(object sender, EventArgs e)
        {
            if(addObjectForm == null)
                addObjectForm = new AddObject(@"C:\Users\Scott\Documents\Repository\Comcraft\Source Code\Comcraft\Comcraft\Resources\items\items.xml");
            addObjectForm.Show();
        }

        private void BuildCommandsMMI_Click(object sender, EventArgs e)
        {
            if (buildCommandForm == null)
                buildCommandForm = new BuildCommand();
            buildCommandForm.Show();
        }
    }
}
