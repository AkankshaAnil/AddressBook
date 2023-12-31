﻿using System;
using System.Collections.Generic;

namespace AddressBook
{
    class AddressBookSystem
    {
        private Dictionary<string, AddressBook> addressBooks;

        public AddressBookSystem()
        {
            addressBooks = new Dictionary<string, AddressBook>();
        }

        public void AddAddressBook(string name)
        {
            if (!addressBooks.ContainsKey(name))
            {
                AddressBook addressBook = new AddressBook(name);
                addressBooks.Add(name, addressBook);
                Console.WriteLine($"Address Book '{name}' created successfully!");
            }
            else
            {
                Console.WriteLine($"An Address Book with the name '{name}' already exists.");
            }
        }
        public List<Contact> SearchContactsByCity(string city)
        {
            List<Contact> searchResults = new List<Contact>();

            foreach (AddressBook addressBook in addressBooks.Values)
            {
                searchResults.AddRange(addressBook.SearchByCity(city));
            }

            return searchResults;
        }

        public List<Contact> SearchContactsByState(string state)
        {
            List<Contact> searchResults = new List<Contact>();

            foreach (AddressBook addressBook in addressBooks.Values)
            {
                searchResults.AddRange(addressBook.SearchByState(state));
            }

            return searchResults;
        }

        public bool AddressBookExists(string name)
        {
            return addressBooks.ContainsKey(name);
        }

        public AddressBook GetAddressBook(string name)
        {
            return addressBooks[name];
        }

        public List<string> GetAddressBookNames()
        {
            return new List<string>(addressBooks.Keys);
        }
    }
}