using System;

namespace Practice.Common
{
	/// <summary>
	///     Абстрактное представление имени человека.
	///     Тип, реализующий данный интерфейс, по возможности, должен быть значащим.
	/// </summary>
	public interface IName
	{
		/// <summary>
		///     Полная форма имени.
		/// </summary>
		String FullName { get; }

		/// <summary>
		///     Короткая форма имени.
		/// </summary>
		String ShortName { get; }
	}
}