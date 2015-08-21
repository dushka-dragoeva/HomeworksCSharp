namespace ClassSize
{
    using System;

    public class SizeMain
    {
        public static void Main()
        {
            var initialSize = new Size(10.0, 15.0);
            var afterRotation = Size.GetRotatedSize(initialSize, 35.5);

            Console.WriteLine(initialSize);
            Console.WriteLine(afterRotation);
        }
    }
}
