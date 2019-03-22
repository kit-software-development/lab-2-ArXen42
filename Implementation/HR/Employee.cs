using System;
using Practice.HR.Events;
using Practice.Organization;

namespace Practice.HR
{
	/// <summary>
	///     Скрытая реализация представления о сотруднике.
	/// </summary>
	internal class Employee : AbstractPerson, IEmployee
	{
		private IDepartment _department;

		public event EventHandler<ValueChangeEventArgs<IDepartment>> DepartmentChanged;

		public IDepartment Department
		{
			get => _department;
			set
			{
				if (_department == value)
					return;

				var oldValue = _department;
				_department = value;

				DepartmentChanged?.Invoke(this, new ValueChangeEventArgs<IDepartment>(oldValue));
			}
		}
	}
}