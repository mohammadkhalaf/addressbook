// Contact.cs
namespace AddressBook
{
    public interface IContact
    {
        string Address { get; set; }
        string Email { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string TelephoneNumber { get; set; }

        string ToString();
    }
}