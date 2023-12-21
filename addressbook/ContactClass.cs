// Contact.cs
namespace AddressBook
{
    public partial class Contact : IContact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TelephoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public Contact(string firstName, string lastName, string telephoneNumber, string email, string address)
        {
            FirstName = firstName;
            LastName = lastName;
            TelephoneNumber = telephoneNumber;
            Email = email;
            Address = address;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} - {TelephoneNumber} - {Email} - {Address}";
        }
    }
}
