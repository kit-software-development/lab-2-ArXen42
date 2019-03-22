using System;
using Practice.Common;
using Practice.Organization;

namespace Practice.HR
{
	/// <summary>
	///     Абстрактная база для описания конкретных реализаций типа "Человек".
	///     Используется для дальнейшего наследования.
	/// </summary>
	internal abstract class AbstractPerson
	{
		internal Department Department
		{
			get => throw new NotImplementedException();

			set => throw new NotImplementedException();
		}

		internal Name Name
		{
			get => throw new NotImplementedException();

			set => throw new NotImplementedException();
		}

		/*
	     * TODO #3: Реализуйте интерфейс IPerson для класса AbstractPerson
	     */
	}
}