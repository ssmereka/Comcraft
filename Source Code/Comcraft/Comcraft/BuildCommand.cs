using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Comcraft
{
    public partial class BuildCommand : Form
    {
        private Main.AddObjectForm addObject;

        public BuildCommand(Main form)
        {
            InitializeComponent();
            addObject = new Main.AddObjectForm(form.getAddObjectForm);
        }

        private void itemsBtn_Click(object sender, EventArgs e)
        {
            addObject(Type.items).Show();
        }

        private void usersBtn_Click(object sender, EventArgs e)
        {
            addObject(Type.users).Show();
        }

        private void commandBtn_Click(object sender, EventArgs e)
        {
            addObject(Type.commands).Show();
        }
    }
}
