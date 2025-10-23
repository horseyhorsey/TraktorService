using Horsesoft.Traktor;
using Horsesoft.Traktor.Enums;
using Horsesoft.Traktor.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Horsesoft.Traktor
{
    public class TraktorConverter
    {        
        public async Task<List<MusicFileTag>> NmlToMusicFileTagsAsync(string nmlCollection)
        {
            if (!File.Exists(nmlCollection))                
                    throw new FileNotFoundException();

            using (var stream = File.Open(nmlCollection, FileMode.Open, FileAccess.Read))
            {
                return await NmlToMusicFileTagsAsync(stream);
            }
        }

        public async Task<List<MusicFileTag>> NmlToMusicFileTagsAsync(Stream nmlStream)
        {
            var traktorNmlDb = new NmlSerializer();

            var traktorEntrys = new List<MusicFileTag>();

            var deserialized = await traktorNmlDb.DeserializeNmlDatabaseAsync(nmlStream);

            try
            {
                foreach (var entry in deserialized.COLLECTION.ENTRY)
                {
                    string album = "";
                    MusicKey key = MusicKey.None;
                    decimal beatspermin = 0;
                    if (entry.ALBUM != null)
                        album = entry.ALBUM.TITLE;
                    if (entry.MUSICAL_KEY != null)
                        key = (MusicKey)entry.MUSICAL_KEY.VALUE;
                    if (entry.TEMPO != null)
                        beatspermin = entry.TEMPO.BPM;

                    traktorEntrys.Add(new MusicFileTag()
                    {
                        Artist = entry.ARTIST ?? "",
                        Title = entry.TITLE ?? "",
                        Album = album,
                        Genre = entry.INFO.GENRE,
                        BitRate = entry.INFO.BITRATE,
                        Bpm = beatspermin,                        
                        Key = key,
                        Ranking = entry.INFO.RANKING,
                        Label = entry.INFO.LABEL,
                        Year = entry.INFO.PRODUCER,
                        Comment = entry.INFO.COMMENT,
                        DriveVolume = entry.LOCATION.VOLUME,
                        FileLocation = entry.LOCATION.DIR.Replace(':', '/'),
                        FileName = entry.LOCATION.FILE
                    });
                }
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                deserialized = null;                
            }

            return traktorEntrys;

        }
    }
}
