using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System.Threading;
using static NUnit.Core.NUnitFramework;

namespace MarsFramework
{
    internal class Profile
    {

        public Profile()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
            
        }

        #region  Initialize Web Elements 
        //Click on Availability Time Edit button
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Part Time']//i[@class='right floated outline small write icon']")]
        private IWebElement AvailabilityTimeEditButton { get; set; }

        //Click on Availability Time dropdown
        [FindsBy(How = How.CssSelector, Using = "select[name='availabiltyType']")]
        private IWebElement AvailabilityTime { get; set; }

        //Click on Availability Time option
        [FindsBy(How = How.XPath, Using = "//option[@value='0']")]
        private IWebElement AvailabilityTimeOpt { get; set; }

        //Click on Edit hours Edit button
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Less than 30hours a week']//i[@class='right floated outline small write icon']")]
        private IWebElement HoursEditButton { get; set; }

        //Click on Hour dropdown
        [FindsBy(How = How.XPath, Using = "//select[@name='availabiltyHour']")]
        private IWebElement Hours { get; set; }

        //Click on Edit Earn Target/Salary Edit button
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Less than $500 per month']//i[@class='right floated outline small write icon']")]
        private IWebElement SalaryEditButton { get; set; }


        //Click on salary Dropdown
        [FindsBy(How = How.XPath, Using = "//select[@name='availabiltyTarget']")]
        private IWebElement Salary { get; set; }

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


        //Click on Language Tab
        [FindsBy(How = How.XPath, Using = "//a[@class='item active']")]
        private IWebElement LanguageTab { get; set; }

        //Click on Add new to add new Language
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div")]
        private IWebElement AddNewLangBtn { get; set; }

        //Enter the Language on text box
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[3]/div/div[2]/div/div/div[1]/input")]
        private IWebElement AddLangText { get; set; }

        //Enter the Language on text box
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[3]/div/div[2]/div/div/div[2]/select/option[3]")]
        private IWebElement ChooseLangOpt { get; set; }

        //Add Language
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[3]/div/div[2]/div/div/div[3]/input[1]")]
        private IWebElement AddLang { get; set; }


        //Click on Skill Tab
        [FindsBy(How = How.XPath, Using = "//a[@class='item active']")]
        private IWebElement SkillTab { get; set; }


        //Click on Add new to add new skill
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/table/thead/tr/th[3]/div")]
        private IWebElement AddNewSkillBtn { get; set; }

        //Enter the Skill on text box
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/div/div[1]/input")]
        private IWebElement AddSkillText { get; set; }

        //Choose the skill level option
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/div/div[2]/select/option[3]")]
        private IWebElement ChooseSkilllevel { get; set; }

        //Add Skill
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/div/span/input[1]")]
        private IWebElement AddSkill { get; set; }


        //Click on Education Tab
        [FindsBy(How = How.XPath, Using = "//a[@class='item active']")]
        private IWebElement EducationTab { get; set; }



        //Click on Add new to Educaiton
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/table/thead/tr/th[6]/div")]
        private IWebElement AddNewEducation { get; set; }

        //Enter university in the text box
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[1]/div[1]/input")]
        private IWebElement EnterUniversity { get; set; }

        //Choose the country
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[1]/div[2]/select")]
        private IWebElement ChooseCountry { get; set; }

        //Click on Title dropdown
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[1]/select")]
        private IWebElement ChooseTitle { get; set; }

        //Degree
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[2]/input")]
        private IWebElement Degree { get; set; }

        //Year of graduation
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[3]/select")]
        private IWebElement DegreeYear { get; set; }

        //Choose Year
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[3]/select/option[4]")]
        private IWebElement DegreeYearOpt { get; set; }

        //Click on Add
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[3]/div/input[1]")]
        private IWebElement AddEdu { get; set; }


        //Click on Certification Tab
        [FindsBy(How = How.XPath, Using = "//a[@class='item active']")]
        private IWebElement CertificationTab { get; set; }

        //Add new Certificate
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/table/thead/tr/th[4]/div")]
        private IWebElement AddNewCerti { get; set; }

        //Enter Certification Name
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[1]/div/input")]
        private IWebElement EnterCerti { get; set; }

