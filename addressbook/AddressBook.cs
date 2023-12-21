// AddressBook.cs
using System.Collections.Generic;

namespace AddressBook
{
    public partial class Contact
    {
        public class AddressBook
        {
            private List<Contact> contacts;

            public AddressBook()
            {
                contacts = new List<Contact>();
            }

            public void AddContact(Contact contact)
            {
                contacts.Add(contact);
            }

            public void ViewContacts()
            {
                if (contacts.Count == 0)
                {
                    System.Console.WriteLine("No contacts available.\n");
                }
                else
                {
                    foreach (Contact contact in contacts)
                    {
                        System.Console.WriteLine(contact);
                    }
                    System.Console.WriteLine();
                }
            }
        }
    }
}
