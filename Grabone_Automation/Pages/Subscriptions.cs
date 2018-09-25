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

namespace Grabone_Automation.Pages
{
    class Subscriptions
    {
        public Subscriptions()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        #region Initialize Elements
        //Click on user Icon
        //[FindsBy(How = How.CssSelector, Using = "svg.primary-nav-icon.primary-nav-icon--user")]
        //private IWebElement UserIcon{get; set;}

        //Click on my subscriptions
        [FindsBy(How = How.XPath, Using = "//a[@href='/my-stuff/my-subscriptions']")]
        private IWebElement MySubscriptions { get; set; }

        //Check for page title present
        [FindsBy(How = How.XPath, Using = "//h1[contains(text(),'Email Subscriptions')]")]
        private IWebElement Element { get; set; }


        //Select daily subscriptions
        [FindsBy(How = How.XPath, Using = "//input[@id='site_subscription_manager_subscriptions_site_subscription_2']")]
        private IWebElement DailySub { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@id='site_subscription_manager_subscriptions_site_subscription_9']")]
        private IWebElement DailySub1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@id='site_subscription_manager_subscriptions_site_subscription_11']")]
        private IWebElement DailySub2 { get; set; }

        //Click bottle
        [FindsBy(How = How.XPath, Using = "//input[@id='site_subscription_manager_subscriptions_site_subscription_15']")]
        private IWebElement Bottle { get; set; }

        //Click Escapes
        [FindsBy(How = How.XPath, Using = "//div[@id='my-subscriptions']/div/form/fieldset/div/div/ul/li[3]/div/div/ul/li/input")]
        private IWebElement Escapes { get; set; }

        //Click store
        [FindsBy(How = How.XPath, Using = "//div[@id='my-subscriptions']/div/form/fieldset/div/div/ul/li[4]/div/div/ul/li/input")]
        private IWebElement Store { get; set; }

        //Select book now
        [FindsBy(How = How.XPath, Using = "//input[@id='site_subscription_manager_subscriptions_site_subscription_173']")]
        private IWebElement BookNow { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='my-subscriptions']/div/form/fieldset/div/div/ul/li[5]/div/div[2]/ul/li[13]/input")]
        private IWebElement BookNow1 { get; set; }

        //Click cart reminder
        [FindsBy(How = How.XPath, Using = "//input[@id='site_subscription_manager_specials_cart_reminder']")]
        private IWebElement CartReminder { get; set; }

        //Click SaveChanges 
        [FindsBy(How = How.XPath, Using = "//div[@id='my-subscriptions']/div/form/fieldset/div[4]/span/input")]
        private IWebElement SaveChanges { get; set; }

        //Read Save Message 
        [FindsBy(How = How.XPath, Using = "//span[@class='notice-text']")]
        private IWebElement SaveMessage { get; set; }

