using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {
                     
        [Test]
        
        public new void ContactCreationTest()
        {
            GoToHomePage();
            Login(new AccountData("admin", "secret"));
            InitNewContactCreation();
            ContactData contact = new ContactData("Ivan");
            contact.Lastname = "Ivanov";
            contact.Middlename = "Ivanovich";
            FillContactForm(contact);
            SubmitContactCreation();
            ReturnToHomePage();
            Logout();
            

        }

    }
}

