using Phonebook.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook.Application.Services.EditContact
{
    public interface IEditContactService
    {
        ResultDto Execute(EditContactDto editContact);
    }
}
