namespace ExtractingArtistsUsingDom
{
    using System;
    using System.Collections;
    using System.Xml;

    internal class Program
    {
        private static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            var path = "../../../catalog.xml";

            doc.Load(path);

            var catalog = doc.DocumentElement;
            var artists = ExtractAllUniqueArtists(catalog);

            foreach (var artist in artists.Keys)
            {
                string oneOrManyAlbums = (int)artists[artist] > 1 ? " albums" : " album";
                Console.WriteLine(artist + " - " + artists[artist] + oneOrManyAlbums);
            }
        }

        private static Hashtable ExtractAllUniqueArtists(XmlElement rootNode)
        {
            string tagName = "album";

            var artists = new Hashtable();

            var albums = rootNode.GetElementsByTagName(tagName);

            foreach (XmlNode album in albums)
            {
                var currentArtistName = album["artist"].InnerText;
                if (!artists.ContainsKey(currentArtistName))
                {
                    artists[currentArtistName] = 1;
                }
                else
                {
                    artists[currentArtistName] = (int)artists[currentArtistName] + 1;
                }
            }

            return artists;
        }
    }
}
