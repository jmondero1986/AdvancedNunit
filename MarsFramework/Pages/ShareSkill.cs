using MarsFramework.Global;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;

namespace MarsFramework.Pages
{
    internal class ShareSkill
    {
        public ShareSkill()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Click on ShareSkill Button
        [FindsBy(How = How.LinkText, Using = "Share Skill")]
        private IWebElement ShareSkillButton { get; set; }

        //Enter the Title in textbox
        [FindsBy(How = How.Name, Using = "title")]
        private IWebElement Title { get; set; }

        //Enter the Description in textbox
        [FindsBy(How = How.Name, Using = "description")]
        private IWebElement Description { get; set; }

        //Click on Category Dropdown
        [FindsBy(How = How.Name, Using = "categoryId")]
        private IWebElement CategoryDropDown { get; set; }

        //Click on SubCategory Dropdown
        [FindsBy(How = How.Name, Using = "subcategoryId")]
        private IWebElement SubCategoryDropDown { get; set; }

        //Enter Tag names in textbox
        [FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[contains(@class,'ui container')]/div[contains(@class,'listing')]/form[contains(@class,'ui form')]/div[contains(@class,'tooltip-target ui grid')]/div[contains(@class,'twelve wide column')]/div[contains(@class,'')]/div[contains(@class,'ReactTags__tags')]/div[contains(@class,'ReactTags__selected')]/div[contains(@class,'ReactTags__tagInput')]/input[1]")]
        private IWebElement Tags { get; set; }

        //Select the Service type (HourlyBasis)
        [FindsBy(How = How.XPath, Using = "//div[5]//div[2]//div[1]//div[1]//div[1]//input[1]")]
        private IWebElement HourlyBasisService { get; set; }

        //Select the Service type (One-off Service)
        [FindsBy(How = How.XPath, Using = "//div[5]//div[2]//div[1]//div[2]//div[1]//input[1]")]
        private IWebElement OneOffService { get; set; }


        //Select the Location Type (On-Site)
        [FindsBy(How = How.XPath, Using = "//div[6]//div[2]//div[1]//div[1]//div[1]//input[1]")]
        private IWebElement OnSiteLocationType { get; set; }

        //Select the Location Type (Online)
        [FindsBy(How = How.XPath, Using = "//div[6]//div[2]//div[1]//div[2]//div[1]//input[1]")]
        private IWebElement OnlineLocationType { get; set; }

        //Click on Start Date dropdown
        [FindsBy(How = How.Name, Using = "startDate")]
        private IWebElement StartDateDropDown { get; set; }

        //Click on End Date dropdown
        [FindsBy(How = How.Name, Using = "endDate")]
        private IWebElement EndDateDropDown { get; set; }

        //Day Check Box
        [FindsBy(How = How.Name, Using = "Available")]
        private IList<IWebElement> AvailableCheckBoxes { get; set; }

        //Start Time
        [FindsBy(How = How.Name, Using = "StartTime")]
        private IList<IWebElement> StartTimes { get; set; }

        //End Time
        [FindsBy(How = How.Name, Using = "EndTime")]
        private IList<IWebElement> EndTimes { get; set; }

        
        //Click on Skill Trade (SkillExhange)
        [FindsBy(How = How.XPath, Using = "//div[8]//div[2]//div[1]//div[1]//div[1]//input[1]")]
        private IWebElement SkillExchangeBtn { get; set; }

        //Enter Skill Exchange
        [FindsBy(How = How.XPath, Using = "//div[@class='form-wrapper']//input[@placeholder='Add new tag']")]
        private IWebElement SkillExchange { get; set; }

        //Click on Skill Trade (Credit)
        [FindsBy(How = How.XPath, Using = "//div[8]//div[2]//div[1]//div[2]//div[1]//input[1]")]
        private IWebElement CreditOptionBtn { get; set; }

        //Enter the amount for Credit
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Amount']")]
        private IWebElement CreditAmount { get; set; }

        //Click on Active/Hidden option
        [FindsBy(How = How.XPath, Using = "//div[10]//div[2]//div[1]//div[1]//div[1]//input[1]")]
        private IWebElement ActiveOption { get; set; }


        [FindsBy(How = How.XPath, Using = "//div[10]//div[2]//div[1]//div[2]//div[1]//input[1]")]
        private IWebElement HiddenOption { get; set; }


        //Click on Save button
        [FindsBy(How = How.XPath, Using = "//input[@value='Save']")]
        private IWebElement Save { get; set; }



        internal void EditShareSkill()
        {

            //Enabling the Share Skill Button
            ShareSkillButton.Click();

            //Navigating to the Share Skill Page
            GlobalDefinitions.driver.Navigate().GoToUrl("http://localhost:5000/Home/ServiceListing");

            //Populate the Excel Sheet from ShareSkillDetails sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkillDetails");
            GlobalDefinitions.wait(5);

            //Reading the Excel file-Title
            Title.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Title"));
            GlobalDefinitions.wait(5);

            //Reading the Excel file-Description
            Description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Description"));
            GlobalDefinitions.wait(5);

            //Selecting the Category Dropdown
            SelectElement categoryDropdown = new SelectElement(CategoryDropDown);

            //Initializing the Expected Category for Assertion/ Reading the Excel File-Category
            var expectedCategory =GlobalDefinitions.ExcelLib.ReadData(2, "Category");
            categoryDropdown.SelectByText(expectedCategory);
            GlobalDefinitions.wait(5);

            //Selecting the Subcategory Dropdown
            SelectElement subCategorydropdown = new SelectElement(SubCategoryDropDown);

            //Reading the excel file - Subcategory
            subCategorydropdown.SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "Select Subcategory"));
            GlobalDefinitions.wait(5);


