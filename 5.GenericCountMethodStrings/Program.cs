using System;
using System.Collections.Generic;

namespace _5.GenericCountMethodStrings
{
    public class Program
    {
        public static void Main()
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            List<Box<string>> boxes = new List<Box<string>>();

            for (int i = 0; i < numberOfLines; i++)
            {
                var value = Console.ReadLine();
                Box<string> box = new Box<string>(value);                
                boxes.Add(box);
            }

            var valueToCompare = Console.ReadLine();
            Console.WriteLine(CountCompare(boxes,valueToCompare));
        }

        public static int CountCompare<T>(IEnumerable<Box<T>> collection, T item)
            where T : IComparable<T>
        {
            int count = 0;

            foreach (var box in collection)
            {
                if (box.CompareTo(item)>0)
                {
                    count++;
                }       
            }

            return count;

        }
    }
}
