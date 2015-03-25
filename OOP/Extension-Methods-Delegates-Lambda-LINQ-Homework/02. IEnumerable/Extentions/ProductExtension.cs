namespace _02.IEnumerable.Extentions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class ProductExtension
    {
        public static T ProductExt<T>(this IEnumerable<T> enumeration)
        {
            dynamic result = 1;
            foreach (var item in enumeration)
            {
                result *= item;
            }
            return result;
        }
    }
}
