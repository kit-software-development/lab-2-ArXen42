using System;

namespace Practice.Common
{
	/// <summary>
	///     Скрытая реализация представления об имени человека.
	/// </summary>
	internal struct Name
	{
		/*
		 * TODO #1: Реализуйте интерфейс IName для структуры Name
		 */

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
	}
}