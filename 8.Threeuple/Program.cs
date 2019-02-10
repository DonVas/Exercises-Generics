using System;

namespace _8.Threeuple
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] lineOne = Console.ReadLine()
                .Split();
            string name = lineOne[0] + " " + lineOne[1];
            string addres = lineOne[2];
            string town = lineOne[3];

            Tuple<string, string,string> tupleOne = new Tuple<string, string,string>(name, addres,town);

            string[] lineTwo = Console.ReadLine()
                .Split();

            string secondName = lineTwo[0];
            int liters = int.Parse(lineTwo[1]);
            bool isDrunk = lineTwo[2].ToLower() == "drunk" ? true : false;
            Tuple<string, int,bool> tupleTwo = new Tuple<string, int,bool>(secondName,liters,isDrunk);

            string[] lineTree = Console.ReadLine()
                .Split();

            Tuple<string, double,string> tupleTree = new Tuple<string, double,string>(lineTree[0], double.Parse(lineTree[1]),lineTree[2]);
            Console.WriteLine(tupleOne);
            Console.WriteLine(tupleTwo);
            Console.WriteLine(tupleTree);
        }
    }
}
