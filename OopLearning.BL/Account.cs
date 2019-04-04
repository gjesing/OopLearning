using System;
using System.Collections.Generic;
using System.Text;

namespace OopLearning.BL
{
    class Account
    {
        private string accountNumber;
        private string departmentNumber;
        private decimal balance;

        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }
        public string DepartmentNumber
        {
            get { return departmentNumber; }
            set { departmentNumber = value; }
        }
        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }
    }
}
