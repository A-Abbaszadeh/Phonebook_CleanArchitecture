using Phonebook.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook.Application.Services.AddNewContact
{
    public interface IAddNewContactService
    {
        ResultDto Execute(AddNewContactDto addNewContact);
    }
}