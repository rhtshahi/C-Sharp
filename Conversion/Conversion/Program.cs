// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Conversion Program!!!");
            Console.WriteLine("Type I for conversion of Inch to Centimeter, G for conversion of Gallons to Litres, M for conversion of Mile to Kilometer, P for conversion of Pound to Kilogram:");
            Program program = new Program();
            char conversion_type = char.Parse(Console.ReadLine());
            

            switch (conversion_type)
            {
                case 'I':
                    program.inchToCm();
                    break;

                case 'G':
                    program.gallonsToLitres();
                    break;

                case 'M':
                    program.milesToKilometers();
                    break;

                case 'P':
                    program.poundsToKilograms();
                    break;
            }

        }

        public void inchToCm()
        {
            Console.WriteLine("Enter value of Inch to be converted into Centimeter: ");
            float inches = float.Parse(Console.ReadLine());
            double cm = inches * 2.54;
            Console.WriteLine(inches+" Inch = "+cm+" Centimeter");
            //return cm;
        }

        public void gallonsToLitres()
        {
            Console.WriteLine("Enter value of Gallons to be converted into Litres: ");
            int gal = int.Parse(Console.ReadLine());
            double lit = gal * 3.78541;
            Console.WriteLine(gal + " Gallon(s) = " + lit + " Litres");
            //return lit;
        }

        public void milesToKilometers()
        {
            Console.WriteLine("Enter value of Miles to be converted into Kilometers: ");
            float miles = float.Parse(Console.ReadLine());
            double km = miles * 1.60934;
            Console.WriteLine(miles + " Miles = " + km + " Litres");
            //return km;
        }

        public void poundsToKilograms()
        {
            Console.WriteLine("Enter value of Pound to be converted into Kilograms: ");
            float pounds = float.Parse(Console.ReadLine());
            double kg = pounds * 0.453592;
            Console.WriteLine(pounds + " Pounds = " + kg + " Kilograms");
            //return kg;
        }
    }
}