            //Clearing the existing tags before sending new Tags/Reading the Excel File - Tags
            Tags.Clear();
            Tags.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Tags"));
            Tags.SendKeys(Environment.NewLine);

            //Clicking the Service Type radio button
            HourlyBasisService.Click();
            OneOffService.Click();

            //Clicking the Location Type radio button
            OnSiteLocationType.Click();
            OnlineLocationType.Click();

            //Clicking the Skill Trade radio button (Skill-exchange)
            SkillExchangeBtn.Click();
            GlobalDefinitions.wait(5);

            //Reading the Excel File - Skill Exchange Tags
            SkillExchange.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Skill Exchange"));

            //Clicking the Skill Trade radio button (Credit)
            CreditOptionBtn.Click();
            GlobalDefinitions.wait(5);

            //Reading the Excel File - Credit Charge
            CreditAmount.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Credit"));

            //Clicking the Active radio button
            ActiveOption.Click();
            HiddenOption.Click();
            GlobalDefinitions.wait(10);


            //Populate the Excel Sheet from Time Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Time");

            //Reading the excel file for StartDate
            StartDateDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Start Date"));

            //Reading the excel file for EndDate
            EndDateDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "End Date"));

           
            //Using a for loop for reading the excel file including the days[Checkboxes]
            for (var i = 2; i <= 8; i++)
            {
                //Reading the days checkbox element starting on the 2nd row [i-2]
                AvailableCheckBoxes[i - 2].Click();

                
                //Readtime = converting the string format to Date time format (see GlobalDefinitions changes)
                var excelStartTime = GlobalDefinitions.ExcelLib.ReadTime(i, "Start Time");

                //passing the value of excelStartTime as ex: (0700am) since the system is not accepting spaces
                var startTime = excelStartTime.ToString("hhmmtt");

                
                //Readtime = converting the string format to Date time format (see GlobalDefinitions changes)
                var excelEndTime = GlobalDefinitions.ExcelLib.ReadTime(i, "End Time");
                var endTime = excelEndTime.ToString("hhmmtt");

                //Reading data from excel file starting on the 2nd row
                StartTimes[i - 2].SendKeys(startTime);
                EndTimes[i - 2].SendKeys(endTime);
            }

            //Saving Skills         
            Save.Click();
            GlobalDefinitions.wait(20);

            //Assertion if the actual category is the same as the expected category
            var actualCategory = GlobalDefinitions.driver.FindElement(By.XPath($"//td[normalize-space()='{expectedCategory}']")).Text;
            Assert.AreEqual(actualCategory, expectedCategory);
            
        }

       


    }
}
