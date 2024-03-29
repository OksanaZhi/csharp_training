﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactModificationTests : AuthTestBase
    {

        [Test]
        public void ContactModificationTest()
        {

            List<ContactData> oldContacts = app.Contacts.GetContactList();
            ContactData oldData = oldContacts[0];
            //new
            if (!app.Contacts.ContactExists()) //  контакт не существует
            {
                ContactData contact = new ContactData("Ivan");
                contact.Lastname = "Ivanov";
                contact.Middlename = "Ivanovich";
                app.Contacts.Create(contact);
            }

            //           

            ContactData newData = new ContactData("Alex");
            newData.Lastname = "Alexeev";
            newData.Middlename = "Alexeevich";
            
            app.Contacts.Modify(0, newData);

            Assert.AreEqual(oldContacts.Count, app.Contacts.GetContactCount());


            List<ContactData> newContacts = app.Contacts.GetContactList();
            oldContacts[0].Firstname = newData.Firstname;
            oldContacts[0].Lastname = newData.Lastname;
            oldContacts.Sort();
            newContacts.Sort();
            Assert.AreEqual(oldContacts, newContacts);

            foreach (ContactData contact in newContacts) 
            {
                if (contact.Id == oldData.Id) 
                {
                    Assert.AreEqual(newData.Firstname, contact.Firstname);
                    Assert.AreEqual(newData.Lastname, contact.Lastname);
                }
            }
        }
    }
}
