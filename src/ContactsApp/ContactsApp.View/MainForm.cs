using System;
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
        /// <summary>
        /// Проект контактов.
        /// </summary>
        private Project Project { get; set; }

        /// <summary>
        /// Текущие объекты в списке
        /// </summary>
        private List<Contact> currentContacts;

        /// <summary>
        /// Конструктор.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            Project = new Project();
            currentContacts = new List<Contact>(Project.SortBySurname());
            UpdateListBox();
        }

        /// <summary>
        /// Обновляет список контактов.
        /// </summary>
        private void UpdateListBox()
        {
            ContactsListBox.Items.Clear();
            currentContacts = currentContacts.OrderBy
            (contact => contact.Surname).ToList();
            foreach (var contact in currentContacts)
            {
                ContactsListBox.Items.Add(contact.Surname);
            }
        }

        /// <summary>
        /// Добавляет контакт.
        /// </summary>
        private void AddContact()
        {
            ContactForm contactForm = new ContactForm();
            contactForm.ShowDialog();
            if (contactForm.DialogResult == DialogResult.OK)
            {
                Project.Contacts.Add(contactForm.Contact);
                currentContacts.Add(contactForm.Contact);
            }
            ClearSelectedContact();
        }

        /// <summary>
        /// Редактирует контакт.
        /// </summary>
        /// <param name="index"></param>
        private void EditContact(int index)
        {
            if (index == -1 || ContactsListBox.Items.Count == 0)
            {
                return;
            }
            Contact editContact = currentContacts[index];
            ContactForm contactForm = new ContactForm();
            contactForm.Contact = (Contact)editContact.Clone();
            contactForm.ShowDialog();
            if (contactForm.DialogResult == DialogResult.OK)
            {
                ContactsListBox.Items.RemoveAt(index);

                int contactIndex = Project.Contacts.FindIndex(contact =>
                (contact.Surname == currentContacts[index].Surname &&
                contact.PhoneNumber.Number == currentContacts[index].PhoneNumber.Number));

                currentContacts.RemoveAt(index);
                currentContacts.Insert(index, contactForm.Contact);

                Project.Contacts.RemoveAt(contactIndex);
                Project.Contacts.Insert(contactIndex, contactForm.Contact);

                ContactsListBox.Items.Insert(index, contactForm.Contact.Surname);
            }
        }

        /// <summary>
        /// Удаляет контакт.
        /// </summary>
        /// <param name="index"></param>
        private void RemoveContact(int index)
        {
            if (index == -1 || ContactsListBox.Items.Count == 0)
            {
                return;
            }
            var result = MessageBox.Show($"Do you really want to remove " +
                $"{Project.Contacts[index].Surname}?",
                "Warning", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel)
            {
                return;
            }
            int contactIndex = Project.Contacts.FindIndex(contact =>
                (contact.Surname == currentContacts[index].Surname 
                && contact.PhoneNumber.Number == currentContacts[index].PhoneNumber.Number));

            currentContacts.RemoveAt(index);
            Project.Contacts.RemoveAt(contactIndex);
            SurnameTextBox.Text = "";
            NameTextBox.Text = "";
            BirthdayTimePicker.Value = DateTime.Now;
            PhoneTextBox.Text = "";
            EmailTextBox.Text = "";
            VkTextBox.Text = "";
            InfoGroupBox.Enabled = false;
        }

        /// <summary>
        /// Обновляет выбранный контакт.
        /// </summary>
        /// <param name="index"></param>
        private void UpdateSelectedContact(int index)
        {
            if (index == -1)
            {
                ClearSelectedContact();
                return;
            }

            Contact contact = currentContacts[index];
            SurnameTextBox.Text = contact.Surname;
            NameTextBox.Text = contact.Name;
            PhoneTextBox.Text = contact.PhoneNumber.Number.ToString();
            BirthdayTimePicker.Value = contact.DateOfBirth;
            VkTextBox.Text = contact.idVK;
            EmailTextBox.Text = contact.Email;
            InfoGroupBox.Enabled = true;
        }

        /// <summary>
        /// Очищает выбранный контакт.
        /// </summary>
        private void ClearSelectedContact()
        {
            SurnameTextBox.Text = String.Empty;
            NameTextBox.Text = String.Empty;
            PhoneTextBox.Text = String.Empty;
            BirthdayTimePicker.Value = new DateTime(1900, 01, 01);
            VkTextBox.Text = String.Empty;
            EmailTextBox.Text = String.Empty;
        }

        /// <summary>
        /// Действия для выбранного контакта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            UpdateSelectedContact(ContactsListBox.SelectedIndex);
        }

        /// <summary>
        /// Добавление контакта через кнопку.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddContactButton_Click(object sender, EventArgs e)
        {
            AddContact();
            UpdateListBox();
        }

        /// <summary>
        /// Редактирование контакта через кнопку.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditContactButton_Click(object sender, EventArgs e)
        {
            EditContact(ContactsListBox.SelectedIndex);
            UpdateListBox();
            UpdateSelectedContact(ContactsListBox.SelectedIndex);
        }

        /// <summary>
        /// Удаление контакта через кнопку.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveContactButton_Click(object sender, EventArgs e)
        {
            RemoveContact(ContactsListBox.SelectedIndex);
            UpdateListBox();
        }

        /// <summary>
        /// Выход через ToolStripMenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Добавление контакта через ToolStripMenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddContact();
            UpdateListBox();
        }

        /// <summary>
        /// Редактирование контакта через ToolStripMenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditContact(ContactsListBox.SelectedIndex);
            UpdateListBox();
            UpdateSelectedContact(ContactsListBox.SelectedIndex);
        }

        /// <summary>
        /// Удаление контакта через ToolStripMenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveContact(ContactsListBox.SelectedIndex);
            UpdateListBox();
        }

        /// <summary>
        /// Открытие окна About через ToolStripMenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }

        /// <summary>
        /// Добавление рандомного контакта через ToolStripMenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addRandomContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Project.Contacts.Add(ContactFactory.AddRandomContact());
            currentContacts.Add(Project.Contacts.Last());
            UpdateListBox();
        }

        /// <summary>
        /// Действия во время закрытия окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show
                ("Do you really want to exit?",
                "Exit",
                MessageBoxButtons.OKCancel);
            if (result != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            string text = FindTextBox.Text;
            currentContacts = Project.SearchBySurname(text);
            UpdateListBox();
        }
    }
}
