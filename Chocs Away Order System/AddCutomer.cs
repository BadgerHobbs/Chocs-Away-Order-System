using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chocs_Away_Order_System
{
    public class AddCutomer
    {
        // Get Order From Database
        public static void AddCustomer(string customerName, string addressLine1, string addressLine2, string addressLine3, string postcode, string phone, string email, string securityQuestion, string securityQuestionAnswer)
        {
            // For each row in customers database of customer details
            using (var db = new chocsawayEntities())
            {
                db.Customers.Add(new Customer() { CustomerName = customerName, AddressLine1 = addressLine1, AddressLine2 = addressLine2, AddressLine3 = addressLine3, Postcode = postcode, Phone = phone, Email = email, SecurityQuestion = securityQuestion, SecurityQuestionAnswer = securityQuestionAnswer });
                db.SaveChanges();
            }
        }
    }
}
