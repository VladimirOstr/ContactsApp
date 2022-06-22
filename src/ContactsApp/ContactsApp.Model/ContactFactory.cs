using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.Model
{
    /// <summary>
    /// Фабричный интерфейс
    /// </summary>
    public class ContactFactory
    {
        /// <summary>
        /// Добавление контакта с рандомными данными
        /// </summary>
        /// <returns></returns>
        static public Contact AddRandomContact()
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
            new DateTime(random.Next(1900, 2022),
            random.Next(1, 12), random.Next(1, 28)),
            randomEmails[random.Next(randomEmails.Count)],
            new Random().Next().ToString());
            return contact;
        }
    }
}
