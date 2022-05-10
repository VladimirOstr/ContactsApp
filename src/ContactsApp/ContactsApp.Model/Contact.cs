using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.Model
{
    /// <summary>
    /// Контакт.
    /// </summary>
    public class Contact : ICloneable
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
                if (value.Length > MAXLETTERCOUNT)
                {
                    throw new ArgumentException("Длина фамилии больше" + MAXLETTERCOUNT);
                }
                if (value.Length <= 0)
                {
                    throw new ArgumentException("Длина фамилии меньше или равна 0");
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
                if (value.Length > MAXLETTERCOUNT)
                {
                    throw new ArgumentException("Длина имени больше" + MAXLETTERCOUNT);
                }
                if (value.Length <= 0)
                {
                    throw new ArgumentException("Длина имени меньше или равна 0");
                }
                _name = value;
            }
        }
        /// <summary>
        /// Возвращает или задает значение даты рождения.
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
        /// <summary>
        /// Возвращает или задает значение email.
        /// </summary>
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (value.Length > MAXLETTERCOUNT)
                {
                    throw new ArgumentException("Длина email больше 50 знаков");
                }
                if (value.Length <= 0)
                {
                    throw new ArgumentException("Длина email меньше или равна 0");
                }
                _email = value;
            }
        }
        /// <summary>
        /// Возвращает или задает значение номера телефона.
        /// </summary>
        public PhoneNumber PhoneNumber { get; set; }

        /// <summary>
        /// Возвращает или задает значение id VK.
        /// </summary>
        public string IdVK
        {
            get
            {
                return _idVK;
            }
            set
            {
                if (value.Length > 15)
                {
                    throw new ArgumentException("Длина id больше 15 знаков");
                }
                if (value.Length <= 0)
                {
                    throw new ArgumentException("Длина id меньше или равна 0");
                }
                _idVK = value;
            }
        }

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="dateOfBirth"></param>
        /// <param name="email"></param>
        /// <param name="idVK"></param>
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

        /// <summary>
        /// Клонирует объект класса.
        /// </summary>
        /// <returns></returns>
        public Object Clone()
        {
            return new Contact(this.Name, this.Surname,
               new PhoneNumber(this.PhoneNumber.Number),
               this.DateOfBirth, this.Email, this.IdVK);
        }
    }
}
