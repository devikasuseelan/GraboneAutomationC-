using Grabone_Automation.Global;
using Grabone_Automation.Pages;
using NUnit.Core;
using RelevantCodes.ExtentReports.Model;
using System;
using TechTalk.SpecFlow;

namespace Grabone_Automation
{
    [Binding]
    public class UnSubscriptionSpecFlowSteps: Global.Base
    {
        [Given(@"I have logged into the grabone website")]
        public void GivenIHaveLoggedIntoTheGraboneWebsite()
        {
            Base BaseObj = new Base();
            BaseObj.Inititalize();
        }

        [When(@"I unsubscribed from getting mails")]
        public void WhenIUnsubscribedFromGettingMails()
        {
            // Creates a toggle for the given test, adds all log events under it    
            test = extent.StartTest("unsubscribe from all emails");

            // Create an class and object to call the method

            Unsubscribe UnSubscriptionObj = new Unsubscribe();
            UnSubscriptionObj.UnSubscribeMails();

        }

        [Then(@"I should get an update message")]
        public void ThenIShouldGetAnUpdateMessage()
        {
            // Creates a toggle for the given test, adds all log events under it    
            test = extent.StartTest(" unsubscribed from all emails");
            //Base.test.Log(LogStatus.Info, " SpecFlow Test Search Skill Successfull");
            Base obj = new Base();
            obj.TearDown();
        }
    }
}
