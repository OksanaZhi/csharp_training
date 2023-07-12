using System;
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
            
            app.Contacts.Modify(1, newData);

        }
    }
}
