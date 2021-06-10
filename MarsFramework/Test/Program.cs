using MarsFramework.Global;
using MarsFramework.Pages;
using NUnit.Framework;
using SeleniumExtras.PageObjects;

namespace MarsFramework
{
    public class Program
    {
        [TestFixture]
        [Category("Sprint1")]
        class User : Global.Base
        {


            [Test]

            public void ProfileAvailabilityTimeTest_Saves()
            {
                var Profile = new Profile();
                PageFactory.InitElements(Global.GlobalDefinitions.driver, Profile);
                Profile.ProfileAvailabilityTime();
                       
            }

            [Test]
            public void ProfileAvailabilityHourTest_Saves()
            {
                var Profile = new Profile();
                PageFactory.InitElements(Global.GlobalDefinitions.driver, Profile);
                Profile.ProfileAvailabilityHour();

            }

            [Test]
            public void ProfileAvailabilitySalaryTest_Saves()
            {
                var Profile = new Profile();
                PageFactory.InitElements(Global.GlobalDefinitions.driver, Profile);
                Profile.ProfileAvailabilitySalary();

            }

            [Test]
            public void ProfileLanguageTest_Add()
            {

                var Profile = new Profile();
                PageFactory.InitElements(Global.GlobalDefinitions.driver, Profile);
                Profile.ProfileLanguageAdd();
            }

            [Test]
            public void ProfileLanguageTest_Cancel ()
            {

                var Profile = new Profile();
                PageFactory.InitElements(Global.GlobalDefinitions.driver, Profile);
                Profile.ProfileLanguageCancel();
            }

            [Test]
            public void ProfileLanguageTest_Update()
            {

                var Profile = new Profile();
                PageFactory.InitElements(Global.GlobalDefinitions.driver, Profile);
                Profile.ProfileLanguageUpdate();
            }

            [Test]
            public void ProfileLanguageTest_Delete()
            {

                var Profile = new Profile();
                PageFactory.InitElements(Global.GlobalDefinitions.driver, Profile);
                Profile.ProfileLanguageDelete();
            }

            [Test]
            public void ProfileSkillTest_Add()
            {

                var Profile = new Profile();
                PageFactory.InitElements(Global.GlobalDefinitions.driver, Profile);
                Profile.ProfileSkillsAdd();
            }

            [Test]
            public void ProfileSkillTest_Cancel()
            {

                var Profile = new Profile();
                PageFactory.InitElements(Global.GlobalDefinitions.driver, Profile);
                Profile.ProfileSkillsCancel();
            }

            [Test]
            public void ProfileSkillTest_Update()
            {

                var Profile = new Profile();
                PageFactory.InitElements(Global.GlobalDefinitions.driver, Profile);
                Profile.ProfileSkillsUpdate();
            }

            [Test]
            public void ProfileSkillTest_Delete()
            {

                var Profile = new Profile();
                PageFactory.InitElements(Global.GlobalDefinitions.driver, Profile);
                Profile.ProfileSkillsDelete();
            }


            [Test]
            public void ProfileEducationTest_Add()
            {

                var Profile = new Profile();
                PageFactory.InitElements(Global.GlobalDefinitions.driver, Profile);
                Profile.ProfileEducationAdd();
            }

            [Test]
            public void ProfileEducationTest_Cancel()
            {

                var Profile = new Profile();
                PageFactory.InitElements(Global.GlobalDefinitions.driver, Profile);
                Profile.ProfileEducationCancel();
            }

            [Test]
            public void ProfileEducationTest_Update()
            {

                var Profile = new Profile();
                PageFactory.InitElements(Global.GlobalDefinitions.driver, Profile);
                Profile.ProfileEducationUpdate();
            }

            [Test]
            public void ProfileEducationTest_Delete()
            {

                var Profile = new Profile();
                PageFactory.InitElements(Global.GlobalDefinitions.driver, Profile);
                Profile.ProfileEducationUpdate();
            }

            [Test]
            public void ProfileCertificationTest_Add()
            {

                var Profile = new Profile();
                PageFactory.InitElements(Global.GlobalDefinitions.driver, Profile);
                Profile.ProfileCertificationAdd();
            }

            [Test]
            public void ProfileCertificationTest_Cancel()
            {

                var Profile = new Profile();
                PageFactory.InitElements(Global.GlobalDefinitions.driver, Profile);
                Profile.ProfileCertificationAdd();
            }

            [Test]
            public void ProfileCertificationTest_Update()
            {

                var Profile = new Profile();
                PageFactory.InitElements(Global.GlobalDefinitions.driver, Profile);
                Profile.ProfileCertificationAdd();
            }

            [Test]
            public void ProfileCertificationTest_Delete()
            {

                var Profile = new Profile();
                PageFactory.InitElements(Global.GlobalDefinitions.driver, Profile);
                Profile.ProfileCertificationAdd();
            }

            [Test]
            public void ProfileDescriptionTest_Add()
            {

                var Profile = new Profile();
                PageFactory.InitElements(Global.GlobalDefinitions.driver, Profile);
                Profile.ProfileDescriptionAdd();
            }

            [Test]
            public void ProfileDescriptionTest_Update()
            {

                var Profile = new Profile();
                PageFactory.InitElements(Global.GlobalDefinitions.driver, Profile);
                Profile.ProfileDescriptionAdd();
            }

            [Test]
            public void ChangingPasswordTest()
            {

                var Profile = new Profile();
                PageFactory.InitElements(Global.GlobalDefinitions.driver, Profile);
                Profile.ChangingPassword();
            }

        }
    }
}