        //Certified from 
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[2]/div[1]/input")]
        private IWebElement CertiFrom { get; set; }

        //Year
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[2]/div[2]/select")]
        private IWebElement CertiYear { get; set; }


        //Clicking Description Edit/Update button
        [FindsBy(How = How.XPath, Using = "//h3[normalize-space()='Description']")]
        private IWebElement DescriptionButton { get; set; }


        //Add Description
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[8]/div/div[2]/div[1]/textarea")]
        private IWebElement Description { get; set; }

        //Click on Save Button
        [FindsBy(How = How.XPath, Using = "//button[@type='button']")]
        private IWebElement DescriptionSaveButton { get; set; }

        ////Looking for Sign Out Button
        //[FindsBy(How = How.XPath, Using = "//button[normalize-space()='Sign Out']")]
        //private IWebElement SignOutButton { get; set; }

        #endregion

        internal void ProfileAvail()
        {

            GlobalDefinitions.wait(5);

            AvailabilityTimeEditButton.Click();

            //var actualLanguage = GlobalDefinitions.driver.FindElement(By.XPath($"//td[normalize-space()='{expectedLanguage}']")).Text;

            //Populate the Excel Sheet from Profile Availability sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ProfileAvailability");

            GlobalDefinitions.wait(5);

            //Selecting the Availability Time Dropdown

            var AvailTimeDropdown = GlobalDefinitions.ExcelLib.ReadData(2, "Availability");
            SelectElement dropdownList = new SelectElement(AvailabilityTime);
            dropdownList.SelectByValue(AvailTimeDropdown);

            GlobalDefinitions.wait(5);

            HoursEditButton.Click();

            //Selecting the Hours Dropdown
            SelectElement HoursDropdown = new SelectElement(Hours);

            //Reading the excel file - Hours
            var expectedAvailHours = GlobalDefinitions.ExcelLib.ReadData(2, "Hours");
            HoursDropdown.SelectByText(expectedAvailHours);
            GlobalDefinitions.wait(5);

            SalaryEditButton.Click();

            //Selecting the Salary Dropdown
            SelectElement SalaryDropdown = new SelectElement(Salary);

            //Reading the excel file - Salary
            var expectedSalary = GlobalDefinitions.ExcelLib.ReadData(2, "Salary");
            SalaryDropdown.SelectByText(expectedSalary);
            GlobalDefinitions.wait(5);

        }


        internal void ProfileLanguage()
               
        {

            GlobalDefinitions.wait(5);

            //navigating to the profile page
            GlobalDefinitions.driver.Navigate().GoToUrl("http://localhost:5000/Account/Profile");

            LanguageTab.Click();

            AddNewLangBtn.Click();

            //Populate the Excel Sheet from Language sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Language");
            GlobalDefinitions.wait(5);

            AddLangText.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Language"));
            GlobalDefinitions.wait(5);

            SelectElement LanguageLevelDropdown = new SelectElement(ChooseLangOpt);

            var expectedLanguage = GlobalDefinitions.ExcelLib.ReadData(2, "Language Level");
            LanguageLevelDropdown.SelectByText(expectedLanguage);
            GlobalDefinitions.wait(5);

            AddLang.Click();

            //Assertion if the actual language is the same as the expected language
            var actualLanguage = GlobalDefinitions.driver.FindElement(By.XPath($"//td[normalize-space()='{expectedLanguage}']")).Text;
            Assert.AreEqual(actualLanguage, expectedLanguage);


        }

        internal void ProfileSkills()
        {

            GlobalDefinitions.wait(5);

            //navigating to profile
            GlobalDefinitions.driver.Navigate().GoToUrl("http://localhost:5000/Account/Profile");

            SkillTab.Click();

            //Populate the Excel Sheet from Skills sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Skills");
            GlobalDefinitions.wait(5);


            AddNewSkillBtn.Click();

            AddSkillText.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Skills"));
            GlobalDefinitions.wait(5);

            SelectElement SkillLevelDropdown = new SelectElement(ChooseSkilllevel);

            var expectedSkill = GlobalDefinitions.ExcelLib.ReadData(2, "Skill Level");
            SkillLevelDropdown.SelectByText(expectedSkill);
            GlobalDefinitions.wait(5);

            AddSkill.Click();

            //Assertion if the actual skill is the same as the expected skill
            var actualSkill = GlobalDefinitions.driver.FindElement(By.XPath($"//td[normalize-space()='{expectedSkill}']")).Text;
            Assert.AreEqual(actualSkill, expectedSkill);


        }

