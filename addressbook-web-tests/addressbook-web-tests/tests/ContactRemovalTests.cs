using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactRemovalTests : AuthTestBase
    {
        

            [Test]
            public void ContactRemovalTest()
            {
                if (!app.Contacts.ContactExists()) //  контакт не существует
                {
                    ContactData contact = new ContactData("Ivan");
                    contact.Lastname = "Ivanov";
                    contact.Middlename = "Ivanovich";
                    app.Contacts.Create(contact);
                }

                app.Contacts.Remove(1);

            }
        }
}
