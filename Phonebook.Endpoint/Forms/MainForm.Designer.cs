namespace Phonebook.Endpoint.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.contactsGridView = new System.Windows.Forms.DataGridView();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.showAddContactFormButton = new System.Windows.Forms.Button();
            this.showContactDetailFormButton = new System.Windows.Forms.Button();
            this.showEditContactForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.contactsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // contactsGridView
            // 
            this.contactsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contactsGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.contactsGridView.Location = new System.Drawing.Point(0, 183);
            this.contactsGridView.Name = "contactsGridView";
            this.contactsGridView.RowHeadersWidth = 51;
            this.contactsGridView.RowTemplate.Height = 29;
            this.contactsGridView.Size = new System.Drawing.Size(485, 486);
            this.contactsGridView.TabIndex = 0;
            this.contactsGridView.DoubleClick += new System.EventHandler(this.contactsGridView_DoubleClick);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(169, 18);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(304, 30);
            this.searchTextBox.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(12, 12);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(133, 40);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "جستجو";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(12, 125);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(147, 40);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "حذف";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // showAddContactFormButton
            // 
            this.showAddContactFormButton.Location = new System.Drawing.Point(12, 68);
            this.showAddContactFormButton.Name = "showAddContactFormButton";
            this.showAddContactFormButton.Size = new System.Drawing.Size(461, 40);
            this.showAddContactFormButton.TabIndex = 4;
            this.showAddContactFormButton.Text = "مخاطب جدید...";
            this.showAddContactFormButton.UseVisualStyleBackColor = true;
            this.showAddContactFormButton.Click += new System.EventHandler(this.showAddContactFormButton_Click);
            // 
            // showContactDetailFormButton
            // 
            this.showContactDetailFormButton.Location = new System.Drawing.Point(326, 125);
            this.showContactDetailFormButton.Name = "showContactDetailFormButton";
            this.showContactDetailFormButton.Size = new System.Drawing.Size(147, 40);
            this.showContactDetailFormButton.TabIndex = 5;
            this.showContactDetailFormButton.Text = "نمایش جزئیات";
            this.showContactDetailFormButton.UseVisualStyleBackColor = true;
            this.showContactDetailFormButton.Click += new System.EventHandler(this.showContactDetailFormButton_Click);
            // 
            // showEditContactForm
            // 
            this.showEditContactForm.Location = new System.Drawing.Point(169, 125);
            this.showEditContactForm.Name = "showEditContactForm";
            this.showEditContactForm.Size = new System.Drawing.Size(147, 40);
            this.showEditContactForm.TabIndex = 6;
            this.showEditContactForm.Text = "ویرایش مخاطب";
            this.showEditContactForm.UseVisualStyleBackColor = true;
            this.showEditContactForm.Click += new System.EventHandler(this.showEditContactForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 669);
            this.Controls.Add(this.showEditContactForm);
            this.Controls.Add(this.showContactDetailFormButton);
            this.Controls.Add(this.showAddContactFormButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.contactsGridView);
            this.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت مخاطبین";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contactsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView contactsGridView;
        private TextBox searchTextBox;
        private Button searchButton;
        private Button deleteButton;
        private Button showAddContactFormButton;
        private Button showContactDetailFormButton;
        private Button showEditContactForm;
    }
}