namespace ExtractingArtistsUsingXPath
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

            var artists = ExtractAllUniqueArtists(doc);

            foreach (var artist in artists.Keys)
            {
                string oneOrManyAlbums = (int)artists[artist] > 1 ? " albums" : " album";
                Console.WriteLine(artist + " - " + artists[artist] + oneOrManyAlbums);
            }
        }

        private static Hashtable ExtractAllUniqueArtists(XmlDocument doc)
        {
            var artistPath = "catalog/album/artist";
            XmlNodeList allArtists = doc.SelectNodes(artistPath);
            var artists = new Hashtable();

            foreach (XmlNode artistNode in allArtists)
            {
                var currentArtistName = artistNode.InnerText;

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
