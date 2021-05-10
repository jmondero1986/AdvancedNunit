using MarsFramework.Global;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MarsFramework.Pages
{
    class SignUp
    {
        public SignUp()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        #region  Initialize Web Elements 
        //Finding the Join 
        [FindsBy(How = How.XPath, Using = "//button[normalize-space()='Join']")]
        [CacheLookup]
        private IWebElement Join { get; set; }

        //Identify FirstName Textbox
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[2]/div[1]/div[1]/form[1]/div[1]/input[1]")]
        [CacheLookup]
        private IWebElement FirstName { get; set; }

        //Identify LastName Textbox
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[2]/div[1]/div[1]/form[1]/div[2]/input[1]")]
        [CacheLookup]
        private IWebElement LastName { get; set; }

        //Identify Email Textbox
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Email address']")]
        [CacheLookup]
        private IWebElement Email { get; set; }

        //Identify Password Textbox
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Password']")]
        [CacheLookup]
        private IWebElement Password { get; set; }

        //Identify Confirm Password Textbox
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Confirm Password']")]
        [CacheLookup]
        private IWebElement ConfirmPassword { get; set; }

        //Identify Term and Conditions Checkbox
        [FindsBy(How = How.XPath, Using = "//input[@name='terms']")]
        [CacheLookup]
        private IWebElement Checkbox { get; set; }

        //Identify join button
        [FindsBy(How = How.XPath, Using = "//div[@id='submit-btn']")]
        [CacheLookup]
        private IWebElement JoinBtn { get; set; }
        #endregion

        internal void register()
        {
            GlobalDefinitions.wait(5);
            //Populate the excel data
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "SignUp");
            //Click on Join button
            Join.Click();
           
            //Enter FirstName
            FirstName.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "FirstName"));

            //Enter LastName
            LastName.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "LastName"));

            //Enter Email
            Email.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Email"));

            //Enter Password
            Password.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Password"));

            //Enter Password again to confirm
            ConfirmPassword.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "ConfirmPswd"));

            //Click on Checkbox
            Checkbox.Click();

            //Click on join button to Sign Up
            JoinBtn.Click();


        }
    }
}
