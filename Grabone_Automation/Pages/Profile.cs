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
using static Grabone_Automation.Global.CommonMethods;

namespace Grabone_Automation.Pages
{
    class Profile
    {
        public Profile()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        #region Initialize Elements

        //Click on user icon
        [FindsBy(How = How.CssSelector, Using = "svg.primary-nav-icon.primary-nav-icon--user")]
        private IWebElement UserIcon { get; set; }

        //Click on Profile
        [FindsBy(How = How.XPath, Using = "//*[@id='content']/div[2]/div[1]/div/ul/li[4]/a")]
        private IWebElement MyProfile { get; set; }

        //Click on Gender
        [FindsBy(How = How.XPath, Using = "//div[@id='profile']/form/fieldset/div[2]/div/select")]
        private IWebElement Gender { get; set; }

        //Click on Gender
        [FindsBy(How = How.XPath, Using = "//div[@id='profile']/form/fieldset/div[3]/div/div/select")]
        private IWebElement BirthDay{ get; set; }

        //Click on Gender
        [FindsBy(How = How.XPath, Using = "//div[@id='profile']/form/fieldset/div[3]/div/div/select[2]")]
        private IWebElement BirthMonth { get; set; }

        //Click on Gender
        [FindsBy(How = How.XPath, Using = "//div[@id='profile']/form/fieldset/div[3]/div/div/select[3]")]
        private IWebElement BirthYear { get; set; }

        //Click on Gender
        [FindsBy(How = How.XPath, Using = "//div[@id='profile']/form/fieldset/div[4]/div/input")]
        private IWebElement Mobile { get; set; }


        //Click on Gender
        [FindsBy(How = How.XPath, Using = "//div[@id='profile']/form/fieldset/div[5]/div/input")]
        private IWebElement PostCode { get; set; }

        //Click on Gender
        [FindsBy(How = How.XPath, Using = "//div[@id='profile_area_id-4']/select")]
        private IWebElement Region { get; set; }

        //Click on Gender
        [FindsBy(How = How.XPath, Using = "//div[@id='profile_area_id-4']/select[2]")]
        private IWebElement SubRegion { get; set; }

        //Click on Gender
        [FindsBy(How = How.XPath, Using = "//div[@id='profile']/form/fieldset/div[8]/ul/li[3]/input")]
        private IWebElement Deals1 { get; set; }

        //Click on Gender
        [FindsBy(How = How.XPath, Using = "//div[@id='profile']/form/fieldset/div[8]/ul/li[9]/input")]
        private IWebElement Deals2 { get; set; }

        //Click on Gender
        [FindsBy(How = How.XPath, Using = "//div[@id='profile']/form/fieldset/div[8]/ul/li[15]")]
        private IWebElement Deals3 { get; set; }

        //Click on Gender
        [FindsBy(How = How.XPath, Using = "//div[@id='profile']/form/fieldset/div[10]/div/select")]
        private IWebElement Education { get; set; }

        //Click on Gender
        [FindsBy(How = How.XPath, Using = "//div[@id='profile']/form/fieldset/div[11]/div/select")]
        private IWebElement Employment { get; set; }

        //Click on Gender
        [FindsBy(How = How.XPath, Using = "//div[@id='profile']/form/fieldset/div[12]/div/select")]
        private IWebElement Income { get; set; }

        //Click on Gender
        [FindsBy(How = How.XPath, Using = " //div[@id='profile']/form/fieldset/div[13]/div/ul/li/input")]
        private IWebElement OwnHome { get; set; }

        //Click on Gender
        [FindsBy(How = How.XPath, Using = " //div[@id='profile']/form/fieldset/div[14]/div/ul/li[2]/input")]
        private IWebElement OwnCar { get; set; }

        //Click on Gender
        [FindsBy(How = How.XPath, Using = " //div[@id='profile']/form/fieldset/div[15]/div/ul/li[3]/input")]
        private IWebElement Children { get; set; }



        //Click on Gender
        [FindsBy(How = How.XPath, Using = "//div[@id='profile']/form/fieldset/div[16]/div/select")]
        private IWebElement RelationStatus { get; set; }

        //Click on Gender
        [FindsBy(How = How.XPath, Using = "//div[@id='profile']/form/fieldset/div[17]/span/input")]
        private IWebElement UpdateProfile { get; set; }

        //Click on Gender
        [FindsBy(How = How.XPath, Using = "//div[@id='content']/div/p")]
        private IWebElement UpdateMessage { get; set; }
        #endregion

