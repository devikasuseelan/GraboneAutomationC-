using Grabone_Automation.Global;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grabone_Automation.Pages
{
    class ConnectWithFacebook
    {
        public ConnectWithFacebook()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        //Click on connect with facebook
        [FindsBy(How = How.XPath, Using = "//a[@id='facebook-connect-button']")]
        private IWebElement ConnectFacebook { get; set; }

        //Check if directed to facebook page
        [FindsBy(How = How.XPath, Using = "//i[@class='fb_logo img sp_TqdTTRwIEat sx_59d053']")]
        private IWebElement FacebookPage { get; set; }

        public void Facebook()
        {
            Driver.wait(2);
            ConnectFacebook.Click();
            Driver.wait(2);
            try
            {
                Driver.wait(2);
                String Expected = "facebook";
                String Actual = FacebookPage.Text;
                Assert.AreEqual(Expected, Actual);
                Base.test.Log(LogStatus.Info, "Navigate to facebook page successfull");

            }
            catch
            {
                Base.test.Log(LogStatus.Info, "Navigate to facebook page Unsuccessfull");
            }
       
        }


    }
}
