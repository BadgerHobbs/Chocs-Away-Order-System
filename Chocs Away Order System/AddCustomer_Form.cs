using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chocs_Away_Order_System
{
    public partial class AddCustomer_Form : Form
    {
        public AddCustomer_Form()
        {
            InitializeComponent();

            // Set combo box as not editable
            SecurityQuestion_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            // Close the order basket form
            this.Close();
        }

        // When submit button is clicked
        private void Submit_Button_Click(object sender, EventArgs e)
        {
            // If check form returns false, so form is not valis
            if (CheckForm() == false)
            {
                // Open message box showing invalid input
                System.Windows.Forms.MessageBox.Show("Invalid Input!");
                return;
            }

            // Run add customer method to add customer to database
            AddCutomer.AddCustomer(FirstName_TextBox.Text + " " + LastName_TextBox.Text, AddressLine1_TextBox.Text, AddressLine2_TextBox.Text, AddressLine3_TextBox.Text, Postcode_TextBox.Text, PhoneNumber_TextBox.Text, EmailAddress_TextBox.Text, SecurityQuestion_ComboBox.Text, SecurityQuestion_TextBox.Text);

            
            // Close the order basket form
            this.Close();
        }

        // Method to check the form input values
        public bool CheckForm()
        {
            bool isValid = true;

            // Check First Name
            // If first name is invalid
            if (!CheckName(FirstName_TextBox.Text))
            {
                // Set text box colour to salmon
                FirstName_TextBox.BackColor = Color.Salmon;
                // Set isvalid to false
                isValid = false;
            }
            // Else first name is valid
            else
            {
                // Set text box colour to green
                FirstName_TextBox.BackColor = Color.LightGreen;
            }

            // Check Last Name
            // If last name is invalid
            if (!CheckName(LastName_TextBox.Text))
            {
                // Set text box colour to salmon
                LastName_TextBox.BackColor = Color.Salmon;
                isValid = false;
            }
            // Else last name is valid
            else
            {
                // Set text box colour to green
                LastName_TextBox.BackColor = Color.LightGreen;
            }

            // Check Anything in address line 1
            // If addtess is invalid
            if (!CheckAddress(AddressLine1_TextBox.Text))
            {
                // Set text box colour to salmon
                AddressLine1_TextBox.BackColor = Color.Salmon;
                isValid = false;
            }
            // Else address line 1 is valid
            else
            {
                // Set text box colour to green
                AddressLine1_TextBox.BackColor = Color.LightGreen;
            }

            // Check postcode
            // If postcode is invalid
            if (!CheckPostcode(Postcode_TextBox.Text))
            {
                // Set text box colour to salmon
                Postcode_TextBox.BackColor = Color.Salmon;
                isValid = false;
            }
            // Else postcode is valid
            else
            {
                // Set text box colour to green
                Postcode_TextBox.BackColor = Color.LightGreen;
            }

            // Check phone number
            // If first name is invalid
            if (!CheckValidPhoneNumber(PhoneNumber_TextBox.Text))
            {
                // Set text box colour to salmon
                PhoneNumber_TextBox.BackColor = Color.Salmon;
                isValid = false;
            }
            // Else phone number is valid
            else
            {
                // Set text box colour to green
                PhoneNumber_TextBox.BackColor = Color.LightGreen;
            }

            // check email address
            // If first name is invalid
            if (!CheckValidEmailAddress(EmailAddress_TextBox.Text))
            {
                // Set text box colour to salmon
                EmailAddress_TextBox.BackColor = Color.Salmon;
                isValid = false;
            }
            else
            {
                // Set text box colour to green
                EmailAddress_TextBox.BackColor = Color.LightGreen;
            }

            // check security question
            // If first name is invalid
            if (!CheckSecurityQuestion(SecurityQuestion_TextBox.Text))
            {
                // Set text box colour to salmon
                SecurityQuestion_TextBox.BackColor = Color.Salmon;
                isValid = false;
            }
            // Else security question is valid
            else
            {
                // Set text box colour to green
                SecurityQuestion_TextBox.BackColor = Color.LightGreen;
            }
            
            // Return form isvalid result
            return isValid;
        }

        // Check if email address is valid
        public bool CheckValidEmailAddress(string emailAddress)
        {
            // If email address is empty
            if (emailAddress == "")
            {
                // Return email address is false (invalid)
                return false;
            }

            // Try to use mail library to connect to email
            try
            {
                // Try to connect to email
                var address = new System.Net.Mail.MailAddress(emailAddress);
                // On success, retur true (valid)
                return true;
            }
            // If unable to connect to email
            catch
            {
                // return false (invalid)
                return false;
            }
        }
        
        // Method to check if phone number is valid
        public bool CheckValidPhoneNumber(string phoneNumber)
        {
            // Return result of regex which checks for format and values of the phone number
            return Regex.Match(phoneNumber, @"^(\+44\s?7\d{3}|\(?07\d{3}\)?)\s?\d{3}\s?\d{3}(\s?\#(\d{4}|\d{3}))?$").Success;
        }

        // Method to check the name is valid
        public bool CheckName(string name)
        {
            // If name is empty
            if (name == "")
            {
                // return false (name invalid)
                return false;
            }

            // Check and return result of first Name agast regex which checks format and characters
            return (!(Regex.Match(name.ToLower(), @"^[A-Za-z]+[\s][A-Za-z]+[.][A-Za-z]+$").Success));
            
        }

        // Method to check address is falid
        public bool CheckAddress(string address)
        {
            // Check Anything in address line 1
            if (address.Count() == 0)
            {
                // Return false (address invalid)
                return false;
            }
            // If address box not empty
            else
            {
                // return true (address valid)
                return true;
            }
        }

        // Method to check postcode is valid
        public bool CheckPostcode(string postcode)
        {
            // Check postcode against regex string and compare results then return
            return Regex.Match(postcode.ToLower(), @"^(GIR 0AA)|[a-z-[qvx]](?:\d|\d{2}|[a-z-[qvx]]\d|[a-z-[qvx]]\d[a-z-[qvx]]|[a-z-[qvx]]\d{2})(?:\s?\d[a-z-[qvx]]{2})?$").Success;
        }

        // Method to check security question is valid
        public bool CheckSecurityQuestion(string securityQuestion)
        {
            // check security question against regex and return false if is true or if security question is empty
            if ((Regex.Match(securityQuestion.ToLower(), @"^[A-Za-z]+[\s][A-Za-z]+[.][A-Za-z]+$").Success == true) || (securityQuestion.Count() == 0))
            {
                // return false (invalid)
                return false;
            }
            else
            {
                // Return true (valid)
                return true;
            }
        }
    }
}
