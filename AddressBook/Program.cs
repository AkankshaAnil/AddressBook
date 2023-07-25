using System;
using System.Collections.Generic;

namespace AddressBook
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello Fellow Learners!\n--Welcome to Address Book Problem--");

            AddressBookManager addressBookManager = new AddressBookManager();

            // Creating a new Contact and adding it to the Address Book
            Contact newContact = new Contact("Snooki", "FF", "801 Zen Estate", "Pune", "MH", "345678", "234-678-2229", "snooki.ff@gmail.com");
            addressBookManager.AddContact(newContact);

            // Displaying all contacts in the address book
            DisplayAddressBook(addressBookManager);

            Console.WriteLine("Thank you for using the Address Book program!");
        }

        static void DisplayAddressBook(AddressBookManager addressBookManager)
        {
            var addressBook = addressBookManager.GetAddressBook();

            Console.WriteLine("\nAddress Book Entries:");
            foreach (Contact contact in addressBook)
            {
                Console.WriteLine($"Name: {contact.FirstName} {contact.LastName}");
                Console.WriteLine($"Address: {contact.Address}");
                Console.WriteLine($"City: {contact.City}");
                Console.WriteLine($"State: {contact.State}");
                Console.WriteLine($"Zip Code: {contact.ZipCode}");
                Console.WriteLine($"Phone: {contact.PhoneNumber}");
                Console.WriteLine($"Email: {contact.Email}");
                Console.WriteLine();
            }
        }
    }
}

