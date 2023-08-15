using OpenQA.Selenium.DevTools.V112.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using LinqToDB;
using NUnit.Framework;

namespace WebAddressbookTests
{
    public class AddressBookDB : LinqToDB.Data.DataConnection
    {
        public AddressBookDB() : base("AddressBook") { }

        public ITable<GroupData> Groups { get { return GetTable<GroupData>(); } }

        public ITable<ContactData> Contacts { get { return GetTable<ContactData>(); } }

        public ITable<GroupContactRelation> GCR { get { return GetTable<GroupContactRelation>(); } }


    }
}
