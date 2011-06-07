using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comcraft
{
    class DataClasses
    {
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
    }
}
