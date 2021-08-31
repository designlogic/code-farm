using System;
using CodeFarm.World.Fields;

namespace CodeFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            foreach (var animal in NorthField.Animals)
            {
                Console.WriteLine(animal.Name);
            }

        }
    }
}
