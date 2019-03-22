using System;

namespace Practice.Common
{
	/// <summary>
	///     Скрытая реализация представления об имени человека.
	/// </summary>
	internal struct Name : IName
	{
		public Name(String firstName, String surname, String patronymic)
		{
			// Так как ограничений и конкретного поведения данного класса в задании не оговорено, пока будем считать все три поля обязательными

			if (String.IsNullOrWhiteSpace(firstName))
				throw new ArgumentException(nameof(firstName));

			if (String.IsNullOrWhiteSpace(surname))
				throw new ArgumentException(nameof(firstName));

			if (String.IsNullOrWhiteSpace(patronymic))
				throw new ArgumentException(nameof(firstName));

			FirstName  = firstName;
			Surname    = surname;
			Patronymic = patronymic;
		}

		/// <summary>
		///     Имя.
		/// </summary>
		public String FirstName { get; }

		/// <summary>
		///     Фамилия.
		/// </summary>
		public String Surname { get; }

		/// <summary>
		///     Отчество.
		/// </summary>
		public String Patronymic { get; }

		public String FullName  => $"{FirstName} {Patronymic} {Surname}";
		public String ShortName => $"{FirstName[0]} {Patronymic[0]} {Surname}";
	}
}