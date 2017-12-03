using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoordinateDatabase.Contexts;
using System.Linq;

namespace Coordinate.Tests
{
    [TestClass]
    public class DataRepositoryTests
    {
        [TestMethod]
        public void AllCompanies()
        {

            string connStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=coordinate;Integrated Security=True;MultipleActiveResultSets=True";

            using (var db = new Context(connStr))
            {
                var comps = db.Companies.ToList();
                Assert.IsNotNull(comps.Count);
            }

        }
    }
}
