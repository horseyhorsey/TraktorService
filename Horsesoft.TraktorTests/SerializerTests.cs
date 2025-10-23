using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Horsesoft.Traktor.Models;

namespace Horsesoft.Traktor.Tests;

[TestFixture()]
public class SerializerTests
{
    const string COLLECTION = @"I:\Media\Traktor 2.0.3 - Master\collection.nml";

    [Test()]
    public async Task DeserializeNmlDatabaseAsyncTest()
    {
        var traktorConvert = new TraktorConverter();

        // Create test NML data
        string testXml = @"<?xml version=""1.0"" encoding=""UTF-8""?>
<NML VERSION=""19"">
  <HEAD COMPANY=""Native Instruments"" PROGRAM=""Traktor""/>
  <COLLECTION ENTRIES=""1"">
    <ENTRY TITLE=""Test Song"" ARTIST=""Test Artist"">
      <LOCATION DIR=""/Music/"" FILE=""test.mp3"" VOLUME=""Macintosh HD""/>
      <ALBUM TITLE=""Test Album""/>
      <INFO GENRE=""Electronic"" BITRATE=""320"" RANKING=""5""/>
      <TEMPO BPM=""128.0""/>
      <MUSICAL_KEY VALUE=""1""/>
    </ENTRY>
  </COLLECTION>
</NML>";

        using (var stream = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(testXml)))
        {
            List<MusicFileTag> traktorCollection = await traktorConvert.NmlToMusicFileTagsAsync(stream);

            Assert.That(traktorCollection, Is.Not.Null);
            Assert.That(traktorCollection.Count, Is.EqualTo(1));
            var tag = traktorCollection[0];
            Assert.That(tag.Title, Is.EqualTo("Test Song"));
            Assert.That(tag.Artist, Is.EqualTo("Test Artist"));
            Assert.That(tag.Album, Is.EqualTo("Test Album"));
            Assert.That(tag.Genre, Is.EqualTo("Electronic"));
            Assert.That(tag.BitRate, Is.EqualTo(320u));
            Assert.That(tag.Bpm, Is.EqualTo(128.0m));
            Assert.That(tag.Key, Is.EqualTo(Horsesoft.Traktor.Enums.MusicKey.Db)); // VALUE=1 is Db
            Assert.That(tag.Ranking, Is.EqualTo(5));
            Assert.That(tag.FileName, Is.EqualTo("test.mp3"));
            Assert.That(tag.FileLocation, Is.EqualTo("/Music/"));
            Assert.That(tag.DriveVolume, Is.EqualTo("Macintosh HD"));
        }

        Console.WriteLine("Test passed with mock data");
    }
}