using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.Model
{
    /// <summary>
    /// Проект.
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Список всех контактов.
        /// </summary>
        public List<Contact> Contacts { get; set; } = new List<Contact>();
    }
}
