using Horsesoft.Traktor;
using Horsesoft.Traktor.Enums;
using NUnit.Framework;
using System;
using System.IO;
using System.Linq;

namespace Horsesoft.TraktorTests;

[TestFixture]
public class SearchNmlTest
{
    const string COLLECTION = @"I:\Media\Traktor 2.0.3 - Master\collection.nml";

    [Test]
    public void SearchDatabaseNml()
    {            
        SearchNml search = new SearchNml();

        // Create test NML data
        string testXml = @"<?xml version=""1.0"" encoding=""UTF-8""?>
<NML VERSION=""19"">
  <HEAD COMPANY=""Native Instruments"" PROGRAM=""Traktor""/>
  <COLLECTION ENTRIES=""2"">
    <ENTRY TITLE=""Test Song"" ARTIST=""Test Artist"">
      <LOCATION DIR=""/Music/"" FILE=""test.mp3"" VOLUME=""Macintosh HD""/>
      <ALBUM TITLE=""Test Album""/>
      <INFO GENRE=""Electronic"" BITRATE=""320"" RANKING=""5""/>
      <TEMPO BPM=""128.0""/>
      <MUSICAL_KEY VALUE=""1""/>
    </ENTRY>
    <ENTRY TITLE=""Cross the Line"" ARTIST=""Another Artist"">
      <LOCATION DIR=""/Music/"" FILE=""cross.mp3"" VOLUME=""Macintosh HD""/>
      <ALBUM TITLE=""Another Album""/>
      <INFO GENRE=""Rock"" BITRATE=""256"" RANKING=""4""/>
      <TEMPO BPM=""120.0""/>
      <MUSICAL_KEY VALUE=""0""/>
    </ENTRY>
  </COLLECTION>
</NML>";

        using (var stream = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(testXml)))
        {
            var results = search.SearchDatabaseNml(stream, SearchElement.TITLE, "cross the line");

            Assert.That(results, Is.Not.Null);
            Assert.That(results.Count(), Is.EqualTo(1));
            var entry = results.First();
            Assert.That(entry.TITLE, Is.EqualTo("Cross the Line"));
            Assert.That(entry.ARTIST, Is.EqualTo("Another Artist"));
        }

        Console.WriteLine("Search test passed with mock data");
    }
}
