namespace _02.IEnumerable.Extentions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class MaxExtention
    {
        public static T MaxExt<T>(this IEnumerable<T> enumeration) where T : IConvertible, IComparable
        {
            dynamic maxValue = enumeration.First();
            foreach (var item in enumeration)
            {
                if (item.CompareTo(maxValue) > 0)
                {
                    maxValue = item;
                }
            }
            return maxValue;
        }
    }
}
