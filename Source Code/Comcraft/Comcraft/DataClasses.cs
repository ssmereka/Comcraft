/* Collection of Data types and classes for handling data storage and manipulation */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Comcraft
{
    public enum Type { items, commands, users, privilege, none };

    public class DataHandler
    {
        private String errorStr;

        public DataHandler()
        {

        }

        public String ErrorString
        {
            get { return this.errorStr; }
            set { this.errorStr = value; }
        }

        public Boolean LoadData(XmlDocument xml)
        {
            //open xml and get type
            Type datatype = Type.items;
            
            switch(datatype)
            {
                case Type.items:
                    break;
                case Type.users:
                    break;
                case Type.commands:
                    break;
                default: 
                    return false;
            }


            //datatype = new Command();
            return true;
        }

        private Boolean LoadItems()
        {
            return true;
        }
    }

    public class Command
    {
        private String keyBinding;
        private String custom;
        private String option0;
        private String option1;
        private String option2;
        private String option3;

        public Command() { }

        #region Getters & Setters
        public String KeyBinding
        {
            get { return this.keyBinding; }
            set { this.keyBinding = value; }
        }
        public String Custom
        {
            get { return this.custom; }
            set { this.custom = value; }
        }
        public String Option0
        {
            get { return this.option0; }
            set { this.option0 = value; }
        }
        public String Option1
        {
            get { return this.option1; }
            set { this.option1 = value; }
        }
        public String Option2
        {
            get { return this.option2; }
            set { this.option2 = value; }
        }
        public String Option3
        {
            get { return this.option3; }
            set { this.option3 = value; }
        }
        #endregion
    }

    public class User
    {
        private String id;
        private String name;
        private String username;
        private String privilege;
        private String img;
        private System.Drawing.Point size;

        public User() { }

        #region Getters & Setters
        public String Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public String Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public String Username
        {
            get { return this.username; }
            set { this.username = value; }
        }
        public String Privilege
        {
            get { return this.privilege; }
            set { this.privilege = value; }
        }
        public String Img
        {
            get { return this.img; }
            set { this.img = value; }
        }
        public System.Drawing.Point Size
        {
            get { return this.size; }
            set { this.size = value; }
        }
        #endregion
    }

    public class Item
    {
        private String name;
        private int dec;
        private int stack;
        private String img;
        private System.Drawing.Point size;

        public Item() { }

        #region Getters & Setters
        public String Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Decimal
        {
            get { return this.dec; }
            set { this.dec = value; }
        }
        public int Stack
        {
            get { return this.stack; }
            set { this.stack = value; }
        }
        public String Img
        {
            get { return this.img; }
            set { this.img = value; }
        }
        public System.Drawing.Point Size
        {
            get { return this.size; }
            set { this.size = value; }
        }
        #endregion
    }

    public class Privilege
    {
        private String id;
        private String name;
        private String command;
        private String prevRank;
        private String nextRank;
        private String img;
        private System.Drawing.Point size;

        public Privilege() { }

        #region Getters & Setters
        public String Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public String Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public String Command
        {
            get { return this.command; }
            set { this.command = value; }
        }
        public String PrevRank
        {
            get { return this.prevRank; }
            set { this.prevRank = value; }  //TODO:  Make sure rank exists
        }
        public String NextRank
        {
            get { return this.NextRank; }
            set { this.NextRank = value; } //TODO: Make sure rank exists
        }
        public String Img
        {
            get { return this.img; }
            set { this.img = value; }
        }
        public System.Drawing.Point Size
        {
            get { return this.size; }
            set { this.size = value; }
        }
        #endregion
    }
}
