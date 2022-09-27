// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace NumberSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.numSeries();
        }

        public void numSeries()
        {
            Console.WriteLine("How many Numbers do you want? : ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("---Printing Series of Numbers---");
            int value = 1;
            Console.WriteLine(value);

            for(int i = 1; i <= num; i++)
            {
                value = value * 2;
                Console.WriteLine(value);
            }
           
        }
    }
}