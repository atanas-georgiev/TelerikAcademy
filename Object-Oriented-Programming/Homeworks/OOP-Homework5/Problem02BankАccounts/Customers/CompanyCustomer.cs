using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02BankАccounts.Customers
{
    class CompanyCustomer : Customer
    {
        public CompanyCustomer(string companyName)
            : base(companyName, "")
        {

        }

        public override string ToString()
        {
            return String.Format("Company customer {0} {1}.", base.FirstName, base.LastName);
        }
    }
}
