using ConsoleApp2.Linq2Db.DTO;
using LinqToDB.Mapping;

namespace ConsoleApp2.Linq2Db.Mapping
{
	static class MapTypes
	{
		public static void Map()
		{
			var fb = MappingSchema.Default.GetFluentMappingBuilder();
			MapAa(fb);
		}

		static void MapAa(FluentMappingBuilder fb)
		{
			fb.Entity<Aa>()
				.HasPrimaryKey(x => x.Id).HasTableName("Id")
				.Ignore(x => x.NotInDb)
				.HasColumn(x => x.Name).HasTableName("Name");
		}
	}
}
