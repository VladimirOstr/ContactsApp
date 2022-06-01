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

        private string _idVKError { get; set; }

        /// <summary>
        /// Конструктор.
        /// </summary>
        public ContactForm()
        {
            InitializeComponent();
            _contact = new Contact(" ", " ",
                new PhoneNumber(7),
                DateTime.Now, " ", " ");
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

        /// <summary>
        /// Обновление формы.
        /// </summary>
        public void UpdateForm()
        {
            SurnameTextBox.Text = _contact.Surname;
            NameTextBox.Text = _contact.Name;
            BirthdayTimePicker.Value = _contact.DateOfBirth;
            PhoneTextBox.Text = _contact.PhoneNumber.Number.ToString();
            EmailTextBox.Text = _contact.Email;
            VkTextBox.Text = _contact.idVK;
        }
        
      
        /// <summary>
        /// Действие для кнопки ОК.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OkButton_Click_1(object sender, EventArgs e)
        {
            if (CheckFromOnErrors())
            {
                Close();
                return;
            }
            DialogResult = DialogResult.None;
        }

        /// <summary>
        /// Действие для кнопки Cancel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Действие при изменении поля Surname
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Действие при изменении поля Name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Действие при изменении поля Birthday
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Действие при изменении поля PhoneNumber
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Действие при изменении поля Email
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Действие при изменении поля VK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VkTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.idVK = VkTextBox.Text;
                VkTextBox.BackColor = Color.White;
                _idVKError = string.Empty;
            }
            catch (ArgumentException exception)
            {
                VkTextBox.BackColor = Color.LightPink;
                _idVKError = exception.Message;
            }
        }

        /// <summary>
        /// Проверка на корректность ввода
        /// </summary>
        /// <returns></returns>
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
            if (_idVKError != string.Empty)
            {
                MessageBox.Show(_idVKError);
                return false;
            }
            return true;
        }

    }
}
