using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using System.Linq;
using Cities;
using Csv;

namespace Csv
{
    public class CsvWrite
    {
        public static string CsvWriter(string path)
        {
            
            var doubleTypeConversion = new DoubleConversion();
            IList<CityModel> myList = ReadCsv.ReadCsvFile<CityModel, CityMap>(path, doubleTypeConversion);
            
            var countryCapitalQueryAdmin = from s in myList
                                      where s.Capital.Equals("admin")
                                      orderby s.Country ascending
                                      select s;
            // Hello
            foreach (CityModel city in countryCapitalQueryAdmin)
            {
                Debug.Write(city.Country + ": " + city.City_name + Environment.NewLine);
            }
            var queryName = nameof(countryCapitalQueryAdmin);
            var writePath = "c://csvfiles//" + queryName + ".csv";
            using (var writer = new StreamWriter(writePath))
            using (var csv = new CsvWriter(writer))
            {
                csv.WriteRecords(countryCapitalQueryAdmin);
            }

            return writePath;

        }

    }
}
