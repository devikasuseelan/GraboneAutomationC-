using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using static Grabone_Automation.Global.CommonMethods;

namespace Grabone_Automation.Global
{
    public class Register
    {
        internal Register()
        {
            PageFactory.InitElements(Driver.driver, this);

        }
        // Click on User Icon
        [FindsBy(How = How.XPath, Using = "//div[@id='banner-account-links']/ul/li[2]/div/button")]
        private IWebElement UserBanner { get; set; }

        //Click on My Account
        [FindsBy(How = How.XPath, Using = "//ul[@id='user-nav-account']/li/a")]
        private IWebElement MyAccount { get; set; }

        //Click on Register Here Link
        [FindsBy(How = How.XPath, Using = "//span[@id='dialog-register']/a")]
        private IWebElement RegisterLink { get; set; }

        //Enter FirstName
        [FindsBy(How = How.XPath, Using = "//input[@id='register_first_name']")]
        private IWebElement FirstName { get; set; }

        //Enter LastName
        [FindsBy(How = How.XPath, Using = "//input[@id='register_last_name']")]
        private IWebElement LastName { get; set; }

        //click on Email
        [FindsBy(How = How.XPath, Using = "//input[@id='register_email']")]
        private IWebElement Email { get; set; }

        //Click on Password
        [FindsBy(How = How.XPath, Using = "//input[@id='register_raw_password']")]
        private IWebElement Password { get; set; }

        //Click on Retype password
        [FindsBy(How = How.XPath, Using = "//input[@id='register_reenter_password']")]
        private IWebElement RePassword { get; set; }

        //Accept terms and conditions
        [FindsBy(How = How.XPath, Using = "//input[@id='register_terms_and_conditions']")]
        private IWebElement Terms { get; set; }

        //Click on Register Button
        [FindsBy(How = How.XPath, Using = "//input[@value='Register']")]
        private IWebElement Registerbutton { get; set; }

        internal void Navigateregister()
        {
            ExcelLib.PopulateInCollection(Base.ExcelPath, "Register");
            // Navigating to Home page using value from Excel
            Driver.driver.Navigate().GoToUrl(ExcelLib.ReadData(2, "url"));

            //Click on UserIcon
           // Driver.wait(2);
           // UserBanner.Click();


            //Slect MyAccount from dropdown
           // Driver.wait(2);
           // MyAccount.Click();

            //Click on the Register link
            Driver.wait(2);
            RegisterLink.Click();

            Driver.wait(2);
            //Read FirstName
            FirstName.SendKeys(ExcelLib.ReadData(2, "FirstName"));

            //Read LastName
            Driver.wait(2);
            LastName.SendKeys(ExcelLib.ReadData(2, "LastName"));

            //Read Email
            Email.SendKeys(ExcelLib.ReadData(2, "Email"));

            Driver.wait(2);
            //Read Password
            Password.SendKeys(ExcelLib.ReadData(2, "Password"));

            Driver.wait(2);
            //Read RetypePassword
            RePassword.SendKeys(ExcelLib.ReadData(2, "RetypePassword"));


            //Click on Terms and Conditions
            Driver.wait(2);
            Terms.Click();

            //Click on Signup
            Driver.wait(2);
            Registerbutton.Click();

        }
    }
}