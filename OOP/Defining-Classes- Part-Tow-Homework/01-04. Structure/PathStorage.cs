namespace _01_04.Structure
{
    using System;
    using System.IO;


    class PathStorage
    {
        public static void SavePath(Path path, string pathID)
        {
            using (StreamWriter sw=new StreamWriter(@"..//..//path" + pathID ))
            {
                for (int i = 0; i < path.PathList.Count; i++)
                {
                    sw.WriteLine(path.PathList[i]);
                }
            }
        }
        public static Path LoadPath(string filePath)
        {
            Path path = new Path();
            using(StreamReader sr= new StreamReader(filePath))
            {
             while(sr.EndOfStream==false)
             {
                 string nextPointText = sr.ReadLine();
                 Point3D nextPoint = Point3D.Parse(nextPointText);
                 path.AddPoint(nextPoint);
             }
            }
            return path;
        }

    }
}
