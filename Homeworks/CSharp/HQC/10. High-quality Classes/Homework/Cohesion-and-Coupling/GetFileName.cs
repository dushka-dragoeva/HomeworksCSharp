namespace CohesionAndCoupling
{
    using System;

    internal static class GetFileName
    {
        internal static string GetFileExtension(string fileName)
        {
            string extension = fileName.Substring(GetIndexofLastDot(fileName) + 1);
            return extension;
        }

        internal static string GetFileNameWithoutExtension(string fileName)
        {
            string fileNameWithoutExtention = fileName.Substring(0, GetIndexofLastDot(fileName));
            return fileNameWithoutExtention;
        }

        internal static int GetIndexofLastDot(string fileName)
        {
            int indexOfLastDot = fileName.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                throw new ArgumentException("Filename is not full. Missing Extention!");
            }

            return indexOfLastDot;
        }
    }
}
