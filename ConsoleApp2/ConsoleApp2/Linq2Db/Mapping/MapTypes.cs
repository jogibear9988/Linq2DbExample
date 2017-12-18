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
				.HasTableName("Aa")
				.Ignore(x => x.NotInDb)
				.Property(x => x.Id).IsPrimaryKey()
				.Property(x => x.Name).HasColumnName("Name");
		}
	}
}
