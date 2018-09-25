using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using static Grabone_Automation.Global.CommonMethods;

namespace Grabone_Automation.Global
{
    internal class Login
    {      
        //create constructor
        public Login()
        {
            PageFactory.InitElements(Driver.driver, this);
        }


        #region  Initialize Web Elements 

        // Click on User Icon
        [FindsBy(How = How.XPath, Using = "//div[@id='banner-account-links']/ul/li[2]/div/button")]
        private IWebElement UserBanner { get; set; }

        //Click on My Account
        [FindsBy(How = How.XPath, Using = "//ul[@id='user-nav-account']/li/a")]
        private IWebElement MyAccount { get; set; }
        // Finding the Email Field
        [FindsBy(How = How.XPath, Using = "//*[@id='login_email']")]
        private IWebElement Email { get; set; }

        // Finding the Password Field
        [FindsBy(How = How.XPath, Using = "//*[@id='login_password']")]
        private IWebElement PassWord { get; set; }

        // Finding rememberme check box
        [FindsBy(How = How.XPath, Using = "//*[@id='login_remember_me']")]
        private IWebElement RememberMe { get; set; }
        
        // Finding the Login Button
        [FindsBy(How = How.XPath, Using = "//*[@id='login']/fieldset/div[4]/input")]
        private IWebElement loginButton { get; set; }

        #endregion

        internal void LoginSuccessfull()
        {
            // Populating the data from Excel
            ExcelLib.PopulateInCollection(Base.ExcelPath, "LoginPage");

            // Navigating to Login page using value from Excel
            Driver.driver.Navigate().GoToUrl(ExcelLib.ReadData(2, "Url"));


            //Click on UserIcon
            Driver.wait(2);
            UserBanner.Click();


            //Slect MyAccount from dropdown
            Driver.wait(2);
            MyAccount.Click();


            // Sending the username 
            Driver.wait(2);
            Email.SendKeys(ExcelLib.ReadData(2, "Email"));

            // Sending the password
            Driver.wait(2);
            PassWord.SendKeys(ExcelLib.ReadData(2, "Password"));

            //Selecting rememberme checkbox
            Driver.wait(2);
            RememberMe.Click();

            // Clicking on the login button
            loginButton.Click();
        }
    }
}