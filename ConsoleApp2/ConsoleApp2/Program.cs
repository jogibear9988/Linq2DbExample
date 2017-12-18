using System;
using System.Data.SQLite;
using System.Linq;
using ConsoleApp2.Linq2Db.Config;
using ConsoleApp2.Linq2Db.DTO;
using ConsoleApp2.Linq2Db.Mapping;
using LinqToDB;
using LinqToDB.Data;
using LinqToDB.DataProvider.SQLite;

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


			//// Wenn du das ganze mit In Memory Datenbanken in Sqlite machen willst (z.B. für Unit Tests, 
			//// musst du die DbConnection manuell erzeugen, weil wenn du den Migrator nutzen willst, du ja die gleich DbConnection brauchst.
			//// Das geht dann ungef. so:
			//var conn = new SQLiteConnection("Data Source=:memory:;Version=3;New=True;");
			//// jetzt die connection im Migator nutzen...
			//// Migator ... blablabla
			//// nun die Connection mit Linq2Db nutzen
			//using (var dc = new DataConnection(new SQLiteDataProvider(), conn))
			//{
			//	var table = dc.GetTable<Aa>();
			//	table.Where(x => x.Name.StartsWith("A")).Set(a => a.Name, b => "B" + b.Name).Update();
			//}


			Console.WriteLine("Feddich...");
			Console.ReadLine();
		}
	}
}
