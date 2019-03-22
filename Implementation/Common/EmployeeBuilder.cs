using System;
using System.Collections.Generic;
using Practice.HR;
using Practice.Organization;

namespace Practice.Common
{
	internal class EmployeeBuilder : IEmployeeBuilder
	{
		private readonly IList<Action<IEmployee>> _propertySettingActions = new List<Action<IEmployee>>();

		public IEmployee Build()
		{
			var employee = new Employee();
			foreach (var propertySettingAction in _propertySettingActions)
				propertySettingAction.Invoke(employee);

			return employee;
		}

		public IEmployeeBuilder Name(IName name)
		{
			_propertySettingActions.Add(employee => employee.Name = name);
			return this;
		}

		public IEmployeeBuilder Name(String firstName, String surname, String patronymic)
		{
			return Name(new Name(firstName, surname, patronymic));
		}

		public IEmployeeBuilder Department(IDepartment department)
		{
			_propertySettingActions.Add(employee => employee.Department = department);
			return this;
		}

		public IEmployeeBuilder Department(String departmentName)
		{
			return Department(new Department(departmentName));
		}
	}
}