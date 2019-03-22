using System;
using Practice.Common;
using Practice.HR.Events;
using Practice.Organization;

namespace Practice.HR
{
	/// <summary>
	///     Абстрактная база для описания конкретных реализаций типа "Человек".
	///     Используется для дальнейшего наследования.
	/// </summary>
	internal abstract class AbstractPerson : IPerson
	{
		private IName _name;

		public event EventHandler<ValueChangeEventArgs<IName>> NameChanged;

		public IName Name
		{
			get => _name;

			set
			{
				if (_name == value)
					return;

				var oldName = _name;
				_name = value;

				NameChanged?.Invoke(this, new ValueChangeEventArgs<IName>(oldName));
			}
		}

		// Убраны внутренние свойства Name и Department, так как они только создавали ненужные конфликты
	}
}