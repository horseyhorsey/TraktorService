using Horsesoft.Traktor.Enums;
using System;
using System.IO;

namespace Horsesoft.Traktor.Models
{
    [Serializable]
    public class MusicFileTag
    {
        public string Artist { get; set; }
        public string Title { get; set; }
        public string Album { get; set; }
        public string Year { get; set; }
        public string Label { get; set; }
        public string Genre { get; set; }
        public decimal Bpm { get; set; }
        public uint BitRate { get; set; }
        public string Comment { get; set; }
        public MusicKey? Key { get; set; }
        public short Ranking { get; set; }
        public string FileName { get; set; }
        public string FileLocation { get; set; }
        public string DriveVolume { get; set; }
                        
        public override string ToString() => Artist + " - " + Title + " - ";
    }
}
