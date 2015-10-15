using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02_DAOClass
{
    using System.Data.Entity;

    internal static class DAO
    {
        public static void AddCustomer(Customer input)
        {
            using (var db = new NORTHWNDEntities())
            {
                db.Customers.Add(input);
                db.SaveChanges();
            }
        }

        public static void DeleteCustomer(Customer input)
        {
            using (var db = new NORTHWNDEntities())
            {
                db.Customers.Remove(input);
                db.SaveChanges();
            }
        }

        public static void ModifyCustomer(Customer input)
        {
            using (var db = new NORTHWNDEntities())
            {                
                db.Customers.Attach(input);
                db.Entry(input).State = EntityState.Modified;
                db.SaveChanges();                
            }
        }

        public static Customer GetCustomerById(string id)
        {
            using (var db = new NORTHWNDEntities())
            {
                var result = db.Customers.FirstOrDefault(x => x.CustomerID == id);
                return result;
            }
        }
    }
}
