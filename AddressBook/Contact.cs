using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Contact
    {
        public string FirstName { get; set;}
        public string LastName { get; set;}
        public string Email { get; set;}
        public string PhoneNumber { get; set;}
        public string Address { get; set;}
        public string City { get; set;}
        public string PostalCode { get; set;}
        public string Country { get; set;}

        public Contact(string firstname, string lastname,string email, string phonenumber,string address,string city ,string postalcode , string country)
        {
            FirstName = firstname; 
            LastName = lastname;
            Email = email;
            PhoneNumber = phonenumber; 
            Address = address;
            City = city;
            PostalCode = postalcode; 
            Country = country;

        }
    }
}
