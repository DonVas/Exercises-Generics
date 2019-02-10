using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.GenericSwapMethodIntegers
{
    public class Program
    {
        public static void Main()
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            List<Box<int>> boxes = new List<Box<int>>();

            for (int i = 0; i < numberOfLines; i++)
            {
                var value = int.Parse(Console.ReadLine());
                Box<int> box = new Box<int>(value);

                boxes.Add(box);
            }

            int[] indexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Swap(boxes, indexes[0], indexes[1]);

            boxes.ForEach(Console.WriteLine);
        }

        public static void Swap<T>(List<Box<T>> list, int index1, int index2)
        {
            Box<T> temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
        }
    }
}
