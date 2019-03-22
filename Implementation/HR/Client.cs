using System;

namespace Practice.HR
{
	/// <summary>
	///     Скрытая реализация представления о клиенте.
	/// </summary>
	internal class Client : AbstractPerson, IClient
	{
		public Single Discount { get; set; }
	}
}