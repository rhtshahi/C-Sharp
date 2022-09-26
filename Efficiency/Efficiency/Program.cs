// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
namespace Workerefficiency
{
    class Efficiency
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Your Efficiency");
            Console.WriteLine("How many hours do you need to complete your work?");
            Efficiency efficiency = new Efficiency();
            float no_of_hrs = float.Parse(Console.ReadLine());

            if (no_of_hrs < 2)
            {
                Console.WriteLine("Hours should be greater than or equal to 2Hr.");
            }

            else if (no_of_hrs>=2 && no_of_hrs<=3)
            {
                Console.WriteLine("You are Highly Efficient.");
            }
            else if (no_of_hrs >= 3 && no_of_hrs <= 4)
            {
                Console.WriteLine("You should increase your speed.");
            }

            else if (no_of_hrs >= 4 && no_of_hrs <= 5)
            {
                Console.WriteLine("You will be given training to increase your speed.");
            }

            else
            {
                Console.WriteLine("You must leave the company.");
            }
        }


    }
}