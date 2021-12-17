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
        public List<GetUserDto> Execute(string SearchKey = null)
        {
            var contactQuery = _context.Contacts.AsQueryable();

            if (!string.IsNullOrEmpty(SearchKey))
            {
                contactQuery = contactQuery.Where(
                    c =>
                    c.FirstName.Contains(SearchKey)
                    ||
                    c.LastName.Contains(SearchKey)
                    ||
                    c.PhoneNumber.Contains(SearchKey)
                    ||
                    c.Company.Contains(SearchKey)
                    );
            }

            var contacts = contactQuery.Select(c => new GetUserDto
            {
                Id = c.Id,
                FullName = $"{c.FirstName} {c.LastName}",
                PhoneNumber = c.PhoneNumber,
            }).ToList();

            return contacts;
        }
    }
}
