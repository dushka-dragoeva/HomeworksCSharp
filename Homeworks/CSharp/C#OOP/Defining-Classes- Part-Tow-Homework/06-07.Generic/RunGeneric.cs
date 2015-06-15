/*
Problem 5. Generic class
Write a generic class GenericList<T> that keeps a list of elements of some parametric type T.
Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor.
Implement methods for adding element, accessing element by index, removing element by index, inserting element at given position, 
 clearing the list, finding element by its value and ToString().
Check all input parameters to avoid accessing elements at invalid positions.
Problem 6. Auto-grow
Implement auto-grow functionality: when the internal array is full, create a new array of double size and move all elements to it.
Problem 7. Min and Max
Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the GenericList<T>.
You may need to add a generic constraints for the type T.
*/

namespace _06_07.Generic
{
    using System;
   

    class RunGeneric
    {
        static void Main(string[] args)
        {
            var items = new GenericList<int>(5);
            items.Add(13);
            items.Add(450);
            items.Add(-7);
            items.Add(13);
            items.Add(66);
            items.Add(-17);
            Console.WriteLine("Max element is: "+items.Max());
            Console.WriteLine("Min element is: "+ items.Min());
            Console.WriteLine(items.ToString());
            items.RemoveElement(3);
            Console.WriteLine(items.ToString());
            items.InsertElement(4, 33);
            Console.WriteLine(items.ToString());
            Console.WriteLine("The index of 33 is {0}",items.IndexOf(33));
            items.ClearList();
            items.Add(5);
            Console.WriteLine(items.ToString());
        }
    }
}
