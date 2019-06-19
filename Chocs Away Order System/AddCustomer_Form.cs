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

        private void Submit_Button_Click(object sender, EventArgs e)
        {
            if (CheckForm() == false)
            {
                System.Windows.Forms.MessageBox.Show("Invalid Input!");
                return;
            }

            AddCutomer.AddCustomer(FirstName_TextBox.Text + " " + LastName_TextBox.Text, AddressLine1_TextBox.Text, AddressLine2_TextBox.Text, AddressLine3_TextBox.Text, Postcode_TextBox.Text, PhoneNumber_TextBox.Text, EmailAddress_TextBox.Text, SecurityQuestion_ComboBox.Text, SecurityQuestion_TextBox.Text);

            
            // Close the order basket form
            this.Close();
        }

        public bool CheckForm()
        {
            bool isValid = true;

            // Check First Name
            if (!CheckName(FirstName_TextBox.Text))
            {
                FirstName_TextBox.BackColor = Color.Salmon;
                isValid = false;
            }
            else
            {
                FirstName_TextBox.BackColor = Color.LightGreen;
            }
            // Check Last Name
            if (!CheckName(LastName_TextBox.Text))
            {
                LastName_TextBox.BackColor = Color.Salmon;
                isValid = false;
            }
            else
            {
                LastName_TextBox.BackColor = Color.LightGreen;
            }
            // Check Anything in address line 1
            if (!CheckAddress(AddressLine1_TextBox.Text))
            {
                AddressLine1_TextBox.BackColor = Color.Salmon;
                isValid = false;
            }
            else
            {
                AddressLine1_TextBox.BackColor = Color.LightGreen;
            }
            // Check postcode
            if (!CheckPostcode(Postcode_TextBox.Text))
            {
                Postcode_TextBox.BackColor = Color.Salmon;
                isValid = false;
            }
            else
            {
                Postcode_TextBox.BackColor = Color.LightGreen;
            }
            // Check phone number
            if (!CheckValidPhoneNumber(PhoneNumber_TextBox.Text))
            {
                PhoneNumber_TextBox.BackColor = Color.Salmon;
                isValid = false;
            }
            else
            {
                PhoneNumber_TextBox.BackColor = Color.LightGreen;
            }
            // check email address
            if (!CheckValidEmailAddress(EmailAddress_TextBox.Text))
            {
                EmailAddress_TextBox.BackColor = Color.Salmon;
                isValid = false;
            }
            else
            {
                EmailAddress_TextBox.BackColor = Color.LightGreen;
            }
            // check security question
            if (!CheckSecurityQuestion(SecurityQuestion_TextBox.Text))
            {
                SecurityQuestion_TextBox.BackColor = Color.Salmon;
                isValid = false;
            }
            else
            {
                SecurityQuestion_TextBox.BackColor = Color.LightGreen;
            }

            return isValid;
        }

        public bool CheckValidEmailAddress(string emailAddress)
        {
            if (emailAddress == "")
            {
                return false;
            }

            try
            {
                var address = new System.Net.Mail.MailAddress(emailAddress);
                return true;
            }
            catch
            {
                return false;
            }
        }
        
        public bool CheckValidPhoneNumber(string phoneNumber)
        {
            return Regex.Match(phoneNumber, @"^(\+44\s?7\d{3}|\(?07\d{3}\)?)\s?\d{3}\s?\d{3}(\s?\#(\d{4}|\d{3}))?$").Success;
        }

        public bool CheckName(string name)
        {
            if (name == "")
            {
                return false;
            }

            // Check First Name
            return (!(Regex.Match(name.ToLower(), @"^[A-Za-z]+[\s][A-Za-z]+[.][A-Za-z]+$").Success));
            
        }

        public bool CheckAddress(string address)
        {
            // Check Anything in address line 1
            if (address.Count() == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool CheckPostcode(string postcode)
        {
            // Check postcode
            if (Regex.Match(postcode.ToLower(), @"^(GIR 0AA)|[a-z-[qvx]](?:\d|\d{2}|[a-z-[qvx]]\d|[a-z-[qvx]]\d[a-z-[qvx]]|[a-z-[qvx]]\d{2})(?:\s?\d[a-z-[qvx]]{2})?$").Success == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool CheckSecurityQuestion(string securityQuestion)
        {
            // check security question
            if ((Regex.Match(securityQuestion.ToLower(), @"^[A-Za-z]+[\s][A-Za-z]+[.][A-Za-z]+$").Success == true) || (securityQuestion.Count() == 0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
