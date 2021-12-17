using Phonebook.Application.Dto;
using Phonebook.Application.Interfaces.Contexts;

namespace Phonebook.Application.Services.EditContact
{
    public class EditContactService : IEditContactService
    {
        private readonly IDatabaseContext _context;

        public EditContactService(IDatabaseContext context)
        {
            _context = context;
        }
        public ResultDto Execute(EditContactDto editContact)
        {
            var contact = _context.Contacts.Find(editContact.Id);

            if (contact == null)
            {
                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "مخاطب مورد نظر یافت نشد"
                };
            }

            contact.Update(
               editContact.FirstName,
               editContact.LastName,
               editContact.Company,
               editContact.PhoneNumber,
               editContact.Description);

            _context.SaveChanges();

            return new ResultDto()
            {
                IsSuccess = true,
                Message = $"اطلاعات {contact.FirstName} {contact.LastName} با موفقیت به ویرایش شد."
            };
        }
    }
}
