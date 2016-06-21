using Horsesoft.Traktor.Models;
using System.IO;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Horsesoft.Traktor
{
    public class NmlSerializer
    {
        public async Task<NML> DeserializeNmlDatabaseAsync(string fileName)
        {
            if (!File.Exists(fileName)) throw new FileNotFoundException(string.Format("File Not found {0}", fileName));

            NML nmlSerialized = new NML();

            await Task.Run(() =>
            {
                using (var stringReader = File.Open(fileName, FileMode.Open, FileAccess.Read))
                using (var xmlReader = XmlReader.Create(stringReader))
                {
                    var serializer = new XmlSerializer(typeof(NML));

                    xmlReader.MoveToContent();

                    nmlSerialized = (NML)serializer.Deserialize(xmlReader);
                };

            });

            return nmlSerialized;
        }
    }
}
