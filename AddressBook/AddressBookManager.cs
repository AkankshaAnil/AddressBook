﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class AddressBookManager
    {
        private List<Contact> addressBook;

        public AddressBookManager()
        {
            addressBook = new List<Contact>();
        }

        public void AddContact(Contact contact)
        {
            addressBook.Add(contact);
        }

        public List<Contact> GetAddressBook()
        {
            return addressBook;
        }

        public Contact? GetContactByName(string firstName, string lastName)
        {
            return addressBook.FirstOrDefault(c => c.FirstName == firstName && c.LastName == lastName);
        }
    }

}