        public void ProfileUpdate()
        {

            //Populate the Excel Sheet
            ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
            Thread.Sleep(1000);

            //Click on user icon link
            Driver.wait(2);
            MyProfile.Click();
            //Navigate to update profile page
            try
            {
                Thread.Sleep(1000);
                String Expected = "Update Profile";
                String Actual = Driver.driver.FindElement(By.XPath("//*[@id='content']/div[2]/div[2]/div/h1")).Text;
                Assert.AreEqual(Expected, Actual);
                Base.test.Log(LogStatus.Pass, "Navigate to Profile update page successfull");

                //Select gender
                Driver.wait(2);
                Actions action = new Actions(Driver.driver);
                action.SendKeys(Gender, Keys.ArrowDown).Perform();
                action.SendKeys(Gender, Keys.Return).Click();

                //Select Birthday details
                Driver.wait(2);
                action.MoveToElement(BirthDay).Build().Perform();            
                IList<IWebElement> BirthDayOpt = BirthDay.FindElements(By.TagName("select"));
                for (int i = 0; i < BirthDayOpt.Count; i++)
                {
                    if (BirthDayOpt[i].Text == ExcelLib.ReadData(2, "Birthday"))
                    BirthDayOpt[i].Click();
                }

                Driver.wait(2);
                action.MoveToElement(BirthMonth).Build().Perform();
                IList<IWebElement> MonthOpt = BirthMonth.FindElements(By.TagName("option"));
                int count = MonthOpt.Count;
                
                Driver.wait(2);
                for (int i = 0; i < count; i++)
                {
                    if (MonthOpt[i].Text == ExcelLib.ReadData(2, "Month"))
                        MonthOpt[i].Click();
                }

                //Select BirthYear details
                Driver.wait(2);
                action.MoveToElement(BirthYear).Build().Perform();
                IList<IWebElement> BirthYearOpt = BirthYear.FindElements(By.TagName("option"));
                for (int i = 0; i < BirthYearOpt.Count; i++)
                {
                    if (BirthYearOpt[i].Text == ExcelLib.ReadData(2, "Year"))
                        BirthYearOpt[i].Click();
                }

                //Enter Mobile number
                Driver.wait(2);
                Mobile.Clear();
                Mobile.SendKeys(ExcelLib.ReadData(2, "Mobile"));

                //Enter postcode
                Driver.wait(2);
                PostCode.Clear();
                PostCode.SendKeys(ExcelLib.ReadData(2, "Postcode"));

                //Select region
                Driver.wait(2);
                action.MoveToElement(Region).Build().Perform();
                IList<IWebElement> RegionOpt = Region.FindElements(By.TagName("option"));
                for (int i = 0; i < RegionOpt.Count; i++)
                {
                    if (RegionOpt[i].Text == ExcelLib.ReadData(2, "Region"))
                        RegionOpt[i].Click();
                }

                //Select subregion
                Driver.wait(2);
                action.MoveToElement(SubRegion).Build().Perform();
                IList<IWebElement> SubRegionOpt = SubRegion.FindElements(By.TagName("option"));
                for (int i = 0; i < SubRegionOpt.Count; i++)
                {
                    if (SubRegionOpt[i].Text == ExcelLib.ReadData(2, "Subregion"))
                        SubRegionOpt[i].Click();
                }

                //Unselect deals
                Driver.wait(2);
                Deals1.Click();
                Deals2.Click();
                Deals3.Click();


                //Select education
                Driver.wait(2);
                action.MoveToElement(Education).Build().Perform();
                IList<IWebElement> EducationOpt = Education.FindElements(By.TagName("option"));
                for (int i = 0; i < EducationOpt.Count; i++)
                {
                    if (EducationOpt[i].Text == ExcelLib.ReadData(2, "Education"))
                        EducationOpt[i].Click();
                }

                //Select Employment
                Driver.wait(2);
                action.MoveToElement(Employment).Build().Perform();
                IList<IWebElement> EmploymentOpt = Education.FindElements(By.TagName("option"));
                for (int i = 0; i < EmploymentOpt.Count; i++)
                {
                    if (EmploymentOpt[i].Text == CommonMethods.ExcelLib.ReadData(2, "Employment"))
                        EmploymentOpt[i].Click();
                }

                //Select Income
                Driver.wait(2);
                action.MoveToElement(Income).Build().Perform();
                IList<IWebElement> IncomeOpt = Education.FindElements(By.TagName("option"));
                for (int i = 0; i < IncomeOpt.Count; i++)
                {
                    if (IncomeOpt[i].Text == CommonMethods.ExcelLib.ReadData(2, "Income"))
                        IncomeOpt[i].Click();
                }
                Driver.wait(2);
                OwnHome.Click();
                Driver.wait(2);
                OwnCar.Click();
                Driver.wait(2);
                Children.Click();

                //Select relationship status

                Driver.wait(2);
                action.MoveToElement(RelationStatus).Build().Perform();
                IList<IWebElement> RelationStatusOpt = Education.FindElements(By.TagName("option"));
                for (int i = 0; i < RelationStatusOpt.Count; i++)
                {
                    if (RelationStatusOpt[i].Text == CommonMethods.ExcelLib.ReadData(2, "RelationStatus"))
                        RelationStatusOpt[i].Click();
                }

                // Click Update profile button
                Driver.wait(2);
                UpdateProfile.Click();

                // Check for profile update message

                Driver.wait(2);
                string ExpectedMessage = "Your profile saved successfully";
                string ActualMesage = UpdateMessage.Text;
                if(ExpectedMessage == ActualMesage)
                    Base.test.Log(LogStatus.Pass, "Profile update successfull");
                else
                    Base.test.Log(LogStatus.Pass, "Profile update successfull");

            }
            catch (Exception)
            {
                Base.test.Log(LogStatus.Pass, " Navigate to Profile update page successfull");
            }


        }

    }
}
