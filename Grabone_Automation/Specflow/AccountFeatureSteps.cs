using Grabone_Automation.Config;
using Grabone_Automation.Global;
using Grabone_Automation.Pages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using RelevantCodes.ExtentReports;
using System;
using TechTalk.SpecFlow;

namespace Grabone_Automation.Specflow
{
    [Binding]
    public class AccountFeatureSteps: Global.Base
    {
        [Given(@"I have logged into the website")]
        public void GivenIHaveLoggedIntoTheWebsite()
        {
            Base BaseObj = new Base();
            BaseObj.Inititalize();
        }

        [When(@"I changed my account  details")]
        public void WhenIChangedMyAccountDetails()
        {

            // Creates a toggle for the given test, adds all log events under it    
            test = extent.StartTest("Update user Account");

            // Create a class object to call the method
            Account AccountObj = new Account();
            AccountObj.UpdateAccount();
        }
        
        [Then(@"I should be able to update details")]
        public void ThenIShouldBeAbleToUpdateDetails()
        {
            // Creates a toggle for the given test, adds all log events under it    
            test = extent.StartTest(" Update user account");
           //Base.test.Log(LogStatus.Info, " SpecFlow Test Search Skill Successfull");
            Base obj = new Base();
            obj.TearDown();
        }
    }
}
