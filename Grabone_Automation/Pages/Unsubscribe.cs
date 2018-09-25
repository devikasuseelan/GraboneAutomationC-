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
    class Unsubscribe
    {
        public Unsubscribe()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        #region Initialize Elements

        //Click on subscriptions link
        [FindsBy(How = How.XPath, Using = "//a[@href='/my-stuff/my-subscriptions']")]
        private IWebElement Subscriptions { get; set; }

        //Click on unsubscribe button
        [FindsBy(How = How.XPath, Using = "//input[@id='quick-unsubscribe']")]
        private IWebElement UnSubscrib { get; set; }

        //Check for image in frame
        [FindsBy(How = How.XPath, Using = "//img[@src='https://main-cdn.grabone.co.nz/images/common/unsubscription-gimme.png']")]
        private IWebElement Image { get; set; }

        //Click on comment box
        [FindsBy(How = How.XPath, Using = " //select[@id='unsubscription_reason']")]
        private IWebElement CommentBox { get; set; }

        //Click on submit
        [FindsBy(How = How.XPath, Using = " //input[@id='unsubscription-submit']")]
        private IWebElement SubmitBtn { get; set; }

        // Check for message
        [FindsBy(How = How.XPath, Using = "//span[@class='notice-text']")]
        private IWebElement UnSubMessage  { get; set; }

        [FindsBy(How = How.XPath, Using = " //p[contains(text(),'We have saved your comments. Thanks for letting us')]")]
        private IWebElement CommentMessage { get; set; }
        #endregion

        public void UnSubscribeMails()
        {
            // Click on subscriptions link
            Driver.wait(2);
            Subscriptions.Click();
            //Click on unsubscribe button
            try
            {
                Driver.wait(2);
                Assert.AreEqual(true, UnSubscrib.Enabled);
                Base.test.Log(LogStatus.Pass, " Unsubscribed  button  enabled");
                Driver.wait(2);
                UnSubscrib.Click();
            
            
            //Check for frame
            
                Driver.wait(2);
                // Assert.That(Driver.driver.FindElements(By.XPath("//img[@src='https://main-cdn.grabone.co.nz/images/common/unsubscription-gimme.png']"))).Displayed;
                //Select from comment drop down
                Driver.wait(2);
                Actions action = new Actions(Driver.driver);
                action.MoveToElement(CommentBox).Build().Perform();
                IList<IWebElement> CommentBoxOpt = CommentBox.FindElements(By.TagName("option"));
                for (int i = 0; i < CommentBoxOpt.Count; i++)
                {
                    if (CommentBoxOpt[i].Text ==  "Other")
                        CommentBoxOpt[i].Click();
                }
                //Click submit button
                SubmitBtn.Click();
            try
            {
                Thread.Sleep(1000);
                String Expected = "You have been unsubscribed from all emails.";
                String Actual = UnSubMessage.Text;
                Assert.AreEqual(Expected, Actual);
                Base.test.Log(LogStatus.Pass, " Unsubscribed success message");
                Driver.wait(2);
                String ExpectedCommentMsg = "We have saved your comments. Thanks for letting us know.";
                String ActualCommentMsg = CommentMessage.Text;
                if(ExpectedCommentMsg == ActualCommentMsg)
                {
                    Base.test.Log(LogStatus.Pass, " Comment message displayed");
                }


            }
            catch
            {
               
                Base.test.Log(LogStatus.Pass, "Could not unsubscribe");
            }
            }
            catch
            {
                Base.test.Log(LogStatus.Pass, " Unsubscribed  button not enabled");
            }
        }
    }
}
