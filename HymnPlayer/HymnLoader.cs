using System.Collections.Generic;
using System.Xml;
using HymnPlayer.Models;

namespace HymnPlayer
{
    class HymnLoader
    {
        public List<Hymn> Load(string fileName)
        {
            XmlDocument document = new XmlDocument();
            document.Load(fileName);
            List<Hymn> hymns = new List<Hymn>(document.DocumentElement.ChildNodes.Count);
            foreach (XmlElement hymnElement in document.DocumentElement.ChildNodes)
            {
                Hymn hymn = new Hymn
                {
                    Number = int.Parse(hymnElement.GetAttribute("no")),
                    Title = GetTitle(hymnElement),
                    Verses = GetVerses(hymnElement)
                };
                hymns.Add(hymn);
            }
            return hymns;
        }

        private string GetTitle(XmlElement hymnElement)
        {
            foreach (XmlElement element in hymnElement.ChildNodes)
            {
                if (element.LocalName == "Title")
                    return element.InnerText;
            }
            return "Fără titlu";
        }

        private List<Verse> GetVerses(XmlElement hymnElement)
        {
            List<Verse> verses = new List<Verse>(hymnElement.ChildNodes.Count - 1);
            foreach (XmlElement element in hymnElement.ChildNodes)
            {
                if (element.LocalName == "Verse")
                    verses.Add(new Verse(element.InnerText));
            }
            return verses;
        }
    }
}
