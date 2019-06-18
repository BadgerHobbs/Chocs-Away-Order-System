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

        private bool CheckForm()
        {
            bool isValid = true;

            // Check First Name
            if ((Regex.Match(FirstName_TextBox.Text, @"^[A-Za-z]+[\s][A-Za-z]+[.][A-Za-z]+$").Success == true) || (FirstName_TextBox.Text == ""))
            {
                FirstName_TextBox.BackColor = Color.Salmon;
                isValid = false;
            }
            else
            {
                FirstName_TextBox.BackColor = Color.LightGreen;
            }
            // Check Last Name
            if ((Regex.Match(LastName_TextBox.Text, @"^[A-Za-z]+[\s][A-Za-z]+[.][A-Za-z]+$").Success == true) || (LastName_TextBox.Text == ""))
            {
                LastName_TextBox.BackColor = Color.Salmon;
                isValid = false;
            }
            else
            {
                LastName_TextBox.BackColor = Color.LightGreen;
            }
            // Check Anything in address line 1
            if (AddressLine1_TextBox.Text.Count() == 0)
            {
                AddressLine1_TextBox.BackColor = Color.Salmon;
                isValid = false;
            }
            else
            {
                AddressLine1_TextBox.BackColor = Color.LightGreen;
            }
            // Check postcode
            if (Regex.Match(Postcode_TextBox.Text.ToLower(), @"^(GIR 0AA)|[a-z-[qvx]](?:\d|\d{2}|[a-z-[qvx]]\d|[a-z-[qvx]]\d[a-z-[qvx]]|[a-z-[qvx]]\d{2})(?:\s?\d[a-z-[qvx]]{2})?$").Success == false)
            {
                Postcode_TextBox.BackColor = Color.Salmon;
                isValid = false;
            }
            else
            {
                Postcode_TextBox.BackColor = Color.LightGreen;
            }
            // Check phone number
            if (CheckValidPhoneNumber(PhoneNumber_TextBox.Text) == false)
            {
                PhoneNumber_TextBox.BackColor = Color.Salmon;
                isValid = false;
            }
            else
            {
                PhoneNumber_TextBox.BackColor = Color.LightGreen;
            }
            // check email address
            if (CheckValidEmailAddress(EmailAddress_TextBox.Text) == false)
            {
                EmailAddress_TextBox.BackColor = Color.Salmon;
                isValid = false;
            }
            else
            {
                EmailAddress_TextBox.BackColor = Color.LightGreen;
            }
            // check security question
            if ((Regex.Match(SecurityQuestion_TextBox.Text, @"^[A-Za-z]+[\s][A-Za-z]+[.][A-Za-z]+$").Success == true) || (SecurityQuestion_TextBox.Text == ""))
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

        private bool CheckValidEmailAddress(string emailAddress)
        {
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
        
        private bool CheckValidPhoneNumber(string phoneNumber)
        {
            return Regex.Match(phoneNumber, @"^(\+44\s?7\d{3}|\(?07\d{3}\)?)\s?\d{3}\s?\d{3}(\s?\#(\d{4}|\d{3}))?$").Success;
        }
    }
}
