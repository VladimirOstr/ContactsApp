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

        private void FileButton_Click(object sender, EventArgs e)
        {
            FileContextMenuStrip.Show(FileButton, new Point(0, FileButton.Height));
        }

        private void ContactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = ContactsListBox.SelectedItem.ToString();
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

        private void EditButton_Click(object sender, EventArgs e)
        {
            EditContextMenuStrip.Show(EditButton, new Point(0, EditButton.Height));
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {

            HelpContextMenuStrip.Show(HelpButton, new Point(0, HelpButton.Height));
        }

        private void AddPictureBox_Click(object sender, EventArgs e)
        {
            ContactForm contactForm = new ContactForm();
            contactForm.Show();
        }

        private void EditPictureBox_Click(object sender, EventArgs e)
        {
            ContactForm contactForm = new ContactForm();
            contactForm.Show();
        }

        private void RemovePictureBox_Click(object sender, EventArgs e)
        {
           
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
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

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
