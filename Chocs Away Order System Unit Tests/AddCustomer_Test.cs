using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chocs_Away_Order_System;
using System.Windows.forms;

namespace Chocs_AwayChocs_Away_Order_System.Tests
{
    [TestClass]
    class AddCustomer_Test
    {
        // Test valid email check
        [TestMethod]
        public void checkValidEmailAddress_Test()
        {
            
        }

        // Test valid email check
        [TestMethod]
        public void checkValidPhoneNumber_Test()
        {
            AddCustomer_Form addCustomerForm = new AddCustomer_Form();

            addCustomerForm.CheckValidPhoneNumber("07799775274");
        }
    }
}
