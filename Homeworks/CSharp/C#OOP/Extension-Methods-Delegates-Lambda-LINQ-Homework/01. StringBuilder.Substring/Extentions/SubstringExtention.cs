namespace _01.StringBuilder.Extentions
{
    using System.Text;
 
    public static class SubstringExtention
    {
        public static StringBuilder Substring(this StringBuilder text, int index, int length)
        {
            var result = new StringBuilder();
            var substring = text.ToString().Substring(index,length);
            result.Append(substring);
            return result;
        }
    }
}
