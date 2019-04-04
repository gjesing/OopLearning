using System;
using System.Collections.Generic;
using System.Text;

namespace OopLearning.BL
{
    public class Employee : Person
    {
        private string initials;

        public string Initials
        {
            get { return initials; }
            set { initials = value; }
        }

    }
}
