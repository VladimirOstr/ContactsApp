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
    public partial class ContactForm : Form
    {
        private Contact _contact;
        private string _surnameError { get; set; }
        private string _nameError { get; set; }
        private string _dateOfBirthError { get; set; }

        private string _phoneNumberError { get; set; }

        private string _emailError { get; set; }

        private string _IdVKError { get; set; }

        public ContactForm()
        {
            InitializeComponent();
            _contact = new Contact("Иван", "Иванов",
                new PhoneNumber(71111111111),
                DateTime.Now, "ivanov@mail.ru", "121212");
            UpdateForm();
        }

        public Contact Contact
        {
            get
            {
                return _contact;
            }
            set
            {
                _contact = value;
            }
        }

        private void UpdateForm()
        {
            SurnameTextBox.Text = _contact.Surname;
            NameTextBox.Text = _contact.Name;
            BirthdayTimePicker.Value = _contact.DateOfBirth;
            PhoneTextBox.Text = _contact.PhoneNumber.Number.ToString();
            EmailTextBox.Text = _contact.Email;
            VkTextBox.Text = _contact.IdVK;
        }
        
        //Исправить закрытие окна
        //Закрыватся, даже если есть ошибка в данных
        private void OkButton_Click_1(object sender, EventArgs e)
        {
            if (CheckFromOnErrors())
            {
                Close();
            }
        }

        private void CancelButton_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void SurnameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.Surname = SurnameTextBox.Text;
                SurnameTextBox.BackColor = Color.White;
                _surnameError = string.Empty;
            }
            catch (ArgumentException exception)
            {
                SurnameTextBox.BackColor = Color.LightPink;
                _surnameError = exception.Message;
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.Name = NameTextBox.Text;
                NameTextBox.BackColor = Color.White;
                _nameError = string.Empty;
            }
            catch (ArgumentException exception)
            {
                NameTextBox.BackColor = Color.LightPink;
                _nameError = exception.Message;
            }
        }

        private void BirthdayTimePicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.DateOfBirth = BirthdayTimePicker.Value;
                BirthdayTimePicker.BackColor = Color.White;
                _dateOfBirthError = string.Empty;
            }
            catch (ArgumentException exception)
            {
                BirthdayTimePicker.BackColor = Color.LightPink;
                _dateOfBirthError = exception.Message;
            }
        }

        private void PhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.PhoneNumber.Number = long.Parse(PhoneTextBox.Text);
                PhoneTextBox.BackColor = Color.White;
                _phoneNumberError = string.Empty;
            }
            catch (ArgumentException exception)
            {
                
                PhoneTextBox.BackColor = Color.LightPink;
                _phoneNumberError = exception.Message;
            }
            catch(System.FormatException exception)
            {
                PhoneTextBox.BackColor = Color.LightPink;
                _phoneNumberError = exception.Message;
            }
        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.Email = EmailTextBox.Text;
                EmailTextBox.BackColor = Color.White;
                _emailError = string.Empty;
            }
            catch (ArgumentException exception)
            {
                EmailTextBox.BackColor = Color.LightPink;
                _emailError = exception.Message;
            }
        }

        private void VkTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.IdVK = VkTextBox.Text;
                VkTextBox.BackColor = Color.White;
                _IdVKError = string.Empty;
            }
            catch (ArgumentException exception)
            {
                VkTextBox.BackColor = Color.LightPink;
                _IdVKError = exception.Message;
            }
        }

        private bool CheckFromOnErrors()
        {
            if (_nameError != string.Empty)
            {
                MessageBox.Show(_nameError);
                return false;
            }
            if (_surnameError != string.Empty)
            {
                MessageBox.Show(_surnameError);
                return false;
            }
            if (_dateOfBirthError != string.Empty)
            {
                MessageBox.Show(_dateOfBirthError);
                return false;
            }
            if (_phoneNumberError != string.Empty)
            {
                MessageBox.Show(_phoneNumberError);
                return false;
            }
            if (_emailError != string.Empty)
            {
                MessageBox.Show(_emailError);
                return false;
            }
            if (_IdVKError != string.Empty)
            {
                MessageBox.Show(_IdVKError);
                return false;
            }
            return true;
        }

    }
}
