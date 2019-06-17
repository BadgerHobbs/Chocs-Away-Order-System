using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chocs_Away_Order_System
{
    class AddCutomer
    {
        // Get Order From Database
        public static void AddCustomer(string customerName, string addressLine1, string addressLine2, string addressLine3, string postcode, string phone, string email, string securityQuestion, string securityQuestionAnswer)
        {
            // Create SQL connection
            using (SqlConnection connection = new SqlConnection(@"Server=ANDREW-PC\SQLEXPRESS;Database=ChocsAway;Trusted_Connection=true"))
            {
                // Open SQL connection
                connection.Open();
                // Create and use new SQL command
                using (SqlCommand command = connection.CreateCommand())
                {
                    // Add SQL command query to insert into orders specific values
                    command.CommandText = "INSERT INTO Customers(CustomerName, AddressLine1, AddressLine2, AddressLine3, Postcode, Phone, Email, SecurityQuestion, SecurityQuestionAnswer) VALUES(@customerName, @addressLine1, @addressLine2, @addressLine3, @postcode, @phone, @email, @securityQuestion, @securityQuestionAnswer); SELECT SCOPE_IDENTITY(); ";
                    // Add data to values in SQL query string

                    // Add customer Name
                    command.Parameters.AddWithValue("@customerName", customerName);
                    // Add address Line 1
                    command.Parameters.AddWithValue("@addressLine1", addressLine1);
                    // Add address Line 2
                    command.Parameters.AddWithValue("@addressLine2", addressLine2);
                    // Add address Line 3
                    command.Parameters.AddWithValue("@addressLine3", addressLine3);
                    // Add postcode
                    command.Parameters.AddWithValue("@postcode", postcode);
                    // Add customer number
                    command.Parameters.AddWithValue("@phone", phone);
                    // Add email
                    command.Parameters.AddWithValue("@email", email);
                    // Add security Question
                    command.Parameters.AddWithValue("@securityQuestion", securityQuestion);
                    // Add security Question Answer
                    command.Parameters.AddWithValue("@securityQuestionAnswer", securityQuestionAnswer);
                    // Execute comand
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
