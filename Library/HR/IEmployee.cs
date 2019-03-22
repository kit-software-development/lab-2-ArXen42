using System;
using Practice.Common;
using Practice.HR.Events;
using Practice.Organization;

namespace Practice.HR
{
	/// <summary>
	///     Абстрактное представление о сотруднике.
	/// </summary>
	public interface IEmployee : IPerson
	{
		/// <summary>
		///     Событие изменения отдела, в котором работает сотрудник.
		/// </summary>
		event EventHandler<ValueChangeEventArgs<IDepartment>> DepartmentChange;

		/// <summary>
		///     Отдел, в котором работает сотрудник.
		/// </summary>
		IDepartment Department { get; set; }
	}

	/// <summary>
	///     Абстрактное представление о реализации эталона проектирования
	///     "Строитель" для типа данных IEmployee.
	/// </summary>
	public interface IEmployeeBuilder : IBuilder<IEmployee>
	{
		/// <summary>
		///     Настраивает значение имени для будущего экземпляра типа IEmployee.
		/// </summary>
		/// <param name="name">имя сотрудника</param>
		/// <returns>
		///     Текущий экземпляр "Строителя".
		/// </returns>
		IEmployeeBuilder Name(IName name);

		/// <summary>
		///     Настраивает значение имени для будущего экземпляра типа IEmployee.
		/// </summary>
		/// <param name="name">имя</param>
		/// <param name="surname">фамилия</param>
		/// <param name="patronymic">отчество</param>
		/// <returns>
		///     Текущий экземпляр "Строителя".
		/// </returns>
		IEmployeeBuilder Name(String name, String surname, String patronymic);

		/// <summary>
		///     Настраивает значение отледа для будущего экземпляра типа IEmployee.
		/// </summary>
		/// <param name="department">
		///     Отдел, в котором работает сотрудник.
		/// </param>
		/// <returns>
		///     Текущий экземпляр "Строителя".
		/// </returns>
		IEmployeeBuilder Department(IDepartment department);

		/// <summary>
		///     Настраивает значение отледа для будущего экземпляра типа IEmployee.
		/// </summary>
		/// <param name="department">
		///     Название отдела, в котором работает сотрудник.
		/// </param>
		/// <returns>
		///     Текущий экземпляр "Строителя".
		/// </returns>
		IEmployeeBuilder Department(String department);
	}
}