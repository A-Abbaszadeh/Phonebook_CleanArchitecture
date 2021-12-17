using Phonebook.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook.Application.Services.GetContactDetail
{
    public interface IGetContactDetailService
    {
        ResultDto<GetContactDetailDto> Execute(int ContactId);
    }
}
