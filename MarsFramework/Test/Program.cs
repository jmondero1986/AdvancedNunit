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

            public void Profile()
            {
                var Profile = new Profile();
                PageFactory.InitElements(Global.GlobalDefinitions.driver, Profile);
                Profile.ProfileAvail();
            
            }
                

             [Test]
            public void ShareSkill()
            {
                var ShareSkill = new ShareSkill();
                PageFactory.InitElements(Global.GlobalDefinitions.driver, ShareSkill);
                ShareSkill.EditShareSkill();
                

            }

            [Test]
            public void ManageListings()

            {
                var ManageListings = new ManageListings();
                PageFactory.InitElements(Global.GlobalDefinitions.driver, ManageListings);
                ManageListings.Listings();

            }


        }
    }
}