using Horsesoft.Traktor.Enums;
using Horsesoft.Traktor.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Horsesoft.Traktor
{
    public class SearchNml
    {
        /// <summary>
        /// Search traktor database Nml Entry
        /// </summary>
        /// <param name="nmlPath"></param>
        /// <param name="elementName"></param>
        /// <returns></returns>
        public IEnumerable<ENTRY> SearchDatabaseNml(string nmlPath, SearchElement elementName, string searchText)
        {
            if (!File.Exists(nmlPath)) throw new FileNotFoundException();

            using (var stream = File.Open(nmlPath, FileMode.Open, FileAccess.Read))
            {
                return SearchDatabaseNml(stream, elementName, searchText);
            }
        }

        public IEnumerable<ENTRY> SearchDatabaseNml(Stream nmlStream, SearchElement elementName, string searchText)
        {
            var entries = new List<ENTRY>();

            var watch = new Stopwatch();

            watch.Start();

            var document = XDocument.Load(nmlStream);

            IEnumerable<XElement> documentElements = null;

            switch (elementName.ToString())
            {
                case "ARTIST":
                case "TITLE":
                    documentElements = from e in document.Descendants("ENTRY")
                                       where e.Attribute(elementName.ToString()).Value.ToLower().Contains(searchText.ToLower())
                                       select e;
                    break;
                case "MUSICAL_KEY":
                    documentElements = from e in document.Descendants("ENTRY")
                                       where (string)e.Element(elementName.ToString()).Attribute("VALUE") == searchText
                                       select e;
                    break;
                default:
                    break;
            }


            try
            {
                foreach (var item in documentElements)
                {
                    XmlSerializer ser = new XmlSerializer(typeof(ENTRY));

                    var koof = (ENTRY)ser.Deserialize(item.CreateReader());

                    entries.Add(koof);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }


            watch.Stop();
            Console.WriteLine("Search completed in {0}",watch.Elapsed);

            return entries;
        }
    }
}
