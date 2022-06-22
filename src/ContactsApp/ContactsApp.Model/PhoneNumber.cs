using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.Model
{
    /// <summary>
    /// Номер телефона.
    /// </summary>
    public class PhoneNumber
    {
		/// <summary>
		/// Номер телефона.
		/// </summary>
		private long _number;

		/// <summary>
		/// Максимальное количество цифр в номере.
		/// </summary>
		public const int MAXDIGITCOUNT = 11;

		/// <summary>
		/// Возвращает или задает значение номера.
		/// </summary>
		public long Number
		{
			get
			{
				return _number;
			}
			set
			{
				if (value.ToString().Length > MAXDIGITCOUNT || 
					!value.ToString().StartsWith("7"))
				{
					throw new ArgumentException("Номер больше " + 
						MAXDIGITCOUNT + "или начинается не с 7");
				}
				_number = value;
			}
		}

		/// <summary>
		/// Создает экземпляр PhoneNumber.
		/// </param>
		public PhoneNumber(long number)
		{
			Number = number;
		}
	}
}
