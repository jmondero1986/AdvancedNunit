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
                test = extent.StartTest("Availability Time");
                var Profile = new Profile();
                PageFactory.InitElements(Global.GlobalDefinitions.driver, Profile);
                Profile.ProfileAvailabilityTime();
                       
            }

            [Test]
            public void ProfileAvailabilityHourTest_Saves()
            {
                test = extent.StartTest("Availability Hour");
                var Profile = new Profile();
                PageFactory.InitElements(Global.GlobalDefinitions.driver, Profile);
                Profile.ProfileAvailabilityHour();

            }

            [Test]
            public void ProfileAvailabilitySalaryTest_Saves()
            {
                test = extent.StartTest("Availability Salary");
                var Profile = new Profile();
                PageFactory.InitElements(Global.GlobalDefinitions.driver, Profile);
                Profile.ProfileAvailabilitySalary();

            }

            [Test]
            public void ProfileLanguageTest_Add()
            {

                test = extent.StartTest("Adding New Language");
                var Profile = new Profile();
                PageFactory.InitElements(Global.GlobalDefinitions.driver, Profile);
                Profile.ProfileLanguageAdd();
            }

            [Test]
            public void ProfileLanguageTest_Cancel ()
            {
                test = extent.StartTest("Cancel Adding New Language");
                var Profile = new Profile();
                PageFactory.InitElements(Global.GlobalDefinitions.driver, Profile);
                Profile.ProfileLanguageCancel();
            }

            [Test]
            public void ProfileLanguageTest_Update()
            {
                test = extent.StartTest("Update Language");
                var Profile = new Profile();
                PageFactory.InitElements(Global.GlobalDefinitions.driver, Profile);
                Profile.ProfileLanguageUpdate();
            }

            [Test]
            public void ProfileLanguageTest_Update_Cancel()
            {
                test = extent.StartTest("Cancel Update Language");
                var Profile = new Profile();
                PageFactory.InitElements(Global.GlobalDefinitions.driver, Profile);
                Profile.ProfileLanguageUpdate_Cancel();
            }

            [Test]
            public void ProfileLanguageTest_Delete()
            {
                test = extent.StartTest("Delete Language");
                var Profile = new Profile();
                PageFactory.InitElements(Global.GlobalDefinitions.driver, Profile);
                Profile.ProfileLanguageDelete();
            }

            [Test]
            public void ProfileSkillTest_Add()
            {
                test = extent.StartTest("Adding Skills");
                var Profile = new Profile();
                PageFactory.InitElements(Global.GlobalDefinitions.driver, Profile);
                Profile.ProfileSkillsAdd();
            }

            [Test]
            public void ProfileSkillTest_Cancel()
            {
                test = extent.StartTest("Cancel Adding Skills");
                var Profile = new Profile();
                PageFactory.InitElements(Global.GlobalDefinitions.driver, Profile);
                Profile.ProfileSkillsCancel();
            }

            [Test]
            public void ProfileSkillTest_Update()
            {
                test = extent.StartTest("Update Skills");
                var Profile = new Profile();
                PageFactory.InitElements(Global.GlobalDefinitions.driver, Profile);
                Profile.ProfileSkillsUpdate();
            }

            [Test]
            public void ProfileSkillTest_Update_Cancel()
            {
                test = extent.StartTest("Cancel Updating Skills");
                var Profile = new Profile();
                PageFactory.InitElements(Global.GlobalDefinitions.driver, Profile);
                Profile.ProfileSkillsUpdate_Cancel();
            }

            [Test]
            public void ProfileSkillTest_Delete()
            {
                test = extent.StartTest("Delete Skills");
                var Profile = new Profile();
                PageFactory.InitElements(Global.GlobalDefinitions.driver, Profile);
                Profile.ProfileSkillsDelete();
            }


            [Test]
            public void ProfileEducationTest_Add()
            {
                test = extent.StartTest("Adding Education");
                var Profile = new Profile();
                PageFactory.InitElements(Global.GlobalDefinitions.driver, Profile);
                Profile.ProfileEducationAdd();
            }

            [Test]
            public void ProfileEducationTest_Cancel()
            {
                test = extent.StartTest("Cancel Adding Education");
                var Profile = new Profile();
                PageFactory.InitElements(Global.GlobalDefinitions.driver, Profile);
                Profile.ProfileEducationCancel();
            }

            [Test]
            public void ProfileEducationTest_Update()
            {
                test = extent.StartTest("Update Education");
                var Profile = new Profile();
                PageFactory.InitElements(Global.GlobalDefinitions.driver, Profile);
                Profile.ProfileEducationUpdate();
            }

            [Test]
            public void ProfileEducationTest_Update_Cancel()
            {
                test = extent.StartTest("Cancel Updating Education");
                var Profile = new Profile();
                PageFactory.InitElements(Global.GlobalDefinitions.driver, Profile);
                Profile.ProfileEducationUpdate_Cancel();
            }

            [Test]
            public void ProfileEducationTest_Delete()
            {
                test = extent.StartTest("Delete Education");
                var Profile = new Profile();
                PageFactory.InitElements(Global.GlobalDefinitions.driver, Profile);
                Profile.ProfileEducationDelete();
            }

            [Test]
            public void ProfileCertificationTest_Add()
            {
                test = extent.StartTest("Adding Certification");
                var Profile = new Profile();
                PageFactory.InitElements(Global.GlobalDefinitions.driver, Profile);
                Profile.ProfileCertificationAdd();
            }

            [Test]
            public void ProfileCertificationTest_Cancel()
            {
                test = extent.StartTest("Cancel Adding Certification");
                var Profile = new Profile();
                PageFactory.InitElements(Global.GlobalDefinitions.driver, Profile);
                Profile.ProfileCertificationCancel();
            }

            [Test]
            public void ProfileCertificationTest_Update()
            {
                test = extent.StartTest("Update Certification");
                var Profile = new Profile();
                PageFactory.InitElements(Global.GlobalDefinitions.driver, Profile);
                Profile.ProfileCertificationUpdate();
            }


            [Test]
            public void ProfileCertificationTest_Update_Cancel()
            {
                test = extent.StartTest("Cancel Update Certification");
                var Profile = new Profile();
                PageFactory.InitElements(Global.GlobalDefinitions.driver, Profile);
                Profile.ProfileCertificationUpdate_Cancel();
            }

            [Test]
            public void ProfileCertificationTest_Delete()
            {
                test = extent.StartTest("Delete Certification");
                var Profile = new Profile();
                PageFactory.InitElements(Global.GlobalDefinitions.driver, Profile);
                Profile.ProfileCertificationDelete();
            }

            [Test]
            public void ProfileDescriptionTest_Add()
            {
                test = extent.StartTest("Add Description");
                var Profile = new Profile();
                PageFactory.InitElements(Global.GlobalDefinitions.driver, Profile);
                Profile.ProfileDescriptionAdd();
            }

            [Test]
            public void ProfileDescriptionTest_Update()
            {
                test = extent.StartTest(" Update Certification");
                var Profile = new Profile();
                PageFactory.InitElements(Global.GlobalDefinitions.driver, Profile);
                Profile.ProfileDescriptionUpdate();
            }

            [Test]
            public void ChangingPasswordTest()
            {
                test = extent.StartTest("Change Password");
                var Profile = new Profile();
                PageFactory.InitElements(Global.GlobalDefinitions.driver, Profile);
                Profile.ChangingPassword();
            }

        }
    }
}