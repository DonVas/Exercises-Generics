﻿using System;

namespace _1._Generic_Box_of_String
{
    public class Program
    {
        public static void Main()
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                string value = Console.ReadLine();
                Box<string> box = new Box<string>(value);

                Console.WriteLine(box);
            }
        }
    }
}
