using Grabone_Automation.Global;
using Grabone_Automation.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grabone_Automation.Test
{
    class Sprint 
    {
      [TestFixture]
      [Category("Sprint1")]
       class Tenant : Base
       {
        
            [Test]
            public void TestUpdateAccount()
            {
                // Creates a toggle for the given test, adds all log events under it    
                test = extent.StartTest("Update user account with valid details");

                // Create an class and object to call the method
                Account AccountObj = new Account();
                AccountObj.UpdateAccount();
            }

            [Test]
            public void TestProfilePage()
            {
                // Creates a toggle for the given test, adds all log events under it    
                test = extent.StartTest("Update profile page  with valid details");

                // Create an class and object to call the method
                Profile ProfileObj = new Profile();
                ProfileObj.ProfileUpdate();
            }

            [Test]
            public void TestSubscription()
            {

                // Creates a toggle for the given test, adds all log events under it    
                test = extent.StartTest("Update daily subscriptions page");

                // Create an class and object to call the method
                Subscriptions SubscriptionObj = new Subscriptions();
                SubscriptionObj.DailySubscription();
                
                SubscriptionObj.DealsSubscription();
            }

            [Test]
            public void TestUnSubscription()
            {

                // Creates a toggle for the given test, adds all log events under it    
                test = extent.StartTest("unsubscribe from all emails");

                // Create an class and object to call the method

                Unsubscribe UnSubscriptionObj = new Unsubscribe();
                UnSubscriptionObj.UnSubscribeMails();

            }

            [Test]
            public void TestHomeSubscription()
            {

                // Creates a toggle for the given test, adds all log events under it    
                test = extent.StartTest("Update Top deals subscription");

                // Create an class and object to call the method
    
                Top_Subscribe TopSubscriptionObj = new Top_Subscribe();
                TopSubscriptionObj.DealsSubscription();
                Daily_Subscribe DailySubscribeObj = new Daily_Subscribe();
                DailySubscribeObj.DailySubscriptions();

            }


        }
    }
}
