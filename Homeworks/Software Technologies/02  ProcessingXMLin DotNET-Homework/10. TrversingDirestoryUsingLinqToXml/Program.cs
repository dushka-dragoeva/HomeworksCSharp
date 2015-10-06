namespace TrversingDirestoryUsingLinqToXml
{
    using System.IO;
    using System.Xml.Linq;

    internal class Program
    {
        private static void Main()
        {
            string directory = "D:\\Terelik\\CSharp\\DataBase\\Homeworks\\02  ProcessingXMLin DotNET-Homework";
            string fileName = "../../directoryLinqToXml.xml";
            var rootDirectory = new DirectoryInfo(directory);
            string rootString = "root";

            XElement directoryTree = new XElement(rootString);
            directoryTree.Add(TraverseDirectory(rootDirectory));
            directoryTree.Save(fileName);
        }

        private static XElement TraverseDirectory(DirectoryInfo directory)
        {
            string dirString = "dir";
            string nameString = "name";
            var dirElement = new XElement(dirString, new XAttribute(nameString, directory.Name));
            foreach (var dir in directory.GetDirectories())
            {
                dirElement.Add(TraverseDirectory(dir));
            }

            string fileString = "file";
         
            foreach (var file in directory.GetFiles())
            {
                dirElement.Add(new XElement(fileString, new XAttribute(nameString, file.Name)));
            }

            return dirElement;
        }
    }
}