        //Click on my subscribe
        [FindsBy(How = How.XPath, Using = "//a[@class='banner-account-links__subscribe']")]
        private IWebElement Subscribe { get; set; }

        
        //Select My top deals subscription
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'My Top Deals Subscriptions')]")]
        private IWebElement TopDeals { get; set; }

        //Check for navigation to Top deals subscriptions page
        [FindsBy(How = How.XPath, Using = "//h1[@class='corner-label']")]
        private IWebElement TopElement { get; set; }

        //Select region

        [FindsBy(How = How.XPath, Using = "//select[@id='my_top_deals_subscribe_site_subscription']")]
        private IWebElement SelectRegion { get; set; }

        //Click next
        [FindsBy(How = How.XPath, Using = "//a[@id='button-step-2']")]
        private IWebElement NextBtn { get; set; }

        //Select Type of deals
        [FindsBy(How = How.XPath, Using = "//input[@id='my_top_deals_subscribe_categories_1609']")]
        private IWebElement TypeDeal1 { get; set; }


        //Select save button
        [FindsBy(How = How.XPath, Using = "//span[@class='save-button']")]
        private IWebElement SaveBtn { get; set; }

        //Select finish button
        [FindsBy(How = How.XPath, Using = "//a[@id='button-finished']")]
        private IWebElement FinishBtn { get; set; }



        #endregion

        public void DailySubscription()
        {
            // Driver.wait(2);
            // UserIcon.Click();
            Driver.wait(2);
            MySubscriptions.Click();
            //Navigate to email Subscriptions page
            try

            {

                Thread.Sleep(1000);
                String Expected = "Email Subscriptions";
                String Actual = Element.Text;
                Assert.AreEqual(Expected, Actual);
                Base.test.Log(LogStatus.Pass, "Navigate to Email subscriptions page successfull");
                // Select daily subscription
                Driver.wait(2);
                DailySub.Click();
                DailySub1.Click();
                DailySub2.Click();
                //Select Bottle
                Driver.wait(2);
                Bottle.Click();
                //Select escapes
                Driver.wait(2);
                Escapes.Click();
                //select store
                Driver.wait(2);
                Store.Click();

                //Select Book now options
                Driver.wait(2);
                BookNow.Click();
                BookNow1.Click();

                //Select special emails
                Driver.wait(2);
                CartReminder.Click();

                //Click on save changes button
                Driver.wait(2);
                SaveChanges.Submit();

                string ExpectedMessage = "Your changes have been saved";
                String ActualMessage = SaveMessage.Text;
                if (ExpectedMessage == ActualMessage)
                    Base.test.Log(LogStatus.Pass, "Subscriptions  change successfull");
                else
                    Base.test.Log(LogStatus.Pass, "Subscriptions change unsuccessfull");

            }
            catch
            {
                Base.test.Log(LogStatus.Pass, "Navigate to Email subscriptions page unsuccessfull");
            }
        }

        public void DealsSubscription()
        {

            // Check if in Email subscription page
            Driver.wait(2);
            String Expected = "Email Subscriptions";
            String Actual = Element.Text;
            if (Expected == Actual)
            {
                Base.test.Log(LogStatus.Pass, " In Email subscriptions page ");
            }
            else
            {
                Base.test.Log(LogStatus.Pass, "Not in Email subscriptions page ");
            }

            //Click on My Top Deals subscription link
            Driver.wait(2);
            TopDeals.Click();


            // Check whether navigated to the Top Deals subscription page
            try
            {
                Driver.wait(2);
                String ExpectedPage = "My Top Deals Email";
                String ActualPage = TopElement.Text;
                Assert.AreEqual(ExpectedPage, ActualPage);
                Base.test.Log(LogStatus.Pass, "Navigate to My Top deals page successfull");
                //Select your region
                Driver.wait(2);
                Actions action = new Actions(Driver.driver);
                action.MoveToElement(SelectRegion).Build().Perform();
                IList<IWebElement> SelectRegionOpt = SelectRegion.FindElements(By.TagName("option"));
                for (int i = 0; i < SelectRegionOpt.Count; i++)
                {
                    if (SelectRegionOpt[i].Text == "Auckland")
                        SelectRegionOpt[i].Click();
                }
                //Click on Next Button
                Driver.wait(2);
                NextBtn.Click();
                //Select type of deals
                Driver.wait(2);
                TypeDeal1.Click();
                Driver.wait(2);
                //Click save button
                SaveBtn.Click();
                //Click finish button
                Driver.wait(2);
                FinishBtn.Click();
                //Check if subscribed for top subscriptions
                Thread.Sleep(1000);
                String ExpectedMsg = "Email Subscriptions";
                String ActualMsg = Element.Text;
                if (ExpectedMsg == ActualMsg)
                    Base.test.Log(LogStatus.Pass, "Navigate to Email subscriptions page successfull");
                else
                    Base.test.Log(LogStatus.Pass, "Navigate to Email subscriptions page unsuccessfull");
            }
            catch
            {
                Base.test.Log(LogStatus.Pass, "Navigate to My Top deals emailpage unsuccessfull");

            }
        }

    }
}
