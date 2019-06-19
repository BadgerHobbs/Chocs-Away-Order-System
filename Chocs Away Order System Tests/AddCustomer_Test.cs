using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chocs_Away_Order_System;
using System.Windows.Forms;

namespace Chocs_AwayChocs_Away_Order_System.Tests
{
    [TestClass]
    public class AddCustomer_Test
    {
        // Test valid email check
        [TestMethod]
        public void CheckValidEmailAddress_Test()
        {
            AddCustomer_Form addCustomerForm = new AddCustomer_Form();
            
            Assert.AreEqual(addCustomerForm.CheckValidEmailAddress("Test@TestMail.com"), true);
            Assert.AreEqual(addCustomerForm.CheckValidEmailAddress("8bc6b8t2987&^"), false);
            Assert.AreEqual(addCustomerForm.CheckValidEmailAddress("Test123@TestMail.com"), true);
            Assert.AreEqual(addCustomerForm.CheckValidEmailAddress("Test123@TestMail123.com"), true);
            Assert.AreEqual(addCustomerForm.CheckValidEmailAddress("Test123.TestMail.com"), false);
            Assert.AreEqual(addCustomerForm.CheckValidEmailAddress(""), false);
        }

        // Test valid email check
        [TestMethod]
        public void CheckValidPhoneNumber_Test()
        {
            AddCustomer_Form addCustomerForm = new AddCustomer_Form();

            Assert.AreEqual(addCustomerForm.CheckValidPhoneNumber("07799775274"),true);
            Assert.AreEqual(addCustomerForm.CheckValidPhoneNumber("8bc6b8t2987&^"), false);
            Assert.AreEqual(addCustomerForm.CheckValidPhoneNumber("+447481444676"), true);
        }
        
        // Test valid form
        [TestMethod]
        public void CheckName_Test()
        {
            AddCustomer_Form addCustomerForm = new AddCustomer_Form();

            Assert.AreEqual(addCustomerForm.CheckName("TestName"), true);
            Assert.AreEqual(addCustomerForm.CheckName(""), false);
        }

        // Test valid form
        [TestMethod]
        public void CheckAddress_Test()
        {
            AddCustomer_Form addCustomerForm = new AddCustomer_Form();

            Assert.AreEqual(addCustomerForm.CheckAddress("TestAddress"), true);
            Assert.AreEqual(addCustomerForm.CheckAddress(""), false);
        }

        // Test valid form
        [TestMethod]
        public void CheckPostcode_Test()
        {
            AddCustomer_Form addCustomerForm = new AddCustomer_Form();

            Assert.AreEqual(addCustomerForm.CheckPostcode("BS167ES"), true);
            Assert.AreEqual(addCustomerForm.CheckPostcode("d58v7fb£"), false);
            Assert.AreEqual(addCustomerForm.CheckPostcode(""), false);
        }

        // Test valid form
        [TestMethod]
        public void CheckSecurityQuestion_Test()
        {
            AddCustomer_Form addCustomerForm = new AddCustomer_Form();

            Assert.AreEqual(addCustomerForm.CheckSecurityQuestion("BS167ES"), true);
            //Assert.AreEqual(addCustomerForm.CheckSecurityQuestion(""), false);
        }

        // Test valid form
        [TestMethod]
        public void CheckForm_Test()
        {
            AddCustomer_Form addCustomerForm = new AddCustomer_Form();

            addCustomerForm.FirstName_TextBox.Text = "TestFirstName";
            addCustomerForm.LastName_TextBox.Text = "TestLastName";
            addCustomerForm.AddressLine1_TextBox.Text = "TestAddressLine1";
            addCustomerForm.AddressLine1_TextBox.Text = "TestAddressLine2";
            addCustomerForm.AddressLine1_TextBox.Text = "TestAddressLine3";
            addCustomerForm.Postcode_TextBox.Text = "BS167EY";
            addCustomerForm.PhoneNumber_TextBox.Text = "07799775274";
            addCustomerForm.SecurityQuestion_TextBox.Text = "TestAnswer";

            Assert.AreEqual(addCustomerForm.CheckForm(), true);

            addCustomerForm.FirstName_TextBox.Text = "";
            addCustomerForm.LastName_TextBox.Text = "";
            addCustomerForm.AddressLine1_TextBox.Text = "";
            addCustomerForm.AddressLine1_TextBox.Text = "";
            addCustomerForm.AddressLine1_TextBox.Text = "";
            addCustomerForm.Postcode_TextBox.Text = "";
            addCustomerForm.PhoneNumber_TextBox.Text = "";
            addCustomerForm.SecurityQuestion_TextBox.Text = "";

            Assert.AreEqual(addCustomerForm.CheckForm(), false);

            addCustomerForm.FirstName_TextBox.Text = "d58v7fb£";
            addCustomerForm.LastName_TextBox.Text = "d58v7fb£";
            addCustomerForm.AddressLine1_TextBox.Text = "d58v7fb£";
            addCustomerForm.AddressLine1_TextBox.Text = "d58v7fb£";
            addCustomerForm.AddressLine1_TextBox.Text = "d58v7fb£";
            addCustomerForm.Postcode_TextBox.Text = "d58v7fb£";
            addCustomerForm.PhoneNumber_TextBox.Text = "d58v7fb£";
            addCustomerForm.SecurityQuestion_TextBox.Text = "d58v7fb£";

            Assert.AreEqual(addCustomerForm.CheckForm(), false);
        }
    }
}
