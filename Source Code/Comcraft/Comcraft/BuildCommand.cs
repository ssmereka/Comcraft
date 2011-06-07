using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Collections.Generic;

namespace Comcraft
{
    public partial class BuildCommand : Form
    {
        #region Class Variables
        private Main.AddObjectForm addObject;
        private Form itemsForm;
        private Form usersForm;
        private Form commandsForm;

        private List<Command> commands;
        private String errorStr;
        #endregion

        #region Constructors
        public BuildCommand(Main form, String setXmlLocation)
        {
            InitializeComponent();
            XmlDocument setXml = new XmlDocument();
            try { setXml.Load(setXmlLocation); }   //Try to load XML
            catch 
            { 
                DisplayError();
                errorStr = "Error loading Settings XML file"; 
            }
            try { Setup(form, setXml); }   //Load rest of settings
            catch { DisplayError(); }
        }

        public BuildCommand(Main form, XmlDocument setXml)
        {
            InitializeComponent();
            try { Setup(form, setXml); }   //Load rest of settings
            catch { DisplayError(); }
        }
        #endregion

        private void Setup( Main form, XmlDocument setXml)
        {
            addObject = new Main.AddObjectForm(form.getAddObjectForm);
            try { LoadUserProfile(setXml); }
            catch { errorStr = "Error loading user profile"; }

            try { itemsForm = addObject(Type.items); }
            catch { errorStr = "Error loading items xml or form"; }

            try { usersForm = addObject(Type.items); }
            catch { errorStr = "Error loading users xml or form"; }

            try { commandsForm = addObject(Type.items); }
            catch { errorStr = "Error loading commands xml or form"; }
        }

        private void DisplayError()
        {
            if (errorStr != "")
            {
                this.Text = "Build Command - " + errorStr;  //Display error
                errorStr = "";  //Reset error
            }
        }

        private void itemsBtn_Click(object sender, EventArgs e)
        {
            //addObject(Type.items).Show();
            itemsForm.Show();
        }

        private void usersBtn_Click(object sender, EventArgs e)
        {
            //addObjectUsers(Type.users).Show();
            usersForm.Show();
        }

        private void commandBtn_Click(object sender, EventArgs e)
        {
            //addObjectCommands(Type.commands).Show();
            commandsForm.Show();
        }

        private void LoadUserProfile(XmlDocument setXml)
        {
            XmlElement root = setXml.DocumentElement;
            XmlNode profile = root.SelectSingleNode("profile[@default='true']");
            XmlNodeList commandNodeList = profile.SelectNodes("command");
            Command temp;
            ListViewItem item;
            commands = new List<Command>();
  
            foreach (XmlNode node in commandNodeList)
            {
                item = new ListViewItem();  //Must create new item everytime or information will be lost or not added properly
                temp = new Command();       //Ditto
                keybindingLV.BeginUpdate();
                temp.Option0 = node.SelectSingleNode("option0").InnerText;
                temp.Option1 = node.SelectSingleNode("option1").InnerText;
                temp.Option2 = node.SelectSingleNode("option2").InnerText;
                temp.Option3 = node.SelectSingleNode("option3").InnerText;
                temp.Custom = node.SelectSingleNode("custom").InnerText;
                temp.KeyBinding = node.Attributes["keybinding"].Value;
                commands.Add(temp);
                item.Text = temp.KeyBinding;
                if(!keybindingLV.Items.Contains(item))
                    keybindingLV.Items.Add(item);
                keybindingLV.EndUpdate();
            }
            
         }

        private void keybindingTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private Boolean CTRL = false;
        private Boolean ALT = false;
        private Boolean SHIFT = false;
        String keybinding = "";

        private void keybindingTxt_KeyDown(object sender, KeyEventArgs e)
        {
            keybindingTxt.Text = keybinding;
            CTRL = e.Control;
            ALT = e.Alt;
            SHIFT = e.Shift;
            if (CTRL)
                keybindingTxt.Text = "Ctrl";
            if (ALT)
                keybindingTxt.Text = "Alt";
            if (SHIFT)
                keybindingTxt.Text = "Shift";
            if(CTRL && ALT)
                keybindingTxt.Text = "Ctrl + Alt";
            if(CTRL && SHIFT)
                keybindingTxt.Text = "Ctrl + Shift";
            if(ALT && SHIFT)
                keybindingTxt.Text = "Alt + Shift";
            if (CTRL && ALT && SHIFT)
                keybindingTxt.Text = "Ctrl + Alt + Shift";
        }

        private void keybindingTxt_KeyUp(object sender, KeyEventArgs e)
        {
            //keybinding = keybindingTxt.Text;
        }

        private void keybindingTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            //keybinding += e.KeyChar.ToString();
        }

        private void keybindingLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(Command command in commands)
            {
                foreach (ListViewItem item in keybindingLV.SelectedItems)  //Should only ever be 1 item
                {
                    if (command.KeyBinding == item.Text)
                    {
                        commandCoB.Text = command.Option0;
                        option1CoB.Text = command.Option1;
                        option2CoB.Text = command.Option2;
                        option3CoB.Text = command.Option3;
                    }
                }
            }

        }
    }
}
