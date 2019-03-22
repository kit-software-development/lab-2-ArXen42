using System;
using Practice.Common;
using Practice.HR.Events;

namespace Practice.HR
{
	/// <summary>
	///     Абстрактное прердставление о человеке.
	/// </summary>
	public interface IPerson
	{
		/// <summary>
		///     Событие изменения имени челока.
		/// </summary>
		event EventHandler<ValueChangeEventArgs<IName>> NameChanged;

		/// <summary>
		///     Имя человека.
		/// </summary>
		IName Name { get; set; }
	}
}