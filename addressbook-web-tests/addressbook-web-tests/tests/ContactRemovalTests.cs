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
            List<ContactData> oldContacts = app.Contacts.GetContactList();

                 if (!app.Contacts.ContactExists()) //  контакт не существует
                {
                    ContactData contact = new ContactData("Ivan");
                    contact.Lastname = "Ivanov";
                    contact.Middlename = "Ivanovich";
                    app.Contacts.Create(contact);
                }

                app.Contacts.Remove(0);

            Assert.AreEqual(oldContacts.Count - 1, app.Contacts.GetContactCount());


            List<ContactData> newContacts = app.Contacts.GetContactList();

            ContactData toBeRemoved = oldContacts[0];
            oldContacts.RemoveAt(0);
            Assert.AreEqual(oldContacts, newContacts);

            foreach (ContactData contact in newContacts) 
            {
                Assert.AreNotEqual(contact.Id, oldContacts[0].Id);
            }


        }
        }
}
