using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02BankАccounts.Customers
{
    class IndividualCustomer : Customer
    {
        public IndividualCustomer(string firstName, string lastName)
            : base(firstName, lastName)
        {

        }

        public override string ToString()
        {
            return String.Format("Individual customer {0} {1}.", base.FirstName, base.LastName);
        }
    }
}
