using System;

namespace Practice.Organization
{
	/// <summary>
	///     Скрытая реализация представления об отделе предприятия.
	/// </summary>
	internal struct Department : IDepartment
	{
		public Department(String name)
		{
			Name = name;
		}

		public String Name { get; }
	}
}