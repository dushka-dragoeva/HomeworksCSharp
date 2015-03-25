namespace _02.IEnumerable.Extentions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class AvarageExtention
    {
        public static T AvarigeExt<T>(this IEnumerable<T> enumeration)
        {
            dynamic result = 0;
            foreach (var item in enumeration)
            {
                result += item;
            }
            return result/enumeration.Count();
        }
    }
}