        internal void ProfileEducation() 
        {

            GlobalDefinitions.wait(5);

            //navigating to profile
            GlobalDefinitions.driver.Navigate().GoToUrl("http://localhost:5000/Account/Profile");

            EducationTab.Click();

            //Populate the Excel Sheet from Education sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Education");
            GlobalDefinitions.wait(5);

            EnterUniversity.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "University"));
            GlobalDefinitions.wait(5);

            SelectElement UniversityDropdown = new SelectElement(ChooseCountry);
            var expectedUniversity = GlobalDefinitions.ExcelLib.ReadData(2, "Country of College");
            UniversityDropdown.SelectByText(expectedUniversity);


            SelectElement TitleDropdown = new SelectElement(ChooseTitle);
            var expectedTitle = GlobalDefinitions.ExcelLib.ReadData(2, "Title");
            TitleDropdown.SelectByText(expectedTitle);

            Degree.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Degree"));
            GlobalDefinitions.wait(5);

            SelectElement DegreeYearDropdown = new SelectElement(DegreeYear);
            var expectedDegreeYear = GlobalDefinitions.ExcelLib.ReadData(2, "Year of Graduation");
            DegreeYearDropdown.SelectByText(expectedDegreeYear);

            AddEdu.Click();

            //Assertion if the actual education is the same as the expected education
            var actualUniversity = GlobalDefinitions.driver.FindElement(By.XPath($"//td[normalize-space()='{expectedUniversity}']")).Text;
            Assert.AreEqual(actualUniversity, expectedUniversity);

        }

        internal void ProfileCertification() 
        {
            GlobalDefinitions.wait(5);

            //navigating to profile
            GlobalDefinitions.driver.Navigate().GoToUrl("http://localhost:5000/Account/Profile");

            CertificationTab.Click();

            //Populate the Excel Sheet from Certification sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Certification");
            GlobalDefinitions.wait(5);

            SelectElement Certification = new SelectElement(EnterCerti);
            var expectedCertification = GlobalDefinitions.ExcelLib.ReadData(2, "Certificate");
            Certification.SelectByText(expectedCertification);
            GlobalDefinitions.wait(5);

            CertiFrom.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Certified from"));
            GlobalDefinitions.wait(5);

            SelectElement certiYearDropdown = new SelectElement(CertiYear);
            var expectedYear = GlobalDefinitions.ExcelLib.ReadData(2, "Year");
            certiYearDropdown.SelectByText(expectedYear);

            //Assertion if the actual certification is the same as the expected certification
            var actualCertification = GlobalDefinitions.driver.FindElement(By.XPath($"//td[normalize-space()='{expectedCertification}']")).Text;
            Assert.AreEqual(actualCertification, expectedCertification);

        }

        internal void ProfileDescription()
        {

            GlobalDefinitions.wait(5);

            //navigating to profile
            GlobalDefinitions.driver.Navigate().GoToUrl("http://localhost:5000/Account/Profile");

            DescriptionButton.Click();

            //Populate the Excel Sheet from Description sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Description");
            GlobalDefinitions.wait(5);


            SelectElement descriptionTxt = new SelectElement(Description);
            var expectedDescription = GlobalDefinitions.ExcelLib.ReadData(2, "Description");
            descriptionTxt.SelectByText(expectedDescription);
            GlobalDefinitions.wait(5);

            DescriptionSaveButton.Click();

            //Assertion if the actual Description is the same as the expected description
            var actualDescription = GlobalDefinitions.driver.FindElement(By.XPath($"//div[@class='ui fluid card']//div[@class='{expectedDescription}']//div//span']")).Text;
            Assert.AreEqual(actualDescription, expectedDescription);

            

        }
    }
}