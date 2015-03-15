using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02BankАccounts.Customers
{
    abstract class Customer
    {
        protected string FirstName { get; set; }
        protected string LastName { get; set; }
        public Customer(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}

