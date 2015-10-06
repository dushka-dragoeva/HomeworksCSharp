namespace CreatingPersonDataXml
{
    using System.IO;
    using System.Xml.Linq;

    internal class Program
    {
        private static void Main()
        {
            string path = "../../personData.txt";
            var person = new Person();
            using (StreamReader reader = new StreamReader(path))
            {
                person.Name = reader.ReadLine();
                person.Address = reader.ReadLine();
                person.PhoneNumber = reader.ReadLine();
            }

            XElement personElement = 
                new XElement(
                    "person",
                    new XElement("name", person.Name),
                    new XElement("address", person.Address),
                    new XElement("phoneNumber", person.PhoneNumber));

            personElement.Save("../../personDataXml.xml");
        }
    }
}