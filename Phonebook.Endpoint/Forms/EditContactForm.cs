using Phonebook.Application.Dto;
using Phonebook.Application.Services.EditContact;
using Phonebook.Application.Services.GetContactDetail;
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
    public partial class EditContactForm : Form
    {
        private readonly IGetContactDetailService _getContactDetailService;
        private readonly IEditContactService _editContactService;
        private readonly int _contactId;

        public EditContactForm(IGetContactDetailService getContactDetailService, IEditContactService editContactService, int contactId)
        {
            InitializeComponent();
            _getContactDetailService = getContactDetailService;
            _editContactService = editContactService;
            _contactId = contactId;
        }

        private void EditContactForm_Load(object sender, EventArgs e)
        {
            var getContactDetailResult = _getContactDetailService.Execute(_contactId);

            if (getContactDetailResult.IsSuccess)
            {
                firstNameTextBox.Text = getContactDetailResult.Data.FirstName;
                lastNameTextBox.Text = getContactDetailResult.Data.LastName;
                companyTextBox.Text = getContactDetailResult.Data.Company;
                phoneNumberTextBox.Text = getContactDetailResult.Data.PhoneNumber;
                descriptionTextBox.Text = getContactDetailResult.Data.Description;
            }
            else
            {
                MessageBox.Show(getContactDetailResult.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void editContactButton_Click(object sender, EventArgs e)
        {
            var editContactResult = _editContactService.Execute(new EditContactDto
            {
                Id = _contactId,
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text,
                Company = companyTextBox.Text,
                PhoneNumber = phoneNumberTextBox.Text,
                Description = descriptionTextBox.Text
            });

            if (editContactResult.IsSuccess)
            {
                MessageBox.Show(editContactResult.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            } else
            {
                MessageBox.Show(editContactResult.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
