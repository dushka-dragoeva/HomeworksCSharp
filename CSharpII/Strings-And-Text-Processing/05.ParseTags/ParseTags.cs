using System;
using System.Text;

/*You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
The tags cannot be nested.
Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else. */
class ParseTags
{
    static void Main()
    {
        string text = "We are living in  an a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        string startTag = "<upcase>";
        string endTag = "</upcase>";
        int startIndex = 0;
        int endIndex = 0;
        int upcaseLenght = 0;
        StringBuilder formatedText = new StringBuilder();

        while (true)
        {
            int found = text.IndexOf(startTag, startIndex);
            if (found< 0)
            {
                formatedText.Append(text.Substring(endIndex));
                 break;
            }
           else
            {
                startIndex = text.IndexOf(startTag,startIndex) + startTag.Length;
                formatedText.Append(text.Substring(endIndex, (startIndex -startTag.Length- endIndex)));
                endIndex = text.IndexOf(endTag,endIndex) +endTag.Length;
                upcaseLenght = endIndex - startIndex -endTag.Length;
                formatedText.Append(text.Substring(startIndex, upcaseLenght).ToUpper());
            }
       }
        Console.WriteLine(formatedText);
    }
}