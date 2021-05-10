using MarsFramework.Global;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MarsFramework.Pages
{
    class SignIn
    {
        public SignIn()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        #region  Initialize Web Elements 
        //Finding the Sign Link
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div/div/div[1]/div/a")]
       // [CacheLookup]
        private IWebElement SignIntab { get; set; }

        // Finding the Email Field
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Email address']")]
        [CacheLookup]
        private IWebElement Email { get; set; }

        //Finding the Password Field
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Password']")]
        [CacheLookup]
        private IWebElement Password { get; set; }

        //Finding the Login Button
        [FindsBy(How = How.XPath, Using = "//button[normalize-space()='Login']")]
        [CacheLookup]
        private IWebElement LoginBtn { get; set; }

        #endregion

        internal void LoginSteps()
        {

            GlobalDefinitions.wait(5);

            //Populate the excel data
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "SignIn");

            //Click on Sign in button
            SignIntab.Click();

            //Enter Email
            Email.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Email"));

            //Enter Password
            Password.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Password"));

           //Click on Login button to Login
            LoginBtn.Click();

           
            
         

        }
    }
}