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
        private AddObject addItemsForm;
        private AddObject addUsersForm;
        private AddObject addCommandsForm;
        private BuildCommand buildCommandForm;
        private AboutBox aboutForm;

        private String itemsResourceFile = @"C:\Users\Scott\Documents\Repository\Comcraft\Source Code\Comcraft\Comcraft\Resources\items\items.xml";
        private String usersResourceFile = @"C:\Users\Scott\Documents\Repository\Comcraft\Source Code\Comcraft\Comcraft\Resources\users\users.xml";
        private String commandsResourceFile = @"C:\Users\Scott\Documents\Repository\Comcraft\Source Code\Comcraft\Comcraft\Resources\commands\commands.xml";
        private String userProfileFile = @"C:\Users\Scott\Documents\Repository\Comcraft\Source Code\Comcraft\Comcraft\Properties\userSettings.xml";
        
        public delegate Form AddObjectForm(Type type);

        public Main()
        {
            InitializeComponent();
        }

        public Form getAddObjectForm(Type type)
        {
            switch(type)
            {
                case Type.items:  
                    if(addItemsForm == null)
                        addItemsForm = new AddObject(itemsResourceFile);
                    return addItemsForm;
                case Type.users:
                    if(addUsersForm == null)
                        addUsersForm = new AddObject(usersResourceFile);
                    return addUsersForm;
                case Type.commands:
                    if (addCommandsForm == null)
                        addCommandsForm = new AddObject(commandsResourceFile);
                    return addCommandsForm;
                default: return null;
            }
        }

        private void ExitMMI_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ItemsMMI_Click(object sender, EventArgs e)
        {
            getAddObjectForm(Type.items).Show();
        }

        private void BuildCommandsMMI_Click(object sender, EventArgs e)
        {
            if (buildCommandForm == null)
                buildCommandForm = new BuildCommand(this, userProfileFile);
            buildCommandForm.Show();
        }

        private void UsersMMI_Click(object sender, EventArgs e)
        {
            getAddObjectForm(Type.users).Show();
        }

        private void CommandsMMI_Click(object sender, EventArgs e)
        {
            getAddObjectForm(Type.commands).Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void AboutMMI_Click(object sender, EventArgs e)
        {
            if (aboutForm == null)
                aboutForm = new AboutBox();
            aboutForm.Show();
        }
    }
}
