using NUnit.Framework;
using Horsesoft.Traktor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Horsesoft.Traktor.Models;

namespace Horsesoft.Traktor.Tests
{
    [TestFixture()]
    public class SerializerTests
    {
        const string COLLECTION = @"I:\Media\Traktor 2.0.3 - Master\collection.nml";

        [Test()]
        public async Task DeserializeNmlDatabaseAsyncTest()
        {
            var traktorConvert = new TraktorConverter();

            List<MusicFileTag> traktorCollection = await traktorConvert.NmlToMusicFileTagsAsync(COLLECTION);            

            Assert.That(traktorCollection, Is.Not.Null);

            Console.WriteLine("Total traktor entrys {0}", traktorCollection.Count);
        }
    }
}