﻿using System;
using System.Collections.Generic;
using AddressBook;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Fellow Learners!\n--Welcome to Address Book Problem--");

            AddressBookSystem addressBookSystem = new AddressBookSystem();

            // Add a new Address Book using Console input
            Console.Write("Enter the name of the new Address Book: ");
            string newAddressBookName = Console.ReadLine()!;

            if (!string.IsNullOrEmpty(newAddressBookName))
            {
                if (!addressBookSystem.AddressBookExists(newAddressBookName))
                {
                    addressBookSystem.AddAddressBook(newAddressBookName);
                }
                else
                {
                    Console.WriteLine($"An Address Book with the name '{newAddressBookName}' already exists.");
                }
            }
            else
            {
                Console.WriteLine("Invalid Address Book name. Please provide a non-empty name.");
            }

            // Creating contacts and adding them to the Address Book
            AddressBook? addressBook = addressBookSystem.GetAddressBook(newAddressBookName);
            if (addressBook != null)
            {
                Contact newContact1 = new Contact(
                    firstName: "John",
                    lastName: "Doe",
                    address: "123 Main St",
                    city: "Cityville",
                    state: "Stateville",
                    zipCode: "12345",
                    phoneNumber: "123-456-7890",
                    email: "john.doe@example.com"
                );
                addressBook!.AddContact(newContact1);

                Contact newContact2 = new Contact(
                    firstName: "Jane",
                    lastName: "Smith",
                    address: "456 Elm St",
                    city: "Townville",
                    state: "Stateville",
                    zipCode: "67890",
                    phoneNumber: "987-654-3210",
                    email: "jane.smith@example.com"
                );
                addressBook!.AddContact(newContact2);
            }
            else
            {
                Console.WriteLine($"Address Book '{newAddressBookName}' not found.");
            }

            // Displaying all contacts in the address book
            DisplayAddressBook(addressBook);

            // Search contacts by city
            Console.Write("\nEnter a city to search for contacts: ");
            string searchCity = Console.ReadLine();
            List<Contact> citySearchResults = addressBookSystem.SearchContactsByCity(searchCity);
            DisplaySearchResultss(citySearchResults);

            // Search contacts by state
            Console.Write("\nEnter a state to search for contacts: ");
            string searchState = Console.ReadLine();
            List<Contact> stateSearchResults = addressBookSystem.SearchContactsByState(searchState);
            DisplaySearchResultss(stateSearchResults);

            Console.WriteLine("Thank you for using the Address Book program!");
        }

        static void DisplayAddressBook(AddressBook? addressBook)
        {
            if (addressBook == null)
            {
                Console.WriteLine("Address Book not found.");
                return;
            }

            Console.WriteLine($"\nAddress Book '{addressBook.Name}' Entries:");
            foreach (Contact contact in addressBook.GetContacts())
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

        static void DisplaySearchResultss(List<Contact> searchResults)
        {
            if (searchResults.Count > 0)
            {
                Console.WriteLine("\nSearch Results:");
                foreach (Contact contact in searchResults)
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
            else
            {
                Console.WriteLine("No matching contacts found.");
            }
        }
    }
}