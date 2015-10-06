namespace ExtractingAllSongsWithXmlReader
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Threading;
    using System.Xml;

    internal class Program
    {
        private static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Song titles in the catalog:");
            Console.WriteLine(string.Concat(Enumerable.Repeat("-", 40)));

            string path = "../../../catalog.xml";
            using (XmlReader reader = XmlReader.Create(path))
            {
                while (reader.Read())
                {
                    if ((reader.NodeType == XmlNodeType.Element) &&
                        (reader.Name == "title"))
                    {
                        Console.WriteLine(reader.ReadElementString());
                    }
                }
            }
        }
    }
}
