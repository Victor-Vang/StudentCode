using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.SqlClient;
using System.Transactions;
using USCitiesAndParks.Models;

namespace USCitiesAndParksTests
{
    [TestClass]
    public class ParkSqlDaoTest : CitiesAndParksTests
    {
     
        [TestMethod]
        public void ParkCreationTest()
        {
            Park park = new Park();
            Assert.IsNotNull(park);
        }
     
    }
}

