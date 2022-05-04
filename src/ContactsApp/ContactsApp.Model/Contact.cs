using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.Model
{
    class Contact : ICloneable
    {
        /// <summary>
        /// Фамилия.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Имя.
        /// </summary>
        private string _name;

        /// <summary>
        /// Email.
        /// </summary>
        private string _email;

        /// <summary>
        /// Дата рождения.
        /// </summary>
        private DateTime _dateOfBirth;

        /// <summary>
        /// Номер телефона.
        /// </summary>
        private PhoneNumber _phoneNumber;

        /// <summary>
        /// Id VK.
        /// </summary>
        private string _idVK;

        /// <summary>
        /// Максимальное кол-во букв.
        /// </summary>
        public const int MAXLETTERCOUNT = 50;

        /// <summary>
        /// Возвращает или задает значение фамилии.
        /// </summary>
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                if (value.Length > MAXLETTERCOUNT || value.Length == 0)
                {
                    throw new ArgumentException("Некорректная длина фамилии");
                }
                _surname = value;
            }
        }
        /// <summary>
        /// Возвращает или задает значение имени.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length > MAXLETTERCOUNT || value.Length == 0)
                {
                    throw new ArgumentException("Некорректная длина имени");
                }
                _name = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime DateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }
            set
            {
                if (value.Year < 1900)
                {
                    throw new ArgumentException("Дата рождения не может быть" +
                        " меньше 1900г.");
                }

                if (value > DateTime.Now)
                {
                    throw new ArgumentException("Дата рождения не может быть" +
                        " больше сегодняшней даты");
                }
                _dateOfBirth = value;
            }
        }
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (value.Length > MAXLETTERCOUNT || value.Length == 0)
                {
                    throw new ArgumentException("Некорректная длина email");
                }
                _email = value;
            }
        }
        public PhoneNumber PhoneNumber { get; set; }

        public string IdVK
        {
            get
            {
                return _idVK;
            }
            set
            {
                if (value.Length > MAXLETTERCOUNT || value.Length == 0)
                {
                    throw new ArgumentException("Некорректная длина id");
                }
                _idVK = value;
            }
        }

        public Contact(string name, string surname,
             PhoneNumber phoneNumber, DateTime dateOfBirth,
             string email, string idVK)
        {
            this.Surname = surname;
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.DateOfBirth = dateOfBirth;
            this.Email = email;
            this.IdVK = idVK;
        }

        public Object Clone()
        {
            return new Contact(this.Name, this.Surname,
               new PhoneNumber(this.PhoneNumber.Number),
               this.DateOfBirth, this.Email, this.IdVK);
        }
    }
}
