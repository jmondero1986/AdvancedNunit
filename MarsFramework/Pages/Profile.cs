using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;

namespace MarsFramework
{
    internal class Profile
    {

        public Profile()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
            
        }
        //***TIME***//

        #region  Initialize Web Elements 
        //Click on Availability Time Edit button
        [FindsBy(How = How.CssSelector, Using = "body > div:nth-child(1) > div:nth-child(1) > section:nth-child(3) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(2) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(3) > div:nth-child(1) > div:nth-child(2) > div:nth-child(2) > span:nth-child(1) > i:nth-child(1)")]
        private IWebElement AvailabilityTimeEditButton { get; set; }

        //Click on Availability Time dropdown
        [FindsBy(How = How.CssSelector, Using = "select[name='availabiltyType']")]
        private IWebElement AvailabilityTime { get; set; }

        //Click on Availability Time option
        [FindsBy(How = How.XPath, Using = "//option[@value='0']")]
        private IWebElement AvailabilityTimeOpt { get; set; }

        //***HOURS***//

        //Click on Edit hours Edit button
        [FindsBy(How = How.CssSelector, Using = "body > div:nth-child(1) > div:nth-child(1) > section:nth-child(3) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(2) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(3) > div:nth-child(1) > div:nth-child(3) > div:nth-child(2) > span:nth-child(1) > i:nth-child(1)")]
        private IWebElement HoursEditButton { get; set; }

        //Click on Hour dropdown
        [FindsBy(How = How.CssSelector, Using = "select[name='availabiltyHour']")]
        private IWebElement Hours { get; set; }


        //***SALARY***//

        //Click on Edit Earn Target/Salary Edit button
        [FindsBy(How = How.CssSelector, Using = "body > div:nth-child(1) > div:nth-child(1) > section:nth-child(3) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(2) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(3) > div:nth-child(1) > div:nth-child(4) > div:nth-child(2) > span:nth-child(1) > i:nth-child(1)")]
        private IWebElement SalaryEditButton { get; set; }

        //Click on salary Dropdown
        [FindsBy(How = How.XPath, Using = "//select[@name='availabiltyTarget']")]
        private IWebElement Salary { get; set; }

        ////***LOCATION***//


        //Click on Location
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[2]/div")]
        private IWebElement Location { get; set; }

        //Choose Location
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[2]/div/div[2]")]
        private IWebElement LocationOpt { get; set; }

        //Click on City
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[3]/div")]
        private IWebElement City { get; set; }

        //Choose City
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[3]/div/div[2]")]
        private IWebElement CityOpt { get; set; }

        //***lANGUAGE***//


        //Click on Language Tab
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Languages']")]
        private IWebElement LanguageTab { get; set; }

        //Click on Add new to add new Language
        [FindsBy(How = How.XPath, Using = "//div[@class='ui bottom attached tab segment active tooltip-target']//div[@class='ui teal button '][normalize-space()='Add New']")]
        private IWebElement AddNewLangBtn { get; set; }

        //Enter the Language on text box
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Add Language']")]
        private IWebElement AddLangText { get; set; }

        //Choose from Language Level
        [FindsBy(How = How.XPath, Using = "//select[@name='level']")]
        private IWebElement ChooseLangOpt { get; set; }

        //Add Language
        [FindsBy(How = How.XPath, Using = "//input[@value='Add']")]
        private IWebElement AddLang { get; set; }

        //Cancel adding new Language
        [FindsBy(How = How.XPath, Using = "//input[@value='Cancel']")]
        private IWebElement CancelLang { get; set; }

        //Update Language
        [FindsBy(How = How.CssSelector, Using = "body > div:nth-child(1) > div:nth-child(1) > section:nth-child(3) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(3) > form:nth-child(2) > div:nth-child(2) > div:nth-child(1) > div:nth-child(2) > div:nth-child(1) > table:nth-child(1) > tbody:nth-child(2) > tr:nth-child(1) > td:nth-child(3) > span:nth-child(1) > i:nth-child(1)")]
        private IWebElement UpdateLangIcon { get; set; }

        //Click Update Button
        [FindsBy(How = How.XPath, Using = "//input[@value='Update']")]
        private IWebElement UpdateLangBtn { get; set; }

        //Click Cancel Update Button
        [FindsBy(How = How.XPath, Using = "//input[@value='Cancel']")]
        private IWebElement UpdateCancelBtn { get; set; }


        //Delete adding new Language
        [FindsBy(How = How.CssSelector, Using = "body > div:nth-child(1) > div:nth-child(1) > section:nth-child(3) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(3) > form:nth-child(2) > div:nth-child(2) > div:nth-child(1) > div:nth-child(2) > div:nth-child(1) > table:nth-child(1) > tbody:nth-child(2) > tr:nth-child(1) > td:nth-child(3) > span:nth-child(2) > i:nth-child(1)")]
        private IWebElement DeleteLangIcon { get; set; }



        //***SKILLS***//


        //Click on Skill Tab
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Skills']")]
        private IWebElement SkillTab { get; set; }


        //Click on Add new to add new skill
        [FindsBy(How = How.XPath, Using = "//div[@class='ui teal button']")]
        private IWebElement AddNewSkillBtn { get; set; }

        //Enter the Skill on text box
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Add Skill']")]
        private IWebElement AddSkillText { get; set; }

        //Choose the skill level option
        [FindsBy(How = How.XPath, Using = "//select[@name='level']")]
        private IWebElement ChooseSkilllevel { get; set; }

