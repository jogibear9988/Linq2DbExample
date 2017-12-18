using System.Collections.Generic;
using LinqToDB;
using LinqToDB.Configuration;

namespace ConsoleApp2.Linq2Db.Config
{
	class LinqToDBSettings : ILinqToDBSettings
	{
		static LinqToDBSettings()
		{
			_iConnectionStringSettings = new[]
				{new ConnectionStringSettings() {Name = "Default", ProviderName = ProviderName.SQLite, ConnectionString = "Data Source=Test.db;Version=3;"}};
		}

		private static IConnectionStringSettings[] _iConnectionStringSettings;

		class ConnectionStringSettings : IConnectionStringSettings
		{
			public string ConnectionString { get; set; }
			public string Name { get; set; }
			public string ProviderName { get; set; }
			public bool IsGlobal => false;
		}

		public IEnumerable<IDataProviderSettings> DataProviders { get; }
		public string DefaultConfiguration => "Default";

		public string DefaultDataProvider => ProviderName.SQLite;

		public IEnumerable<IConnectionStringSettings> ConnectionStrings => _iConnectionStringSettings;
	}
}
