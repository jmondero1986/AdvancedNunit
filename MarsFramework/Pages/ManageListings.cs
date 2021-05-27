using MarsFramework.Global;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Threading;
using System.Collections.Generic;

namespace MarsFramework.Pages
{
    internal class ManageListings
    {
        public ManageListings()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Click on Manage Listings Link
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Manage Listings']")]
        private IWebElement manageListingsLink { get; set; }

        //View the listing
        [FindsBy(How = How.XPath, Using = "(//i[@class='eye icon'])[1]")]
        private IWebElement viewIcon { get; set; }

        

        //Edit the listing
        [FindsBy(How = How.XPath, Using = "//i[@class='outline write icon']")]
        private IWebElement editIcon { get; set; }

        //Delete the listing
        [FindsBy(How = How.XPath, Using = "//i[@class='remove icon']")]
        private IWebElement deleteIcon { get; set; }

        //Click on Yes/No for Delete Confirmation
        [FindsBy(How = How.XPath, Using = "//button[normalize-space()='Yes']")]
        private IWebElement clickActionsButton { get; set; }

        
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

        //Deleting [x] on Tags
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='×']")]
        private IWebElement deleteTags { get; set; }

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

        //Click on Save button
        [FindsBy(How = How.XPath, Using = "//input[@value='Save']")]
        private IWebElement Save { get; set; }

        internal void Listings()
        {
            
            //Enabling the Manage listing link
            manageListingsLink.Click();

            //Navigating to the Listing management page
            GlobalDefinitions.driver.Navigate().GoToUrl("http://localhost:5000/Home/ListingManagement");
            GlobalDefinitions.wait(10);
            
            //Enabling the Edit Icon
            editIcon.Click();

            //Navigating to the Service Listing page for updates
            GlobalDefinitions.driver.Navigate().GoToUrl("http://localhost:5000/Home/ServiceListing/?id=6098c9b920b935000188c7e5");

            //Populate the Excel Sheet for Manage Listings
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ManageListings");
            GlobalDefinitions.wait(10);


            //Clearing the existing title before inputting new Title
            Title.Clear();
            var expectedTitle = GlobalDefinitions.ExcelLib.ReadData(2, "Title");
            GlobalDefinitions.wait(10);

            //Clearing the existing title before inputting new Description
            Description.Clear();
            Description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Description"));
            GlobalDefinitions.wait(10);

            //Selecting the Category Dropdown
            //SelectElement categoryDropdown = new SelectElement(CategoryDropDown);

            //Initializing the Expected Category for Assertion/ Reading the Excel File-Category
            //var expectedCategory = GlobalDefinitions.ExcelLib.ReadData(2, "Category");
            //categoryDropdown.SelectByText(expectedCategory);
            //GlobalDefinitions.wait(5);



            //Selecting the Category Dropdown
            SelectElement Categorydropdown = new SelectElement(CategoryDropDown);

            //Reading the excel file - Category
            Categorydropdown.SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "Category"));
            GlobalDefinitions.wait(5);


            //Selecting the Subcategory Dropdown
            SelectElement subCategorydropdown = new SelectElement(SubCategoryDropDown);

            //Reading the excel file - Subcategory
            subCategorydropdown.SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "Select Subcategory"));
            GlobalDefinitions.wait(5);


            //Click the delete[x] from the tags and clearing the existing tags before inputting a new one
            deleteTags.Click();
            Tags.Clear();

            //Reading the Excel file- Tags
            Tags.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Tags"));
            //Enabling the ENTER mode to accept the new tags
            Tags.SendKeys(Environment.NewLine);


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

            //Saving the updated skills
            Save.Click();
            GlobalDefinitions.wait(20);

            //Assertion if the actual category is the same as the expected category
            //var actualCategory = GlobalDefinitions.driver.FindElement(By.XPath($"//td[normalize-space()='{expectedCategory}']")).Text;
            //Assert.AreEqual(actualCategory, expectedCategory);
            //GlobalDefinitions.wait(10);


            //Enabling the delete Icon in the Manage Listing feature
            deleteIcon.Click();

            //Enabling the Yes for confirmation
            clickActionsButton.Click();


            //assertion if the deleted skills is existing or not after the confirmation
             
            var isElementExist = true;
            try
            {
                GlobalDefinitions.driver.FindElement(By.XPath($"//td[normalize-space()='{expectedTitle}']"));
            }
            catch (NoSuchElementException)
            {
                isElementExist = false;
            }

            Assert.IsFalse(isElementExist);

            Thread.Sleep(1000);

        }

        
    }
}
