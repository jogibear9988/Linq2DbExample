using System.Linq;
using ConsoleApp2.Linq2Db.Config;
using ConsoleApp2.Linq2Db.DTO;
using ConsoleApp2.Linq2Db.Mapping;
using LinqToDB;
using LinqToDB.Data;

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			DataConnection.DefaultSettings = new LinqToDBSettings();
			MapTypes.Map();

			using (var dc = new DataConnection())
			{
				var table = dc.GetTable<Aa>();

				table.Where(x => x.Name.StartsWith("A")).Set(a => a.Name, b => "B" + b.Name).Update();
			}
		}
	}
}
