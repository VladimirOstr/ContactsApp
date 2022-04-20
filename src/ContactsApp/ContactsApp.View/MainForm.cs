using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsApp.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ContactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedItem;
                if (ContactsListBox.SelectedItem == null)
                {
                    throw new Exception();
                }
                selectedItem = ContactsListBox.SelectedItem.ToString();
                if (selectedItem == "Иван Иванов")
                {
                    SurnameTextBox.Text = "Иван";
                    NameTextBox.Text = "Иванов";
                    BirthdayTimePicker.Value = new DateTime(2001, 3, 7);
                    PhoneTextBox.Text = "+79185634152";
                    EmailTextBox.Text = "ivan.ivanov@mail.ru";
                    VkTextBox.Text = "id203534";
                    InfoGroupBox.Visible = true;
                    return;
                }
                SurnameTextBox.Text = "Петр";
                NameTextBox.Text = "Петров";
                BirthdayTimePicker.Value = new DateTime(1999, 8, 12);
                PhoneTextBox.Text = "+79195863276";
                EmailTextBox.Text = "petr.petrov@mail.ru";
                VkTextBox.Text = "id653404534";
                InfoGroupBox.Visible = true;
            }
            catch (Exception)
            {
             
            }
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            ContactsListBox.ScrollAlwaysVisible = true;
        }

        private void AddContactButton_Click(object sender, EventArgs e)
        {
            ContactForm addContactForm = new ContactForm();
            addContactForm.Show();
        }

        private void EditContactButton_Click(object sender, EventArgs e)
        {
            ContactForm editContactForm = new ContactForm();
            editContactForm.Show();
        }

        private void RemoveContactButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you really want to remove this contact?", 
                "Message",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContactForm contactForm = new ContactForm();
            contactForm.Show();
        }

        private void editContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContactForm contactForm = new ContactForm();
            contactForm.Show();
        }

        private void removeContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you really want to remove this contact?",
                "Message",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }
    }
}
