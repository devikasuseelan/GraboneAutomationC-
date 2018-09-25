using Grabone_Automation.Global;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Grabone_Automation.Global.CommonMethods;

namespace Grabone_Automation.Pages
{
    class Account
    {
        public Account()
        {
            PageFactory.InitElements(Driver.driver, this);

        }

        #region InitializeElements

        //Click on  Change name link
        [FindsBy(How = How.XPath, Using = "//div[@id='my-account']/div/fieldset/form/div/div/a")]
        private IWebElement ChangeName { get; set; }

        //Click on  first name link
        [FindsBy(How = How.Name, Using = "account[first_name]")]
        private IWebElement FirstName { get; set; }

        //Click on last name
        [FindsBy(How = How.Name, Using = "account[last_name]")]
        private IWebElement LastName { get; set; }

        //Click on submit button
        [FindsBy(How = How.XPath, Using = "//div[@id='my-account']/div/fieldset/form/div/div[2]/div[3]/span/input")]
        private IWebElement SubmitName { get; set; }

        //Click on change password
        [FindsBy(How = How.XPath, Using = "//div[@id='my-account']/div/fieldset/form/div[3]/div/a")]
        private IWebElement ChangePassword { get; set; }

        //Click on current password
        [FindsBy(How = How.XPath, Using = "//div[@id='my-account']/div/fieldset/form/div[3]/div[2]/div/div/input")]
        private IWebElement CurrentPassword { get; set; }

        //Click on new password
        [FindsBy(How = How.XPath, Using = "//*[@id='account_raw_password']")]
        private IWebElement NewPassword { get; set; }

        //Click on confirm password
        [FindsBy(How = How.XPath, Using = "//*[@id='account_confirm_password']")]
        private IWebElement ConfirmPassword { get; set; }

        //Click on Submit button
        [FindsBy(How = How.XPath, Using = "//div[@id='my-account']/div/fieldset/form/div[3]/div[2]/div[4]/span/input")]
        private IWebElement SubmitPassword { get; set; }

        // Click on change email
        [FindsBy(How = How.XPath, Using = "//div[@id='my-account']/div/fieldset/form/div[4]/div/a")]
        private IWebElement ChangeEmail { get; set; }

        //Click on email field
        [FindsBy(How = How.XPath, Using = "//*[@id='account_email']")]
        private IWebElement Email { get; set; }

        //Click on submit email
        [FindsBy(How = How.XPath, Using = "//div[@id='my-account']/div/fieldset/form/div[4]/div[2]/div[2]/span/input")]
        private IWebElement SubmitEmail { get; set; }


        //Click on Change credit card details
        [FindsBy(How = How.XPath, Using = "//div[@id='my-account']/div/fieldset/form/div[5]/div/a")]
        private IWebElement ChangeCard { get; set; }

        //Click on forget button
        [FindsBy(How = How.XPath, Using = "//*[@id='account_forget_cards']")]
        private IWebElement ForgetButton { get; set; }

        //Click on change region link
        [FindsBy(How = How.XPath, Using = "//div[@id='my-account']/div/fieldset/form[2]/div/div/a")]
        private IWebElement ChangeRegion { get; set; }

        //Click on region dropdown list
        [FindsBy(How = How.XPath, Using = "//div[@id='my-account']/div/fieldset/form[2]/div/div[2]/div/div/select")]
        private IWebElement Region { get; set; }

        //Click on Submit bbutton
        [FindsBy(How = How.XPath, Using = "//div[@id='my-account']/div/fieldset/form[2]/div/div[2]/div[2]/span/input")]
        private IWebElement SubmitRegion { get; set; }

        //Click on change address link
        [FindsBy(How = How.XPath, Using = "//div[@id='my-account']/div/fieldset/div/div/a")]
        private IWebElement ChangeAddress { get; set; }

        //Click on Add new address button
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Add New Address')]")]
        private IWebElement AddNewAddress { get; set; }

        //Click on label field
        [FindsBy(How = How.XPath, Using = "//*[@id='address_label']")]
        private IWebElement Label { get; set; }

        //Click on Name field
        [FindsBy(How = How.XPath, Using = "//*[@id='address_name']")]
        private IWebElement Name { get; set; }

        //Click on Address field
        [FindsBy(How = How.XPath, Using = "//*[@id='address_address']")]
        private IWebElement Address { get; set; }

        //Click on Suburb field
        [FindsBy(How = How.XPath, Using = "//*[@id='address_locality']")]
        private IWebElement Suburb { get; set; }

        //Click on city field
        [FindsBy(How = How.XPath, Using = "//*[@id='address_city']")]
        private IWebElement City { get; set; }

        //Click on post code field
        [FindsBy(How = How.XPath, Using = "//*[@id='address_postcode']")]
        private IWebElement PostCode { get; set; }

        //Click on Contact Phone field
        [FindsBy(How = How.XPath, Using = "//*[@id='address_contact_phone']")]
        private IWebElement ContactPhone { get; set; }

