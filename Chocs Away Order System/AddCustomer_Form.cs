using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chocs_Away_Order_System
{
    public partial class AddCustomer_Form : Form
    {
        public AddCustomer_Form()
        {
            InitializeComponent();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            // Close the order basket form
            this.Close();
        }

        private void Submit_Button_Click(object sender, EventArgs e)
        {
            AddCutomer.AddCustomer(FirstName_TextBox.Text + " " + LastName_TextBox.Text, AddressLine1_TextBox.Text, AddressLine2_TextBox.Text, AddressLine3_TextBox.Text, Postcode_TextBox.Text, PhoneNumber_TextBox.Text, EmailAddress_TextBox.Text, SecurityQuestion_ComboBox.Text, SecurityQuestion_TextBox.Text);

            // Close the order basket form
            this.Close();
        }
    }
}
