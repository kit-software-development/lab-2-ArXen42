using System;
using System.Collections.Generic;
using Practice.Common;

namespace Practice.HR
{
	internal class ClientBuilder : IClientBuilder
	{
		private readonly IList<Action<IClient>> _propertySettingActions = new List<Action<IClient>>();

		public IClient Build()
		{
			// Такая реализация хранения заданных свойств в данном случае показалась мне достаточно краткой и расширяемой.
			// Можно реализовать и другие варианты (например простое дублирование всех свойств клиента).

			var client = new Client();
			foreach (var propertySettingAction in _propertySettingActions)
				propertySettingAction.Invoke(client);

			return client;
		}

		public IClientBuilder Name(IName name)
		{
			_propertySettingActions.Add(client => client.Name = name);
			return this;
		}

		public IClientBuilder Name(String firstName, String surname, String patronymic)
		{
			return Name(new Name(firstName, surname, patronymic));
		}

		public IClientBuilder Discount(Single discount)
		{
			_propertySettingActions.Add(client => client.Discount = discount);
			return this;
		}
	}
}