using Phonebook.Application.Dto;
using Phonebook.Application.Services.AddNewContact;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phonebook.Endpoint.Forms
{
    public partial class AddContactForm : Form
    {
        private readonly IAddNewContactService _addNewContactService;

        public AddContactForm(IAddNewContactService addNewContactService)
        {
            InitializeComponent();
            _addNewContactService = addNewContactService;
        }

        private void addContactButton_Click(object sender, EventArgs e)
        {
            var addNewContactResult = _addNewContactService.Execute(new AddNewContactDto
            {
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text,
                Company = companyTextBox.Text,
                PhoneNumber = phoneNumberTextBox.Text,
                Description = descriptionTextBox.Text,
            });

            if (addNewContactResult.IsSuccess)
            {
                MessageBox.Show(addNewContactResult.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(addNewContactResult.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
