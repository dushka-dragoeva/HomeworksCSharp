namespace DeleteingAlbums
{
    using System;
    using System.Globalization;
    using System.Threading;
    using System.Xml;

    internal class Program
    {
        private static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            var path = "../../../catalog.xml";
            doc.Load(path);

            XmlElement root = doc.DocumentElement;
            const int MaxPrice = 20;

            DeleteAlbums(root, MaxPrice);
            doc.Save("../../updatedCatalog.xml");
            Console.WriteLine("Saved in updatedCatalog.xml");
        }

        private static void DeleteAlbums(XmlElement root, double maxPrice)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            foreach (XmlElement album in root.SelectNodes("album"))
            {
                string albumPrice = album["price"].InnerText;
                double price = double.Parse(albumPrice);

                if (maxPrice < price)
                {
                    root.RemoveChild(album);
                }
            }
        }
    }
}
