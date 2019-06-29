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
            // Create add customer form object for test
            AddCustomer_Form addCustomerForm = new AddCustomer_Form();
            // Check the valid email address method provides the correct results
            Assert.AreEqual(addCustomerForm.CheckValidEmailAddress("Test@TestMail.com"), true);
            Assert.AreEqual(addCustomerForm.CheckValidEmailAddress("8bc6b8t2987&^"), false);
            Assert.AreEqual(addCustomerForm.CheckValidEmailAddress("Test123@TestMail.com"), true);
            Assert.AreEqual(addCustomerForm.CheckValidEmailAddress("Test123@TestMail123.com"), true);
            Assert.AreEqual(addCustomerForm.CheckValidEmailAddress("Test123.TestMail.com"), false);
            Assert.AreEqual(addCustomerForm.CheckValidEmailAddress(""), false);
        }

        // Test valid phone number check
        [TestMethod]
        public void CheckValidPhoneNumber_Test()
        {
            // Create add customer form object for test
            AddCustomer_Form addCustomerForm = new AddCustomer_Form();
            // Check the valid phone number method provides the correct results
            Assert.AreEqual(addCustomerForm.CheckValidPhoneNumber("07799775274"),true);
            Assert.AreEqual(addCustomerForm.CheckValidPhoneNumber("8bc6b8t2987&^"), false);
            Assert.AreEqual(addCustomerForm.CheckValidPhoneNumber("+447481444676"), true);
        }
        
        // Test valid name test
        [TestMethod]
        public void CheckName_Test()
        {
            // Create add customer form object for test
            AddCustomer_Form addCustomerForm = new AddCustomer_Form();
            // Check that the method to check customer name is working correctly
            Assert.AreEqual(addCustomerForm.CheckName("TestName"), true);
            Assert.AreEqual(addCustomerForm.CheckName(""), false);
        }

        // Test valid address test
        [TestMethod]
        public void CheckAddress_Test()
        {
            // Create add customer form object for test
            AddCustomer_Form addCustomerForm = new AddCustomer_Form();
            // Check that the method to check customer name is working correctly
            Assert.AreEqual(addCustomerForm.CheckAddress("TestAddress"), true);
            Assert.AreEqual(addCustomerForm.CheckAddress(""), false);
        }

        // Test valid postcode test
        [TestMethod]
        public void CheckPostcode_Test()
        {
            // Create add customer form object for test
            AddCustomer_Form addCustomerForm = new AddCustomer_Form();
            // Check that the method to check postode is working correctly
            Assert.AreEqual(addCustomerForm.CheckPostcode("BS167ES"), true);
            Assert.AreEqual(addCustomerForm.CheckPostcode("d58v7fb£"), false);
            Assert.AreEqual(addCustomerForm.CheckPostcode(""), false);
        }

        // Test valid security queston check
        [TestMethod]
        public void CheckSecurityQuestion_Test()
        {
            // Create add customer form object for test
            AddCustomer_Form addCustomerForm = new AddCustomer_Form();
            // Check that the method to check security question is working correctly
            Assert.AreEqual(addCustomerForm.CheckSecurityQuestion("BS167ES"), true);
            Assert.AreEqual(addCustomerForm.CheckSecurityQuestion(""), false);
        }

        // Test valid form test
        [TestMethod]
        public void CheckForm_Test()
        {
            // Create add customer form object for test
            AddCustomer_Form addCustomerForm = new AddCustomer_Form();
            // Set values of form for test
            addCustomerForm.FirstName_TextBox.Text = "FirstName";
            addCustomerForm.LastName_TextBox.Text = "LastName";
            addCustomerForm.AddressLine1_TextBox.Text = "AddressLine1";
            addCustomerForm.AddressLine1_TextBox.Text = "AddressLine2";
            addCustomerForm.AddressLine1_TextBox.Text = "AddressLine3";
            addCustomerForm.Postcode_TextBox.Text = "BS167EY";
            addCustomerForm.PhoneNumber_TextBox.Text = "07481444676";
            addCustomerForm.EmailAddress_TextBox.Text = "Test@TestMail.com";
            addCustomerForm.SecurityQuestion_TextBox.Text = "Answer";
            // Check that the values added to form are correct and the checkform method works
            Assert.AreEqual(addCustomerForm.CheckForm(), true);
            // Set values of form for test
            addCustomerForm.FirstName_TextBox.Text = "";
            addCustomerForm.LastName_TextBox.Text = "";
            addCustomerForm.AddressLine1_TextBox.Text = "";
            addCustomerForm.AddressLine1_TextBox.Text = "";
            addCustomerForm.AddressLine1_TextBox.Text = "";
            addCustomerForm.Postcode_TextBox.Text = "";
            addCustomerForm.PhoneNumber_TextBox.Text = "";
            addCustomerForm.SecurityQuestion_TextBox.Text = "";
            // Check that the values added to form are invalid and the checkform method works
            Assert.AreEqual(addCustomerForm.CheckForm(), false);
            // Set values of form for test
            addCustomerForm.FirstName_TextBox.Text = "d58v7fb£";
            addCustomerForm.LastName_TextBox.Text = "d58v7fb£";
            addCustomerForm.AddressLine1_TextBox.Text = "d58v7fb£";
            addCustomerForm.AddressLine1_TextBox.Text = "d58v7fb£";
            addCustomerForm.AddressLine1_TextBox.Text = "d58v7fb£";
            addCustomerForm.Postcode_TextBox.Text = "d58v7fb£";
            addCustomerForm.PhoneNumber_TextBox.Text = "d58v7fb£";
            addCustomerForm.SecurityQuestion_TextBox.Text = "d58v7fb£";
            // Check that the values added to form are invalid and the checkform method works
            Assert.AreEqual(addCustomerForm.CheckForm(), false);
            
        }
    }
}
