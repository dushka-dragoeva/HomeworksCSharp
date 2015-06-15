using System;

/* Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
Example:

URL	Information
http://telerikacademy.com/Courses/Courses/Details/212	
 * [protocol] = http 
[server] = telerikacademy.com 
[resource] = /Courses/Courses/Details/212 */
class ParseURL
{
    static void Main()
    {
        string url = "http://telerikacademy.com/Courses/Courses/Details/212";
        Console.WriteLine("[protocol] = {0}",GetProtocol(url));
        Console.WriteLine("[server] = {0}",GetServer(url));
        Console.WriteLine("[resource] = {0}",GetResorce(url));
    }
    static string GetProtocol(string url)
    {
        string protokol =url.Substring(0,url.IndexOf(':'));
        return protokol;
    }
    static string GetServer(string url)
    {
        int startIndex = url.IndexOf("//")+2;
        int endIndex=url.IndexOf('/',startIndex);
        string server = url.Substring(startIndex, (endIndex - startIndex));
        return server;
    }
   static string GetResorce(string url)
   {
       int startIndex = url.IndexOf('/', (url.IndexOf("//")+2));
       string resorse = url.Substring(startIndex);
       return resorse;
   }
}
