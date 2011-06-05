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
            addObjectForm = new AddObject(@"C:\Users\Scott\Documents\Repository\Comcraft\Source Code\Comcraft\Comcraft\Resources\items\items.xml");
            addObjectForm.Show();
        }

        private void BuildCommandsMMI_Click(object sender, EventArgs e)
        {
            buildCommandForm = new BuildCommand();
            buildCommandForm.Show();
        }

        private void UsersMMI_Click(object sender, EventArgs e)
        {
            addObjectForm = new AddObject(@"C:\Users\Scott\Documents\Repository\Comcraft\Source Code\Comcraft\Comcraft\Resources\users\users.xml");
            addObjectForm.Show();
        }

        private void CommandsMMI_Click(object sender, EventArgs e)
        {
            addObjectForm = new AddObject(@"C:\Users\Scott\Documents\Repository\Comcraft\Source Code\Comcraft\Comcraft\Resources\commands\commands.xml");
            addObjectForm.Show();
        }
    }
}
