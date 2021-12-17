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
    public partial class ContactDetailForm : Form
    {
        private readonly IGetContactDetailService _getContactDetailService;
        private readonly int _contactId;

        public ContactDetailForm(IGetContactDetailService getContactDetailService,int contactId)
        {
            InitializeComponent();
            _getContactDetailService = getContactDetailService;
            _contactId = contactId;
        }

        private void ContactDetailForm_Load(object sender, EventArgs e)
        {
            var getContactDetailResult = _getContactDetailService.Execute(_contactId);

            if (getContactDetailResult.IsSuccess)
            {
                idLabel.Text = getContactDetailResult.Data.Id.ToString();
                firstNameLabel.Text = getContactDetailResult.Data.FirstName;
                lastNameLabel.Text = getContactDetailResult.Data.LastName;
                companyLabel.Text = getContactDetailResult.Data.Company;
                phoneNumberLabel.Text = getContactDetailResult.Data.PhoneNumber;
                createdAtLabel.Text = getContactDetailResult.Data.CreatedAt.ToString();
                descriptionTextBox.Text = getContactDetailResult.Data.Description;
            }
            else
            {
                MessageBox.Show(getContactDetailResult.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
