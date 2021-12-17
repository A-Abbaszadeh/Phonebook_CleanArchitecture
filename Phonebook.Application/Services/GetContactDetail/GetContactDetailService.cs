using Phonebook.Application.Dto;
using Phonebook.Application.Interfaces.Contexts;

namespace Phonebook.Application.Services.GetContactDetail
{
    public class GetContactDetailService : IGetContactDetailService
    {
        private readonly IDatabaseContext _context;

        public GetContactDetailService(IDatabaseContext context)
        {
            _context = context;
        }
        public ResultDto<GetContactDetailDto> Execute(int ContactId)
        {
            var contact = _context.Contacts.Find(ContactId);

            if (contact == null)
            {
                return new ResultDto<GetContactDetailDto>()
                {
                    Data = null,
                    IsSuccess = false,
                    Message = "خاطب مورد نظر یافت نشد"
                };
            }

            return new ResultDto<GetContactDetailDto>()
            {
                Data = new GetContactDetailDto()
                {
                    Id = contact.Id,
                    FirstName = contact.FirstName,
                    LastName = contact.LastName,
                    Company = contact.Company,
                    PhoneNumber = contact.PhoneNumber,
                    CreatedAt = contact.CreatedAt,
                    Description = contact.Description,
                },
                IsSuccess = true,
            };
        }
    }
}
