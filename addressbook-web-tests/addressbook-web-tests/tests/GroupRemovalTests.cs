using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupRemovalTests : AuthTestBase
    {
       
        [Test]
        public void GroupRemovalTest()
        {
            //new
            if (!app.Groups.GroupExists()) //  //группа не существует
            {
                GroupData group = new GroupData("x");
                group.Header = "x";
                group.Footer = "x";

                app.Groups.Create(group);
            }


            
            app.Groups.Remove(1);
            
        }
                  
                      
                           
    }
}
