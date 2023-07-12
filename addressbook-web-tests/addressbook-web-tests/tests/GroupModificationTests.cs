using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupModificationTests : AuthTestBase
    {
        [Test]
        public void GroupModificationTest()
        {

            //new
            if (! app.Groups.GroupExists()) //  //группа не существует
            {
                GroupData group = new GroupData("");
                group.Header = "";
                group.Footer = "";

                app.Groups.Create(group);
            }

            
            GroupData newData = new GroupData("zzz");
            newData.Header = null;
            newData.Footer = null;

            app.Groups.Modify(1, newData);

        }
        
       

        
    }
}
