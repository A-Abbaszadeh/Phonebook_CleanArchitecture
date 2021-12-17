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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;


            //contactsGridView.Columns[0].HeaderText = "شناسه";
            //contactsGridView.Columns[1].HeaderText = "نام و نام خانوادگی";
            //contactsGridView.Columns[2].HeaderText = "شماره تماس";

            //contactsGridView.Columns[0].Width = 80;
            //contactsGridView.Columns[1].Width = 200;
            //contactsGridView.Columns[2].Width = 150;

            this.Cursor = Cursors.Default;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;


            this.Cursor = Cursors.Default;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //int Id = int.Parse(contactsGridView.CurrentRow.Cells[0].Value.ToString());

        }

        private void showAddContactFormButton_Click(object sender, EventArgs e)
        {
            var addNewContactService = (IAddNewContactService) Program.ServiceProvider.GetService(typeof(IAddNewContactService));
            AddContactForm addContactForm = new AddContactForm(addNewContactService);
            addContactForm.ShowDialog();
            MainForm_Load(null, null);
        }

        private void showContactDetailFormButton_Click(object sender, EventArgs e)
        {
            ShowContactDetail();
        }


        private void contactsGridView_DoubleClick(object sender, EventArgs e)
        {
            ShowContactDetail();
        }

        private void ShowContactDetail()
        {
            //int Id = int.Parse(contactsGridView.CurrentRow.Cells[0].Value.ToString());

        }

        private void showEditContactForm_Click(object sender, EventArgs e)
        {
            //int id = int.Parse(contactsGridView.CurrentRow.Cells[0].Value.ToString());

            MainForm_Load(null, null);
        }
    }
}
