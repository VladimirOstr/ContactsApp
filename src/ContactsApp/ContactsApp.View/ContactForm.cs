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
        /// <summary>
        /// Текст ошибки.
        /// </summary>
        private string errorText = "";

        /// <summary>
        /// Цвет TextBox при вводе корректных данных.
        /// </summary>
        private Color _сorrectDataColor = Color.White;

        /// <summary>
        /// Цвет TextBox при вводе некорректных данных.
        /// </summary>
        private Color _incorrectDataColor = Color.LightPink;
        
        /// <summary>
        /// Контакт.
        /// </summary>
        private Contact _contact;

        /// <summary>
        /// Ошибка в фамилии.
        /// </summary>
        private string _surnameError { get; set; }

        /// <summary>
        /// Ошибка в имени.
        /// </summary>
        private string _nameError { get; set; }

        /// <summary>
        /// Ошибка в дате рождения.
        /// </summary>
        private string _dateOfBirthError { get; set; }

        /// <summary>
        /// Ошибка в номере телефона.
        /// </summary>
        private string _phoneNumberError { get; set; }

        /// <summary>
        /// Ошибка в email.
        /// </summary>
        private string _emailError { get; set; }

        /// <summary>
        /// Ошибка в id VK.
        /// </summary>
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

        /// <summary>
        /// Конструктор поля контакт.
        /// </summary>
        public Contact Contact
        {
            get
            {
                return _contact;
            }
            set
            {
                _contact = value;
                UpdateForm();
            }
        }

        /// <summary>
        /// Обновление формы.
        /// </summary>
        private void UpdateForm()
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
            DialogResult = DialogResult.Cancel;
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
                SurnameTextBox.BackColor = _сorrectDataColor;
                _surnameError = string.Empty;
            }
            catch (ArgumentException exception)
            {
                SurnameTextBox.BackColor = _incorrectDataColor;
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
                NameTextBox.BackColor = _сorrectDataColor;
                _nameError = string.Empty;
            }
            catch (ArgumentException exception)
            {
                NameTextBox.BackColor = _incorrectDataColor;
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
                BirthdayTimePicker.BackColor = _сorrectDataColor;
                _dateOfBirthError = string.Empty;
            }
            catch (ArgumentException exception)
            {
                BirthdayTimePicker.BackColor = _incorrectDataColor;
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
                PhoneTextBox.BackColor = _сorrectDataColor;
                _phoneNumberError = string.Empty;
            }
            catch (ArgumentException exception)
            {
                
                PhoneTextBox.BackColor = _incorrectDataColor;
                _phoneNumberError = exception.Message;
            }
            catch(System.FormatException exception)
            {
                PhoneTextBox.BackColor = _incorrectDataColor;
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
                EmailTextBox.BackColor = _сorrectDataColor;
                _emailError = string.Empty;
            }
            catch (ArgumentException exception)
            {
                EmailTextBox.BackColor = _incorrectDataColor;
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
                VkTextBox.BackColor = _сorrectDataColor;
                _idVKError = string.Empty;
            }
            catch (ArgumentException exception)
            {
                VkTextBox.BackColor = _incorrectDataColor;
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
                //MessageBox.Show(_nameError);
                errorText += _nameError;
                //return false;
            }
            if (_surnameError != string.Empty)
            {
                //MessageBox.Show(_surnameError);
                errorText += _surnameError;
                //return false;
            }
            if (_dateOfBirthError != string.Empty)
            {
                //MessageBox.Show(_dateOfBirthError);
                errorText += _dateOfBirthError;
                //return false;
            }
            if (_phoneNumberError != string.Empty)
            {
                //MessageBox.Show(_phoneNumberError);
                errorText += _phoneNumberError;
                //return false;
            }
            if (_emailError != string.Empty)
            {
                //MessageBox.Show(_emailError);
                errorText += _emailError;
                //return false;
            }
            if (_idVKError != string.Empty)
            {
                //MessageBox.Show(_idVKError);
                errorText += _idVKError;
                //return false;
            }
            if (errorText != string.Empty)
            {
                MessageBox.Show(errorText, "Warning",
                MessageBoxButtons.OKCancel);
                return false;
            }
            return true;
        }

    }
}
