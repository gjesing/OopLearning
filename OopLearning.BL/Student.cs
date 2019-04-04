using System;
using System.Collections.Generic;
using System.Text;

namespace OopLearning.BL
{
    public class Student : Person
    {
        private string unilogin;

        public string UniLogin
        {
            get { return unilogin; }
            set { unilogin = value; }
        }

    }
}
