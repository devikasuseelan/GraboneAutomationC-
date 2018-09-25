using Grabone_Automation.Global;
using Grabone_Automation.Pages;
using System;
using TechTalk.SpecFlow;

namespace Grabone_Automation.Specflow
{
    [Binding]
    public class SubscriptionsSpecFlowSteps: Global.Base
    {
        [When(@"I selected preferences for getting emails")]
        public void WhenISelectedPreferencesForGettingEmails()
        {
            // Creates a toggle for the given test, adds all log events under it    
            test = extent.StartTest("Update subscriptions page");

            // Create an class and object to call the method
            Subscriptions SubscriptionObj = new Subscriptions();
            SubscriptionObj.DailySubscription();

            SubscriptionObj.DealsSubscription();
        }
        
        [Then(@"I should get the subscription enabled message")]
        public void ThenIShouldGetTheSubscriptionEnabledMessage()
        {
            // Creates a toggle for the given test, adds all log events under it    
            test = extent.StartTest(" Suscribed to emails");
            //Base.test.Log(LogStatus.Info, " SpecFlow Test Search Skill Successfull");
            Base obj = new Base();
            obj.TearDown();
        }
    }
}
