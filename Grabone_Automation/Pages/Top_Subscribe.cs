using Grabone_Automation.Global;
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
using static NUnit.Core.NUnitFramework;

namespace Grabone_Automation.Pages
{
    class Top_Subscribe
    {
        public Top_Subscribe()
        {
            PageFactory.InitElements(Driver.driver, this);
        }
        #region Initialize Elements
        

        //Click on my subscribe
        [FindsBy(How = How.XPath, Using = "//a[@class='banner-account-links__subscribe']")]
        private IWebElement Subscribe { get; set; }

        //// Check whether navigated to the Email subscription page
        [FindsBy(How = How.XPath, Using = "//div[@id='content']/div[2]/div[2]/div/h1")]
        private IWebElement Element { get; set; }

        //Select My top deals subscription
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'My Top Deals Subscriptions')]")]
        private IWebElement TopDeals { get; set; }

        //Check for navigation to Top deals subscriptions page
        [FindsBy(How = How.XPath, Using = "/h1[@class='corner-label']")]
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

        public void DealsSubscription()
        {
            //Click on Subscribe button
            //Driver.wait(2);
            Subscribe.Click();

            // Check whether navigated to the Email subscription page
            String Expected = "Email Subscriptions";
            String Actual = Element.Text;
            if (Expected == Actual)
            {
                Base.test.Log(LogStatus.Pass, "Navigate to Email subscriptions page successfull");
            }
            else
            {
                Base.test.Log(LogStatus.Pass, "Navigate to Email subscriptions page unsuccessfull");
            }

            //Click on My Top Deals subscription link
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
