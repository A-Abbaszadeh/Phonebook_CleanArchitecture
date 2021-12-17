using Phonebook.Application.Dto;
using Phonebook.Application.Interfaces.Contexts;

namespace Phonebook.Application.Services.DeleteContact
{
    public class DeleteContactService : IDeleteContactService
    {
        private readonly IDatabaseContext _context;

        public DeleteContactService(IDatabaseContext context)
        {
            _context = context;
        }
        public ResultDto Execute(int ContactId)
        {
            var contact = _context.Contacts.Find(ContactId);
            if (contact != null)
            {
                _context.Remove(contact);
                _context.SaveChanges();
                return new ResultDto
                {
                    IsSuccess = true,
                    Message = $"{contact.FirstName} {contact.LastName} با موفقیت از لیست مخاطبین حذف گردید."
                };
            }

            return new ResultDto
            {
                IsSuccess = false,
                Message = "مخاطب مورد نظر یافت نشد"
            };
        }
    }
}