        //Add Skill
        [FindsBy(How = How.XPath, Using = "//input[@value='Add']")]
        private IWebElement AddSkill { get; set; }

        //Cancel adding new Skill
        [FindsBy(How = How.XPath, Using = "//input[@value='Cancel']")]
        private IWebElement CancelSkill { get; set; }

        //Click on Update Skill Icon
        [FindsBy(How = How.CssSelector, Using = "tbody tr td:nth-child(3) span:nth-child(1) i:nth-child(1)")]
        private IWebElement UpdateSkillIcon { get; set; }

        //Click on Update Skill Button
        [FindsBy(How = How.CssSelector, Using = "input[value='Update']")]
        private IWebElement UpdateSkillBtn { get; set; }

        //Click on Cancel Skill Button
        [FindsBy(How = How.CssSelector, Using = "input[value='Cancel']")]
        private IWebElement CancelUpdateSkillBtn { get; set; }

        //Click on Delete Skill Icon
        [FindsBy(How = How.CssSelector, Using = "tbody tr td:nth-child(3) span:nth-child(2) i:nth-child(1)")]
        private IWebElement DeleteSkillIcon{ get; set; }

        //***EDUCATION***//


        //Click on Education Tab
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Education']")]
        private IWebElement EducationTab { get; set; }

        //Click on Add new to Educaiton
        [FindsBy(How = How.XPath, Using = "//div[@class='ui bottom attached tab segment tooltip-target active']//div[@class='ui teal button '][normalize-space()='Add New']")]
        private IWebElement AddNewEducation { get; set; }

