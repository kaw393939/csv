using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
using System.Collections.Generic;
using System.IO;
using Worldcities;
namespace csv
{
    public sealed class CityMap : ClassMap<City>
    {
        public CityMap()
        {
            AutoMap();
            Map(m => m.City_name).Name("city");
            Map(m => m.City_ascii).Name("city_ascii");
            Map(m => m.Admin_name).Name("admin_name");
            Map(m => m.Capital).Name("capital");
            Map(m => m.Country).Name("country");
            Map(m => m.Id).Name("id");
            Map(m => m.ISO2).Name("iso2");
            Map(m => m.ISO3).Name("iso3");
            Map(m => m.Lat).Name("lat");
            Map(m => m.Lng).Name("lng");
            Map(m => m.Population).Name("population");
        }
    }
}
