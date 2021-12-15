using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook.Domain.Entities
{
    public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Company { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Description { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public Contact()
        {

        }
        public Contact(string firstName, string lastName, string company, string phoneNumber, string description)
        {
            FirstName = firstName;
            LastName = lastName;
            Company = company;
            PhoneNumber = phoneNumber;
            Description = description;
            CreatedAt = DateTime.Now;
        }

        public void Update(string firstName, string lastName, string company, string phoneNumber, string description)
        {
            FirstName = firstName;
            LastName = lastName;
            Company = company;
            PhoneNumber = phoneNumber;
            Description = description;
        }
    }
}
