using System;
using System.Globalization;
using Practice.HR;

namespace Practice
{
	/// <summary>
	///     Цели работы:
	///     1. на практике познакомиться с механизмом наследования;
	///     2. научиться использовать полиморфизм;
	///     3. научиться разделять контексты;
	///     4. научиться использовать инкапсуляцию на уровне библиотеки;
	///     5. научиться использовать абстрактные типы данных.
	/// </summary>
	internal static class Program
	{
		private static void Main(String[] args)
		{
			IClient client = Builders.ClientBuilder()
				.Name("Иванов", "Иван", "Иванович")
				.Discount(.1f)
				.Build();

			IEmployee employee = Builders.EmployeeBuilder()
				.Name("Сидоров", "Григорий", "Петрович")
				.Department("Бухгалтерия")
				.Build();

			Console.WriteLine($"{client.Name.FullName} {client.Discount.ToString(CultureInfo.InvariantCulture)}");
			Console.WriteLine($"{employee.Name.ShortName} {employee.Department.Name}");
		}
	}
}