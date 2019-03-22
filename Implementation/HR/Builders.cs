namespace Practice.HR
{
	/// <summary>
	///     Класс-фабрика, позволяющий получать экземпляры типов,
	///     инкапсулированных на уровне библиотеки.
	/// </summary>
	public static class Builders
	{
		/// <summary>
		///     Возвращает экземпляр "Строителя" клиентов.
		/// </summary>
		/// <returns>
		///     Экземпляр типа IClientBuilder.
		/// </returns>
		public static IClientBuilder ClientBuilder()
		{
			return new ClientBuilder();
		}

		/// <summary>
		///     Возвращает экземпляр "Строителя" сотудников.
		/// </summary>
		/// <returns>
		///     Возвращает экземпляр типа IEmployeeBuilder.
		/// </returns>
		public static IEmployeeBuilder EmployeeBuilder()
		{
			return new EmployeeBuilder();
		}
	}
}