using Horsesoft.Traktor;
using Horsesoft.Traktor.Enums;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horsesoft.TraktorTests
{
    [TestFixture]
    public class SearchNmlTest
    {
        const string COLLECTION = @"I:\Media\Traktor 2.0.3 - Master\collection.nml";

        [Test]
        public void SearchDatabaseNml()
        {            
            SearchNml search = new SearchNml();

            var results = search.SearchDatabaseNml(COLLECTION, SearchElement.TITLE, "cross the line");

            Console.WriteLine("Search results found {0}", results.Count());

        }
    }
}
