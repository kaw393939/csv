using Microsoft.VisualStudio.TestTools.UnitTesting;
using csv; 
using System;
using System.Collections.Generic;
using System.Text;

namespace csv.Tests
{
    [TestClass()]
    public class readcsvTests
    {
        

        [TestMethod()]
        public void ReadInCSVTest()
        {
            string path = "c://csvfiles//worldcities.csv";
            List<Worldcities.City> cities = readcsv.ReadAllInCSV(path);
            Assert.AreEqual(15493, cities.Count);
        }

        [TestMethod()]
        public void ReadInCSV1Test()
        {
            string path = "c://csvfiles//worldcities.csv";
            List<Worldcities.City> cities = readcsv.ReadAllInCSV(path);
            Assert.AreEqual(15493, cities.Count);
        }
    }
}