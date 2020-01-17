using Microsoft.VisualStudio.TestTools.UnitTesting;
using Csv;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using CsvHelper;
using System.IO;

namespace Csv.Tests
{
    [TestClass()]
    public class CsvWriteTests
    {
        [TestMethod()]
        public void CsvWriterTest()
        {
            var path = "c://csvfiles//worldcities.csv";
            
            string writePath = CsvWrite.CsvWriter(path);


            Assert.IsTrue(File.Exists(writePath));
        }
    }
}