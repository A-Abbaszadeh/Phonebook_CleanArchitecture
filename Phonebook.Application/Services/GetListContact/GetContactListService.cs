using Phonebook.Application.Dto;
using Phonebook.Application.Interfaces.Contexts;

namespace Phonebook.Application.Services.GetListContact
{
    public class GetContactListService : IGetContactListService
    {
        private readonly IDatabaseContext _context;
        public GetContactListService(IDatabaseContext context)
        {
            _context = context;
        }
        public List<GetUserDto> Execute()
        {
            var contacts = _context.Contacts.Select(c => new GetUserDto
            {
                Id = c.Id,
                FullName = $"{c.FirstName} {c.LastName}",
                PhoneNumber = c.PhoneNumber,
            }).ToList();

            return contacts;
        }
    }
}
