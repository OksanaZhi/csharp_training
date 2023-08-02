using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    public class ContactData : IEquatable<ContactData>, IComparable<ContactData>
    {
        public string middlename = "";
        public string lastname;
        public string nickname = "";
        public string title = "";
        public string company = "";
        public string address = "";
        public string home = "";
        public string mobile = "";
        public string work = "";
        public string fax = "";
        public string email = "";
        public string email2 = "";
        public string email3 = "";
        public string homepage = "";
        public string address2 = "";
        public string phone2 = "";
        public string notes = "";
        public string allPhones;

        public ContactData(string firstname)
        { 
            Firstname = firstname;
        }

        public ContactData(string firstname, string lastName) : this(firstname)
        {
        }

        public string Firstname { get; set; }
        

        public bool Equals(ContactData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return false;
            }
            if (Object.ReferenceEquals(this, other))
            {
                return true;
            }

            return Firstname == other.Firstname;


        }

        public string Middlename { get; set; }
        
        public string Lastname { get; set; }
             
        public string Nickname { get; set; }
        
        public string Title { get; set; }
        
        public string Company { get; set; }
        
        public string Address { get; set; }
        
        public string HomePhone { get; set; }
        
        public string MobilePhone { get; set; }
        
        public string WorkPhone { get; set; }
        
        public string Fax { get; set; }
        
        public string Email { get; set; }
        
        public string Email2 { get; set; }
        
        public string Email3 { get; set; }
        
        public string Homepage { get; set; }
                
        public string Address2 { get; set; }
        
        public string Phone2 { get; set; }
        
        public string Notes { get; set; }
        
        public override int GetHashCode()
        {
            return Firstname.GetHashCode();
          
        }

        public override string ToString()
        {
            return "name=" +Lastname +" " + Firstname;// +" " + Firstname;
        }

        public int CompareTo(ContactData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return 1;
            }
            return Firstname.CompareTo(other.Firstname);
        }

        public string Id { get; set; }
        public string AllPhones
        {
            get
            {
                if (allPhones != null)
                {
                    return allPhones;

                }
                else
                {
                    return CleanUp(HomePhone) + CleanUp(MobilePhone) + CleanUp(WorkPhone).Trim();
                }
            }
            set 
            {
                allPhones = value;
            }
        }

        private string CleanUp(string phone)
        {
            if (phone == null || phone == "")
            {
                return "";
            }
            return phone.Replace(" ","").Replace("-","").Replace("(", "").Replace(")","") +"\r\n";
        }
    }

}
