using Phonebook.Application.Dto;
using Phonebook.Application.Interfaces.Contexts;
using Phonebook.Domain.Entities;

namespace Phonebook.Application.Services.AddNewContact
{
    public class AddNewContactService : IAddNewContactService
    {
        private readonly IDatabaseContext _context;

        public AddNewContactService(IDatabaseContext context)
        {
            _context = context;

        }
        public ResultDto Execute(AddNewContactDto newContact)
        {
            if (string.IsNullOrEmpty(newContact.PhoneNumber))
            {
                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "شماره تلفن را وارد کنید"
                };
            }

            Contact contact = new Contact
                (
                newContact.FirstName, 
                newContact.LastName,
                newContact.Company, 
                newContact.PhoneNumber, 
                newContact.Description
                );

            _context.Contacts.Add(contact);
            _context.SaveChanges();

            return new ResultDto
            {
                IsSuccess = true,
                Message = $"{contact.FirstName} {contact.LastName} با موفقیت ثبت گردید"
            };
        }
    }
}
