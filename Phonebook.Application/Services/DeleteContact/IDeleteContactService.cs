using Phonebook.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook.Application.Services.DeleteContact
{
    public interface IDeleteContactService
    {
        ResultDto Execute(int ContactId);
    }
}