        //Enter university in the text box
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='College/University Name']")]
        private IWebElement EnterUniversity { get; set; }

        //Choose the country
        [FindsBy(How = How.XPath, Using = "//select[@name='country']")]
        private IWebElement ChooseCountry { get; set; }

        //Click on Title dropdown
        [FindsBy(How = How.XPath, Using = "//select[@name='title']")]
        private IWebElement ChooseTitle { get; set; }

        //Degree
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Degree']")]
        private IWebElement Degree { get; set; }

        //Year of graduation
        [FindsBy(How = How.XPath, Using = "//select[@name='yearOfGraduation']")]
        private IWebElement DegreeYear { get; set; }

        //Click on Add to add new education
        [FindsBy(How = How.XPath, Using = "//input[@value='Add']")]
        private IWebElement AddEdu { get; set; }

        //Click on Cancel to cancel adding the education
        [FindsBy(How = How.XPath, Using = "//input[@value='Cancel']")]
        private IWebElement CancelEdu { get; set; }

        //Click on Update Education Icon
        [FindsBy(How = How.CssSelector, Using = "td[class='right aligned'] i[class='outline write icon']")]
        private IWebElement UpdatedEduIcon { get; set; }

        //Click on Update Button for Education
        [FindsBy(How = How.CssSelector, Using = "input[value='Update']")]
        private IWebElement UpdatedEduBtn { get; set; }

        //Click on Cancel Button for Updating Education
        [FindsBy(How = How.CssSelector, Using = "input[value='Cancel']")]
        private IWebElement CancelUpdateEduBtn { get; set; }

        //Click on Delete Icon for Education
        [FindsBy(How = How.CssSelector, Using = ".remove.icon")]
        private IWebElement DeleteEduIcon { get; set; }



        //***CERTIFICATION***//


        //Click on Certification Tab
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Certifications']")]
        private IWebElement CertificationTab { get; set; }

        //Add new Certificate
        [FindsBy(How = How.XPath, Using = "//div[@class='ui bottom attached tab segment tooltip-target active']//div[@class='ui teal button '][normalize-space()='Add New']")]
        private IWebElement AddNewCerti { get; set; }

        //Enter Certification Name
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Certificate or Award']")]
        private IWebElement EnterCerti { get; set; }

        //Certified from 
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Certified From (e.g. Adobe)']")]
        private IWebElement CertiFrom { get; set; }

        //Year
        [FindsBy(How = How.XPath, Using = "//select[@name='certificationYear']")]
        private IWebElement CertiYear { get; set; }

        //Add button for Certification
        [FindsBy(How = How.XPath, Using = "//input[@value='Add']")]
        private IWebElement AddCertiBtn { get; set; }

        //Cancel button for Certification
        [FindsBy(How = How.XPath, Using = "//input[@value='Cancel']")]
        private IWebElement CancelCertiBtn { get; set; }

        //Click update icon for Certification
        [FindsBy(How = How.CssSelector, Using = "td[class='right aligned'] i[class='outline write icon']")]
        private IWebElement UpdateCertiIcon { get; set; }

        //Click update Button for Certification
        [FindsBy(How = How.CssSelector, Using = "input[value='Update']")]
        private IWebElement UpdateCertiBtn { get; set; }

        //Click Cancel Button for Updating Certification    
        [FindsBy(How = How.CssSelector, Using = "input[value='Cancel']")]
        private IWebElement CancelUpdateCertiBtn { get; set; }

        //Click Delete Icon for Certification    
        [FindsBy(How = How.XPath, Using = "//i[@class='remove icon']")]
        private IWebElement DeleteCerti { get; set; }

        //***DESCRIPTION***//

        //Click on Save Button
        [FindsBy(How = How.XPath, Using = "//button[@type='button']")]
        private IWebElement DescriptionSaveButton { get; set; }

        //***CHANGING PASSWORD***//

        //Click on the Profile Name Dropdown
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Go to Profile']")]
        private IWebElement ProfileNameDropdown { get; set; }

        //Select on the Change Password
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Change Password']")]
        private IWebElement ChangePassword { get; set; }

        //Enter on the Current Password Textbox
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Current Password']")]
        private IWebElement CurrentPswdTxtbox { get; set; }

        //Enter on the New Password Textbox
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='New Password']")]
        private IWebElement NewPswdTxtbox { get; set; }

        //Enter on the Confirm Password Textbox
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Confirm Password']")]
        private IWebElement ConfirmPswdTxtbox { get; set; }

        //Click on Save Button
        [FindsBy(How = How.XPath, Using = "//button[@role='button']")]
        private IWebElement SaveNewPswdBtn { get; set; }



        #endregion

        internal void ProfileAvailabilityTime()
        {

            GlobalDefinitions.wait(10);

            //Populate the Excel Sheet from Profile Availability Time sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "AvailabilityTime");
            GlobalDefinitions.wait(10);

            AvailabilityTimeEditButton.Click();

            //Selecting the Availability Time Dropdown

            var AvailTimeDropdown = GlobalDefinitions.ExcelLib.ReadData(2, "Availability");
            SelectElement dropdownList = new SelectElement(AvailabilityTime);
            dropdownList.SelectByText(AvailTimeDropdown);
            GlobalDefinitions.wait(10);

            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Availability Time Saves Successfully");

        }

        internal void ProfileAvailabilityHour()
        {
            GlobalDefinitions.wait(10);

            //Populate the Excel Sheet from Profile Availability Hours sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "AvailabilityHour");
            GlobalDefinitions.wait(10);

            HoursEditButton.Click();
                        
            //Selecting the Hours Dropdown
            SelectElement HoursDropdown = new SelectElement(Hours);
            GlobalDefinitions.wait(10);

            //Reading the excel file - Hours
            var expectedAvailHours = GlobalDefinitions.ExcelLib.ReadData(2, "Hours");
            HoursDropdown.SelectByText(expectedAvailHours);

            GlobalDefinitions.wait(10);

            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Availability Hour Saves Successfully");
        }

        internal void ProfileAvailabilitySalary()
        {

            GlobalDefinitions.wait(10);

            //Populate the Excel Sheet from Profile Availability Salary sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "AvailabilitySalary");
            GlobalDefinitions.wait(10);

            SalaryEditButton.Click();

            //Selecting the Salary Dropdown
            SelectElement SalaryDropdown = new SelectElement(Salary);
            GlobalDefinitions.wait(10);

            //Reading the excel file - Salary
            var expectedSalary = GlobalDefinitions.ExcelLib.ReadData(2, "Salary");
            SalaryDropdown.SelectByText(expectedSalary);
            GlobalDefinitions.wait(10);

            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Availability Salary Saves Successfully");
        }



        internal void ProfileLanguageAdd()
               
        {

            GlobalDefinitions.wait(5);                   
            LanguageTab.Click();

            GlobalDefinitions.wait(5);
            AddNewLangBtn.Click();

            //Populate the Excel Sheet from Language sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Language");
            GlobalDefinitions.wait(10);

         
            var expectedLanguage = GlobalDefinitions.ExcelLib.ReadData(2, "Language");
            AddLangText.SendKeys(expectedLanguage);
            GlobalDefinitions.wait(10);

            SelectElement LanguageLevelDropdown = new SelectElement(ChooseLangOpt);
            var LanguageLevel = GlobalDefinitions.ExcelLib.ReadData(2, "Language Level");
            LanguageLevelDropdown.SelectByText(LanguageLevel);
            GlobalDefinitions.wait(10);

            AddLang.Click();

            //GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.CssSelector(".ns-box-inner"),5);
            //IWebElement popUpMsg = GlobalDefinitions.driver.FindElement(By.CssSelector(".ns-box-inner"));
            //popUpMsg.SendKeys(expectedLanguage + " " + "has been added successfully to your languages");

           // Assertion if the actual language is the same as the expected language
            var actualLanguage = GlobalDefinitions.driver.FindElement(By.XPath($"//td[normalize-space()='{expectedLanguage}']")).Text;
            Assert.AreEqual(actualLanguage, expectedLanguage);

            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Language Added Successfully");


        }

        internal void ProfileLanguageCancel()

        {

            GlobalDefinitions.wait(5);
            LanguageTab.Click();

            GlobalDefinitions.wait(5);
            AddNewLangBtn.Click();

            //Populate the Excel Sheet from Language sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Language");
            GlobalDefinitions.wait(10);


            var expectedLanguage = GlobalDefinitions.ExcelLib.ReadData(2, "Language");
            AddLangText.SendKeys(expectedLanguage);
            GlobalDefinitions.wait(10);

            SelectElement LanguageLevelDropdown = new SelectElement(ChooseLangOpt);
            var LanguageLevel = GlobalDefinitions.ExcelLib.ReadData(2, "Language Level");
            LanguageLevelDropdown.SelectByText(LanguageLevel);
            GlobalDefinitions.wait(10);

            CancelLang.Click();
            GlobalDefinitions.wait(5);

            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Language Canceled Successfully");
        }

        internal void ProfileLanguageUpdate()

        {

            GlobalDefinitions.wait(5);
            LanguageTab.Click();

            GlobalDefinitions.wait(10);
            UpdateLangIcon.Click();

           
            //Populate the Excel Sheet from Language sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Language");
            GlobalDefinitions.wait(10);

            var expectedLanguage = GlobalDefinitions.ExcelLib.ReadData(4, "Language");
            AddLangText.Clear();
            AddLangText.SendKeys(expectedLanguage);
            GlobalDefinitions.wait(10);

            SelectElement LanguageLevelDropdown = new SelectElement(ChooseLangOpt);
            var LanguageLevel = GlobalDefinitions.ExcelLib.ReadData(4, "Language Level");
            LanguageLevelDropdown.SelectByText(LanguageLevel);
            GlobalDefinitions.wait(10);

            UpdateLangBtn.Click();

            //Assertion if the actual language is the same as the expected language
            var actualLanguage = GlobalDefinitions.driver.FindElement(By.XPath($"//td[normalize-space()='{expectedLanguage}']")).Text;
            Assert.AreEqual(actualLanguage, expectedLanguage);

            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Language Updated Successfully");

        }

        internal void ProfileLanguageUpdate_Cancel()

        {

            GlobalDefinitions.wait(5);
            LanguageTab.Click();

            UpdateLangIcon.Click();


            //Populate the Excel Sheet from Language sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Language");
            GlobalDefinitions.wait(10);

            var expectedLanguage = GlobalDefinitions.ExcelLib.ReadData(4, "Language");
            AddLangText.SendKeys(expectedLanguage);
            GlobalDefinitions.wait(10);

            SelectElement LanguageLevelDropdown = new SelectElement(ChooseLangOpt);
            var LanguageLevel = GlobalDefinitions.ExcelLib.ReadData(4, "Language Level");
            LanguageLevelDropdown.SelectByText(LanguageLevel);
            GlobalDefinitions.wait(10);

            UpdateCancelBtn.Click();

            //Assertion if the actual language is the same as the expected language
            var actualLanguage = GlobalDefinitions.driver.FindElement(By.XPath($"//td[normalize-space()='{expectedLanguage}']")).Text;
            Assert.AreEqual(actualLanguage, expectedLanguage);

            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Language Update Canceled Successfully");
        }

        internal void ProfileLanguageDelete()

        {

            GlobalDefinitions.wait(5);
            LanguageTab.Click();

            GlobalDefinitions.wait(5);
            DeleteLangIcon.Click();

            var expectedLanguage = GlobalDefinitions.ExcelLib.ReadData(3, "Language");
            GlobalDefinitions.wait(10);

            //assertion if the deleted skills is existing or not after the confirmation

            var isElementExist = true;
            try
            {
                GlobalDefinitions.driver.FindElement(By.XPath($"//td[normalize-space()='{expectedLanguage}']"));
            }
            catch (NoSuchElementException)
            {
                isElementExist = false;
            }

            Assert.IsFalse(isElementExist);

            Thread.Sleep(1000);

            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Language Deleted Successfully");
        }

        internal void ProfileSkillsAdd()
        {

            GlobalDefinitions.wait(5);
            SkillTab.Click();

            //Populate the Excel Sheet from Skills sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Skills");
            GlobalDefinitions.wait(5);


            AddNewSkillBtn.Click();

            var expectedSkill = GlobalDefinitions.ExcelLib.ReadData(2, "Skills");
            AddSkillText.SendKeys(expectedSkill);
            GlobalDefinitions.wait(10);

            SelectElement SkillLevelDropdown = new SelectElement(ChooseSkilllevel);
            var expectedSkillDropdown = GlobalDefinitions.ExcelLib.ReadData(2, "Skill Level");
            SkillLevelDropdown.SelectByText(expectedSkillDropdown);
            GlobalDefinitions.wait(10);

            AddSkill.Click();
            GlobalDefinitions.wait(5);

            //Assertion if the actual skill is the same as the expected skill
            var actualSkill = GlobalDefinitions.driver.FindElement(By.XPath($"//td[normalize-space()='{expectedSkill}']")).Text;
            Assert.AreEqual(actualSkill, expectedSkill);

            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Skills Added Successfully");

        }

        internal void ProfileSkillsCancel()
        {

            GlobalDefinitions.wait(5);
            SkillTab.Click();

            //Populate the Excel Sheet from Skills sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Skills");
            GlobalDefinitions.wait(10);


            AddNewSkillBtn.Click();

            var expectedSkill = GlobalDefinitions.ExcelLib.ReadData(2, "Skills");
            AddSkillText.SendKeys(expectedSkill);
            GlobalDefinitions.wait(10);

            SelectElement SkillLevelDropdown = new SelectElement(ChooseSkilllevel);
            var expectedSkillDropdown = GlobalDefinitions.ExcelLib.ReadData(3, "Skill Level");
            SkillLevelDropdown.SelectByText(expectedSkillDropdown);
            GlobalDefinitions.wait(10);

            CancelSkill.Click();
            GlobalDefinitions.wait(5);

            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Skills Canceled Successfully");

        }

        internal void ProfileSkillsUpdate()
        {

            GlobalDefinitions.wait(5);
            SkillTab.Click();

            //Populate the Excel Sheet from Skills sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Skills");
            GlobalDefinitions.wait(5);


            UpdateSkillIcon.Click();

            var expectedSkill = GlobalDefinitions.ExcelLib.ReadData(4, "Skills");
            AddSkillText.Clear();
            AddSkillText.SendKeys(expectedSkill);
            GlobalDefinitions.wait(15);

            SelectElement SkillLevelDropdown = new SelectElement(ChooseSkilllevel);
            var expectedSkillDropdown = GlobalDefinitions.ExcelLib.ReadData(4, "Skill Level");
            SkillLevelDropdown.SelectByText(expectedSkillDropdown);
            GlobalDefinitions.wait(15);

            UpdateSkillBtn.Click();
            GlobalDefinitions.wait(10);

            //Assertion if the actual skill is the same as the expected skill
            var actualSkill = GlobalDefinitions.driver.FindElement(By.XPath($"//td[normalize-space()='{expectedSkill}']")).Text;
            Assert.AreEqual(actualSkill, expectedSkill);

            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Skills Updated Successfully");
        }

        internal void ProfileSkillsUpdate_Cancel()
        {

            GlobalDefinitions.wait(5);
            SkillTab.Click();

            //Populate the Excel Sheet from Skills sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Skills");
            GlobalDefinitions.wait(5);

           
            UpdateSkillIcon.Click();

            var expectedSkill = GlobalDefinitions.ExcelLib.ReadData(4, "Skills");
            AddSkillText.Clear();
            AddSkillText.SendKeys(expectedSkill);
            GlobalDefinitions.wait(15);

            SelectElement SkillLevelDropdown = new SelectElement(ChooseSkilllevel);
            var expectedSkillDropdown = GlobalDefinitions.ExcelLib.ReadData(4, "Skill Level");
            SkillLevelDropdown.SelectByText(expectedSkillDropdown);
            GlobalDefinitions.wait(15);

            CancelUpdateSkillBtn.Click();
            GlobalDefinitions.wait(10);

            //Assertion if the actual skill is the same as the expected skill
            var actualSkill = GlobalDefinitions.driver.FindElement(By.XPath($"//td[normalize-space()='{expectedSkill}']")).Text;
            Assert.AreEqual(actualSkill, expectedSkill);

            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Skills Update Canceled Successfully");
        }

        internal void ProfileSkillsDelete()
        {

            GlobalDefinitions.wait(5);
            SkillTab.Click();

            //GlobalDefinitions.wait(5);
            //DeleteSkillIcon.Click();

            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.CssSelector("body > div:nth-child(1) > div:nth-child(1) > section:nth-child(3) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(3) > form:nth-child(2) > div:nth-child(3) > div:nth-child(1) > div:nth-child(2) > div:nth-child(1) > table:nth-child(1) > tbody:nth-child(2) > tr:nth-child(1) > td:nth-child(3) > span:nth-child(2) > i:nth-child(1)"), 15);
            IWebElement DltSkillIcon = GlobalDefinitions.driver.FindElement(By.CssSelector("body > div:nth-child(1) > div:nth-child(1) > section:nth-child(3) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(3) > form:nth-child(2) > div:nth-child(3) > div:nth-child(1) > div:nth-child(2) > div:nth-child(1) > table:nth-child(1) > tbody:nth-child(2) > tr:nth-child(1) > td:nth-child(3) > span:nth-child(2) > i:nth-child(1)"));
            DltSkillIcon.Click();

            var expectedSkill = GlobalDefinitions.ExcelLib.ReadData(4, "Skills");

            //assertion if the deleted skills is existing or not after the confirmation

            var isElementExist = true;
            try
            {
                GlobalDefinitions.driver.FindElement(By.XPath($"//td[normalize-space()='{expectedSkill}']"));
            }
            catch (NoSuchElementException)
            {
                isElementExist = false;
            }

            Assert.IsFalse(isElementExist);

            Thread.Sleep(1000);

            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Skills Deleted Successfully");
        }

        internal void ProfileEducationAdd() 
        {

            GlobalDefinitions.wait(5);

            EducationTab.Click();

            
            //Populate the Excel Sheet from Education sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Education");
            GlobalDefinitions.wait(5);

            AddNewEducation.Click();
            GlobalDefinitions.wait(5);

            EnterUniversity.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "University"));
            GlobalDefinitions.wait(10);

            SelectElement UniversityDropdown = new SelectElement(ChooseCountry);
            var expectedUniversity = GlobalDefinitions.ExcelLib.ReadData(2, "Country of College");
            UniversityDropdown.SelectByText(expectedUniversity);
            GlobalDefinitions.wait(10);


            SelectElement TitleDropdown = new SelectElement(ChooseTitle);
            var expectedTitle = GlobalDefinitions.ExcelLib.ReadData(2, "Title");
            TitleDropdown.SelectByText(expectedTitle);
            GlobalDefinitions.wait(10);

            Degree.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Degree"));
            GlobalDefinitions.wait(10);

            SelectElement DegreeYearDropdown = new SelectElement(DegreeYear);
            var expectedDegreeYear = GlobalDefinitions.ExcelLib.ReadData(2, "Year of Graduation");
            DegreeYearDropdown.SelectByText(expectedDegreeYear);
            GlobalDefinitions.wait(10);

            AddEdu.Click();
            GlobalDefinitions.wait(5);

            //Assertion if the actual education is the same as the expected education
            var actualUniversity = GlobalDefinitions.driver.FindElement(By.XPath($"//td[normalize-space()='{expectedUniversity}']")).Text;
            Assert.AreEqual(actualUniversity, expectedUniversity);

            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Education Added Successfully");

        }

        internal void ProfileEducationCancel()
        {

            GlobalDefinitions.wait(5);

            EducationTab.Click();


            //Populate the Excel Sheet from Education sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Education");
            GlobalDefinitions.wait(5);

            AddNewEducation.Click();
            GlobalDefinitions.wait(5);

            EnterUniversity.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "University"));
            GlobalDefinitions.wait(10);

            SelectElement UniversityDropdown = new SelectElement(ChooseCountry);
            var expectedUniversity = GlobalDefinitions.ExcelLib.ReadData(2, "Country of College");
            UniversityDropdown.SelectByText(expectedUniversity);
            GlobalDefinitions.wait(10);


            SelectElement TitleDropdown = new SelectElement(ChooseTitle);
            var expectedTitle = GlobalDefinitions.ExcelLib.ReadData(2, "Title");
            TitleDropdown.SelectByText(expectedTitle);
            GlobalDefinitions.wait(10);

            Degree.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Degree"));
            GlobalDefinitions.wait(10);

            SelectElement DegreeYearDropdown = new SelectElement(DegreeYear);
            var expectedDegreeYear = GlobalDefinitions.ExcelLib.ReadData(3, "Year of Graduation");
            DegreeYearDropdown.SelectByText(expectedDegreeYear);
            GlobalDefinitions.wait(10);

            CancelEdu.Click();
            GlobalDefinitions.wait(5);

            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Education Canceled Successfully");


        }

        internal void ProfileEducationUpdate()
        {

            GlobalDefinitions.wait(5);

            EducationTab.Click();


            //Populate the Excel Sheet from Education sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Education");

            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.CssSelector("tbody tr td:nth-child(6) span:nth-child(1) i:nth-child(1)"), 15);
            IWebElement UpdateIcon = GlobalDefinitions.driver.FindElement(By.CssSelector("tbody tr td:nth-child(6) span:nth-child(1) i:nth-child(1)"));
            UpdateIcon.Click();
            //Actions action = new Actions(GlobalDefinitions.driver);
            //action.Click();

            //UpdatedEduIcon.Click();
            GlobalDefinitions.wait(5);

            EnterUniversity.Clear();
            EnterUniversity.SendKeys(GlobalDefinitions.ExcelLib.ReadData(4, "University"));
            GlobalDefinitions.wait(10);

            SelectElement UniversityDropdown = new SelectElement(ChooseCountry);
            var expectedUniversity = GlobalDefinitions.ExcelLib.ReadData(2, "Country of College");
            UniversityDropdown.SelectByText(expectedUniversity);
            GlobalDefinitions.wait(10);

            SelectElement TitleDropdown = new SelectElement(ChooseTitle);
            var expectedTitle = GlobalDefinitions.ExcelLib.ReadData(4, "Title");
            TitleDropdown.SelectByText(expectedTitle);
            GlobalDefinitions.wait(10);

            Degree.Clear();
            Degree.SendKeys(GlobalDefinitions.ExcelLib.ReadData(4, "Degree"));
            GlobalDefinitions.wait(10);

            SelectElement DegreeYearDropdown = new SelectElement(DegreeYear);
            var expectedDegreeYear = GlobalDefinitions.ExcelLib.ReadData(4, "Year of Graduation");
            DegreeYearDropdown.SelectByText(expectedDegreeYear);
            GlobalDefinitions.wait(10);

         
            UpdatedEduBtn.Click();
            GlobalDefinitions.wait(5);

            //Assertion if the actual education is the same as the expected education
            var actualUniversity = GlobalDefinitions.driver.FindElement(By.XPath($"//td[normalize-space()='{expectedUniversity}']")).Text;
            Assert.AreEqual(actualUniversity, expectedUniversity);

            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Education Updated Successfully");

        }

        internal void ProfileEducationUpdate_Cancel()
        {

            GlobalDefinitions.wait(5);

            EducationTab.Click();


            //Populate the Excel Sheet from Education sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Education");

            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.CssSelector("tbody tr td:nth-child(6) span:nth-child(1) i:nth-child(1)"), 15);
            IWebElement UpdateIcon = GlobalDefinitions.driver.FindElement(By.CssSelector("tbody tr td:nth-child(6) span:nth-child(1) i:nth-child(1)"));
            UpdateIcon.Click();
           

            //UpdatedEduIcon.Click();
            GlobalDefinitions.wait(5);

            EnterUniversity.Clear();
            EnterUniversity.SendKeys(GlobalDefinitions.ExcelLib.ReadData(4, "University"));
            GlobalDefinitions.wait(10);

            SelectElement UniversityDropdown = new SelectElement(ChooseCountry);
            var expectedUniversity = GlobalDefinitions.ExcelLib.ReadData(2, "Country of College");
            UniversityDropdown.SelectByText(expectedUniversity);
            GlobalDefinitions.wait(10);

            SelectElement TitleDropdown = new SelectElement(ChooseTitle);
            var expectedTitle = GlobalDefinitions.ExcelLib.ReadData(4, "Title");
            TitleDropdown.SelectByText(expectedTitle);
            GlobalDefinitions.wait(10);

            Degree.Clear();
            Degree.SendKeys(GlobalDefinitions.ExcelLib.ReadData(4, "Degree"));
            GlobalDefinitions.wait(10);

            SelectElement DegreeYearDropdown = new SelectElement(DegreeYear);
            var expectedDegreeYear = GlobalDefinitions.ExcelLib.ReadData(4, "Year of Graduation");
            DegreeYearDropdown.SelectByText(expectedDegreeYear);
            GlobalDefinitions.wait(10);


            CancelUpdateEduBtn.Click();
            GlobalDefinitions.wait(5);

            //Assertion if the actual education is the same as the expected education
            var actualUniversity = GlobalDefinitions.driver.FindElement(By.XPath($"//td[normalize-space()='{expectedUniversity}']")).Text;
            Assert.AreEqual(actualUniversity, expectedUniversity);

            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Education Update Cancel Successfully");

        }



        internal void ProfileEducationDelete()
        {
            GlobalDefinitions.wait(5);
            EducationTab.Click();

            
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.CssSelector("tbody tr td:nth-child(6) span:nth-child(2) i:nth-child(1)"), 15);
            IWebElement DltEduIcon = GlobalDefinitions.driver.FindElement(By.CssSelector("tbody tr td:nth-child(6) span:nth-child(2) i:nth-child(1)"));
            DltEduIcon.Click();

            var expectedCollegeName = GlobalDefinitions.ExcelLib.ReadData(4, "University");

            //assertion if the deleted skills is existing or not after the confirmation

            var isElementExist = true;
            try
            {
                GlobalDefinitions.driver.FindElement(By.XPath($"//td[normalize-space()='{expectedCollegeName}']"));
            }
            catch (NoSuchElementException)
            {
                isElementExist = false;
            }

            Assert.IsFalse(isElementExist);

            Thread.Sleep(1000);

            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Education Deleted Successfully");
        }

        internal void ProfileCertificationAdd()
        {
            GlobalDefinitions.wait(5);
           
            CertificationTab.Click();

            //Populate the Excel Sheet from Certification sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Certification");
            GlobalDefinitions.wait(10);

            AddNewCerti.Click();
            GlobalDefinitions.wait(5);


            EnterCerti.Clear();
            EnterCerti.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Certificate"));
            GlobalDefinitions.wait(10);

            CertiFrom.Clear();
            CertiFrom.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Certified from"));
            GlobalDefinitions.wait(10);

            SelectElement certiYearDropdown = new SelectElement(CertiYear);
            var expectedCertiYear = GlobalDefinitions.ExcelLib.ReadData(2, "Year");
            certiYearDropdown.SelectByText(expectedCertiYear);
            GlobalDefinitions.wait(10);

            AddCertiBtn.Click();

            //Assertion if the actual certification is the same as the expected certification
            var actualCertiYear = GlobalDefinitions.driver.FindElement(By.XPath($"//td[normalize-space()='{expectedCertiYear}']")).Text;
            Assert.AreEqual(actualCertiYear, expectedCertiYear);

            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Certification Added Successfully");
            
        }

        internal void ProfileCertificationCancel()
        {
            GlobalDefinitions.wait(5);
            CertificationTab.Click();

            //Populate the Excel Sheet from Certification sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Certification");
            GlobalDefinitions.wait(10);

            AddNewCerti.Click();
            GlobalDefinitions.wait(5);

            EnterCerti.Clear();
            EnterCerti.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Certificate"));
            GlobalDefinitions.wait(10);

            CertiFrom.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Certified from"));
            GlobalDefinitions.wait(10);

            SelectElement certiYearDropdown = new SelectElement(CertiYear);
            var expectedYear = GlobalDefinitions.ExcelLib.ReadData(3, "Year");
            certiYearDropdown.SelectByText(expectedYear);
            GlobalDefinitions.wait(10);

            CancelCertiBtn.Click();
            GlobalDefinitions.wait(10);

            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Certification Canceled Successfully");
        }

        internal void ProfileCertificationUpdate()
        {
            GlobalDefinitions.wait(10);
            CertificationTab.Click();

            //Populate the Excel Sheet from Certification sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Certification");
            GlobalDefinitions.wait(10);

            var updateCertIcon = GlobalDefinitions.driver.FindElement(By.CssSelector("tbody tr td:nth-child(4) span:nth-child(1) i:nth-child(1)"));
            //UpdateCertiIcon.Click();
            updateCertIcon.Click();
            GlobalDefinitions.wait(5);

            EnterCerti.Clear();
            EnterCerti.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Certificate"));
            GlobalDefinitions.wait(10);

            CertiFrom.Clear();
            CertiFrom.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Certified from"));
            GlobalDefinitions.wait(10);

            SelectElement certiYearDropdown = new SelectElement(CertiYear);
            var expectedCertiYear = GlobalDefinitions.ExcelLib.ReadData(3, "Year");
            certiYearDropdown.SelectByText(expectedCertiYear);
            GlobalDefinitions.wait(10);

            UpdateCertiBtn.Click();

            //Assertion if the actual certification is the same as the expected certification
            var actualCertiYear = GlobalDefinitions.driver.FindElement(By.XPath($"//td[normalize-space()='{expectedCertiYear}']")).Text;
            Assert.AreEqual(actualCertiYear, expectedCertiYear);

            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Certification Updated Successfully");
        }

        internal void ProfileCertificationUpdate_Cancel()
        {
            GlobalDefinitions.wait(10);
            CertificationTab.Click();

            //Populate the Excel Sheet from Certification sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Certification");
            GlobalDefinitions.wait(10);


            var updateCertIcon = GlobalDefinitions.driver.FindElement(By.CssSelector("tbody tr td:nth-child(4) span:nth-child(1) i:nth-child(1)"));
            //UpdateCertiIcon.Click();
            updateCertIcon.Click();
            GlobalDefinitions.wait(5);

            EnterCerti.Clear();
            EnterCerti.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Certificate"));
            GlobalDefinitions.wait(10);

            CertiFrom.Clear();
            CertiFrom.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Certified from"));
            GlobalDefinitions.wait(10);

            SelectElement certiYearDropdown = new SelectElement(CertiYear);
            var expectedCertiYear = GlobalDefinitions.ExcelLib.ReadData(3, "Year");
            certiYearDropdown.SelectByText(expectedCertiYear);
            GlobalDefinitions.wait(10);

            CancelUpdateCertiBtn.Click();

            //Assertion if the actual certification is the same as the expected certification
            var actualCertiYear = GlobalDefinitions.driver.FindElement(By.XPath($"//td[normalize-space()='{expectedCertiYear}']")).Text;
            Assert.AreEqual(actualCertiYear, expectedCertiYear);

            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Certification Update Canceled Successfully");

        }


        internal void ProfileCertificationDelete()
        {
            GlobalDefinitions.wait(10);
            CertificationTab.Click();

            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.CssSelector("tbody tr td:nth-child(4) span:nth-child(2) i:nth-child(1)"), 15);
            IWebElement DltCertiIcon = GlobalDefinitions.driver.FindElement(By.CssSelector("tbody tr td:nth-child(4) span:nth-child(2) i:nth-child(1)"));
            DltCertiIcon.Click();

            //SelectElement certiYearDropdown = new SelectElement(CertiYear);
            var expectedCertiYear = GlobalDefinitions.ExcelLib.ReadData(3, "Year");
            //certiYearDropdown.SelectByText(expectedCertiYear);
            

            //assertion if the deleted skills is existing or not after the confirmation

            var isElementExist = true;
            try
            {
                GlobalDefinitions.driver.FindElement(By.XPath($"//td[normalize-space()='{expectedCertiYear}']"));
            }
            catch (NoSuchElementException)
            {
                isElementExist = false;
            }

            Assert.IsFalse(isElementExist);

            Thread.Sleep(1000);

            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Certification Deleted Successfully");

        }

        internal void ProfileDescriptionAdd()
        {

            GlobalDefinitions.wait(10);
            

            //Populate the Excel Sheet from Description sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Description");

            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.CssSelector("h3[class='ui dividing header'] span[class='button']"),15);
            
            IWebElement descriptionBtn = GlobalDefinitions.driver.FindElement(By.CssSelector("h3[class='ui dividing header'] span[class='button']"));
            descriptionBtn.Click();


            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.Name("value"),20);

            IWebElement descriptionTxtbox = GlobalDefinitions.driver.FindElement(By.Name("value"));
            descriptionTxtbox.Clear();
            descriptionTxtbox.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Description"));

            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//button[@type='button']"), 20);
            IWebElement descriptionSaveButton = GlobalDefinitions.driver.FindElement(By.XPath("//button[@type='button']"));
            descriptionSaveButton.Click();


            ////Assertion if the actual Description is the same as the expected description
            //var actualDescription = GlobalDefinitions.driver.FindElement(By.CssSelector($"//span[contains(text(),'{descriptionTxtbox}')]")).Text;
            //Assert.AreEqual(actualDescription, descriptionTxtbox);
            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Description Added Successfully");
        }

        internal void ProfileDescriptionUpdate()
        {

            GlobalDefinitions.wait(10);


            //Populate the Excel Sheet from Description sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Description");

            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.CssSelector("h3[class='ui dividing header'] span[class='button']"), 15);

            IWebElement descriptionBtnUpdate = GlobalDefinitions.driver.FindElement(By.CssSelector("h3[class='ui dividing header'] span[class='button']"));
            descriptionBtnUpdate.Click();

            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.Name("value"), 20);

            IWebElement descriptionTxtbox = GlobalDefinitions.driver.FindElement(By.Name("value"));
            descriptionTxtbox.Clear();
            descriptionTxtbox.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Description"));

            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//button[@type='button']"), 20);
            IWebElement descriptionSaveButton = GlobalDefinitions.driver.FindElement(By.XPath("//button[@type='button']"));
            descriptionSaveButton.Click();

            ////Assertion if the actual Description is the same as the expected description
            //var actualDescription = GlobalDefinitions.driver.FindElement(By.XPath($"//span[contains(text(),'{descriptionTxtbox}')]")).Text;
            //Assert.AreEqual(actualDescription, descriptionTxtbox);
            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Description Updated Successfully");

            
        }



        internal void ChangingPassword() 
        {
            GlobalDefinitions.wait(10);

            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Signin");

            IWebElement ProfileSpanElement = GlobalDefinitions.driver.FindElement(By.XPath("//span[contains(@class,'item ui dropdown link')]"));
            ProfileSpanElement.Click();

            Actions action = new Actions(GlobalDefinitions.driver);
            action.Click();

            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//a[normalize-space()='Change Password']"), 15);
            IWebElement ChangePasswordDrpdwn = GlobalDefinitions.driver.FindElement(By.XPath("//a[normalize-space()='Change Password']"));
            ChangePasswordDrpdwn.Click();
                        
            CurrentPswdTxtbox.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Password"));
            GlobalDefinitions.wait(10);

            NewPswdTxtbox.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "NewPassword"));
            GlobalDefinitions.wait(10);

            ConfirmPswdTxtbox.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "ConfirmPswd"));
            GlobalDefinitions.wait(10);

            SaveNewPswdBtn.Click();

            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Password Changed Successfully");

        }
    }
}