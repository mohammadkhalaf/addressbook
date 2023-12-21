// Program.cs
using AddressBook;
using System;

namespace AddressBook
{
    class Program
    {
        static void Main()
        {
            // Create an instance of the AddressBook class
            Contact.AddressBook addressBook = new Contact.AddressBook();

            // Menu loop
            while (true)
            {
                Console.WriteLine("Address Book Menu:");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. View Contacts");
                Console.WriteLine("3. Exit");

                // Get user choice
                Console.Write("Enter your choice (1-3): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        // Add contact
                        Console.Write("Enter the first name: ");
                        string firstName = ReadNonEmptyString();
                        Console.Write("Enter the last name: ");
                        string lastName = ReadNonEmptyString();
                        Console.Write("Enter the telephone number: ");
                        string telephoneNumber = ReadNonEmptyString();
                        Console.Write("Enter the email address: ");
                        string email = ReadNonEmptyString();
                        Console.Write("Enter the address: ");
                        string address = Console.ReadLine();

                        // Create a new contact and add it to the address book
                        Contact newContact = new Contact(firstName, lastName, telephoneNumber, email, address);
                        addressBook.AddContact(newContact);
                        Console.WriteLine("Contact added successfully!\n");
                        break;

                    case "2":
                        // View contacts
                        Console.WriteLine("Contacts in the address book:");
                        addressBook.ViewContacts();
                        break;

                    case "3":
                        // Exit the program
                        Console.WriteLine("Exiting the address book. Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.\n");
                        break;
                }
            }
        }

        static string ReadNonEmptyString()
        {
            string input;
            do
            {
               
                input = Console.ReadLine();
            } while (string.IsNullOrEmpty(input.Trim()));

            return input;
        }
    }
}
