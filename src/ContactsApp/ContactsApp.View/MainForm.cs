﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp.Model;

namespace ContactsApp.View
{
    public partial class MainForm : Form
    {
        private Project _project = new Project();

        private void UpdateListBox()
        {
            ContactsListBox.Items.Clear();
            foreach (var contact in _project.Contacts)
            {
                ContactsListBox.Items.Add(contact.Surname);
            }
        }

        private void AddContact()
        {
            var randomNames = new List<string>
            {
                "Иван", "Петр", "Владимир", "Никита"
            };
            var randomSurnames = new List<string>
            {
                "Петров", "Иванов", "Путин", "Зайка"
            };
            var randomEmails = new List<string>
            {
                "petrov@mail.ru", "ivanov@mail.ru", "pop@mail.ru",
                "pap@mail.ru"
            };
            Random random = new Random();
            Contact contact = new Contact(
                randomNames[random.Next(randomNames.Count)],
                randomSurnames[random.Next(randomSurnames.Count)],
                new PhoneNumber(79138040329),
                new DateTime(random.Next(1900,2022),
                random.Next(1,12), random.Next(1,28)),
                randomEmails[random.Next(randomEmails.Count)],
                new Random().Next().ToString());
            _project.Contacts.Add(contact);
        }

        private void RemoveContact(int index)
        {
            if (index == -1 || ContactsListBox.Items.Count == 0)
            {
                return;
            }
            var result = MessageBox.Show($"Do you really want to remove " +
                $"{_project.Contacts[index].Surname}?",
                "Warning", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel)
            {
                return;
            }
            _project.Contacts.RemoveAt(index);
        }

        private void UpdateSelectedContact(int index)
        {
            if (index == -1)
            {
                ClearSelectedContact();
                return;
            }

            var contact = _project.Contacts[index];
            SurnameTextBox.Text = contact.Surname;
            NameTextBox.Text = contact.Name;
            PhoneTextBox.Text = contact.PhoneNumber.Number.ToString();
            BirthdayTimePicker.Value = contact.DateOfBirth;
            VkTextBox.Text = contact.IdVK;
            EmailTextBox.Text = contact.Email;
            InfoGroupBox.Visible = true;
        }

        private void ClearSelectedContact()
        {
            SurnameTextBox.Text = String.Empty;
            NameTextBox.Text = String.Empty;
            PhoneTextBox.Text = String.Empty;
            BirthdayTimePicker.Value = new DateTime(1900,01,01);
            VkTextBox.Text = String.Empty;
            EmailTextBox.Text = String.Empty;
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void ContactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            UpdateSelectedContact(ContactsListBox.SelectedIndex);
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            ContactsListBox.ScrollAlwaysVisible = true;
        }

        private void AddContactButton_Click(object sender, EventArgs e)
        {
            AddContact();
            UpdateListBox();
        }

        private void EditContactButton_Click(object sender, EventArgs e)
        {
            
        }

        private void RemoveContactButton_Click(object sender, EventArgs e)
        {
            RemoveContact(ContactsListBox.SelectedIndex);
            UpdateListBox();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure want to exit?", 
                "Warning", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel)
            {
                return;
            }
            Application.Exit();
        }

        private void addContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddContact();
            UpdateListBox();
        }

        private void editContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void removeContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveContact(ContactsListBox.SelectedIndex);
            UpdateListBox();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }
    }
}
