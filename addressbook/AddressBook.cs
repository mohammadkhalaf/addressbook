// AddressBook.cs
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace AddressBook
{
    public partial class Contact
    {
        public class AddressBook
        {
            private List<Contact> contacts;
            private string jsonFilePath;

            public AddressBook()
            {
              
                jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "contacts.json");

                LoadContactsFromJson();
            }

            public void AddContact(Contact contact)
            {
                contacts.Add(contact);

                // Save contacts to a JSON file after adding a new contact
                SaveContactsToJson();
            }

            public void ViewContacts()
            {
                if (contacts.Count == 0)
                {
                    Console.WriteLine("No contacts available.\n");
                }
                else
                {
                    
                    Console.WriteLine("No.   | First Name   | Last Name    | Telephone     | Email                 | Address");
                    Console.WriteLine("------+--------------+--------------+----------------+-----------------------+-----------------------");

                    
                    for (int i = 0; i < contacts.Count; i++)
                    {
                        Contact contact = contacts[i];
                        Console.WriteLine($"{i + 1,-5}| {contact.FirstName,-13}| {contact.LastName,-13}| {contact.TelephoneNumber,-15}| {contact.Email,-23}| {contact.Address}");
                    }
                    Console.WriteLine();
                }
            }


            public void SaveContactsToJson()
            {
     
                string json = JsonSerializer.Serialize(contacts, new JsonSerializerOptions { WriteIndented = true });

                File.WriteAllText(jsonFilePath, json);
            }

            private void LoadContactsFromJson()
            {
                
                if (File.Exists(jsonFilePath))
                {
                    string json = File.ReadAllText(jsonFilePath);
                    contacts = JsonSerializer.Deserialize<List<Contact>>(json);
                }
                else
                {
                    contacts = new List<Contact>();
                }
            }
        }
    }
}