        //Click on Add address button
        [FindsBy(How = How.XPath, Using = "//*[@id='content']/div[2]/div[2]/div/form/fieldset/div[9]/span/input")]
        private IWebElement AddAddress { get; set; }

        //Select update message
        [FindsBy(How = How.XPath, Using = "//*[@id='content']/div[1]/p")]
        private IWebElement UpdateMessage { get; set; }

        // Check Navigate to update account page
        [FindsBy(How = How.XPath, Using = "//*[@id='Context']/div[2]/div[2]/div/h1")]
        private IWebElement Update { get; set; }
        #endregion

        #region UPDATE ACCOUNT

        // Method for updating account details
        public void UpdateAccount()
        {

            // Populating the data from Excel
            ExcelLib.PopulateInCollection(Base.ExcelPath, "Account");

            //Click on change name link
            Thread.Sleep(1000);
            ChangeName.Click();

            //Enter first name
            FirstName.Clear();
            FirstName.SendKeys(ExcelLib.ReadData(2, "FirstName"));

            //Enter last name
            LastName.Clear();
            LastName.SendKeys(ExcelLib.ReadData(2, "LastName"));

            //Click on submit button
            SubmitName.Click();
            Base.test.Log(LogStatus.Info, "Update Name Successfull");

            //Click on change password
            //ChangePassword.Click();
            //Enter current password
            //CurrentPassword.SendKeys(ExcelLib.ReadData(2, "CurrentPassword"));
            //Enter new password
           // NewPassword.SendKeys(ExcelLib.ReadData(2, "NewPassword"));
            //Enter confirm password
            //ConfirmPassword.SendKeys(ExcelLib.ReadData(2, "ConfirmPassword"));
            //Click on submit button
            //SubmitPassword.Click();
            Base.test.Log(LogStatus.Info, "Update password Successfull");


            //Click on change email
            ChangeEmail.Click();
            //Enter Email address
            Email.Clear();
            Email.SendKeys(ExcelLib.ReadData(2, "Email"));
            //Click submit button
            SubmitEmail.Click();
            Base.test.Log(LogStatus.Info, "Update email Successfull");


            //Update cerdit card details
            ChangeCard.Click();
            //Click forget button to remove the credit card
            ForgetButton.Click();
            Base.test.Log(LogStatus.Info, "Remove credit card details Successfull");


            //Click on change region link
            ChangeRegion.Click();
            //Select a region fro dropdown list
            Region.Click();
            Driver.wait(2);
            Actions action = new Actions(Driver.driver);
            action.SendKeys(Region, Keys.ArrowDown).Perform();
            action.SendKeys(Region, Keys.Return).Click();
            //Click on submit button
            SubmitRegion.Click();
            try
            {
                Thread.Sleep(1000);
                Assert.That(Driver.driver.FindElement(By.LinkText("Your region has been updated")).Displayed);
                Base.test.Log(LogStatus.Info, "Updated region successfully");
            }
            catch (Exception)
            {
                Base.test.Log(LogStatus.Info, "Update region unsuccessfull");
            }

            //Click on Change address
            Driver.wait(2);
            ChangeAddress.Click();
            //Click on Add new address button
            Driver.wait(2);
            AddNewAddress.Click();
            string Expected = "Add Address";
            String Actual = Driver.driver.FindElement(By.XPath("//*[@id='content']/div[2]/div[2]/div/h1")).Text;
            if (Expected == Actual)
            {
                Base.test.Log(LogStatus.Info, "Navigated to Add Address page");
            }
            else
            {
                Base.test.Log(LogStatus.Info, "Navigate to Add Address page unsuccessfull");
            }
            //Enter the details in address page
            Driver.wait(2);
            Label.SendKeys(ExcelLib.ReadData(2, "Label"));
            Driver.wait(2);
            Name.Clear();
            Name.SendKeys(ExcelLib.ReadData(2, "Name"));
            Driver.wait(2);
            Address.SendKeys(ExcelLib.ReadData(2, "Address"));
            Driver.wait(2);
            Suburb.SendKeys(ExcelLib.ReadData(2, "Suburb"));
            Driver.wait(2);
            City.SendKeys(ExcelLib.ReadData(2, "City"));
            Driver.wait(2);
            PostCode.SendKeys(ExcelLib.ReadData(2, "PostCode"));
            Driver.wait(2);
            ContactPhone.SendKeys(ExcelLib.ReadData(2, "ContactPhone"));
            Driver.wait(2);
            AddAddress.Click();
            Thread.Sleep(1000);
            try
            {
                //string ExpectedMessage = "Your address has been saved as work";
                //String ActualMessage = Driver.driver.FindElement(By.PartialLinkText(ExpectedMessage)).Text;
                Thread.Sleep(1000);
                Assert.That(Driver.driver.FindElement(By.LinkText("Update Account")).Displayed);
                
                Base.test.Log(LogStatus.Info, "Updated address successfully");
            }
            catch (Exception)
            {
                Base.test.Log(LogStatus.Info, "Update address unsuccessfull");
            }

            Base.test.Log(LogStatus.Info, "Updated useraccount successfully");

        }


    }


}
#endregion
    

