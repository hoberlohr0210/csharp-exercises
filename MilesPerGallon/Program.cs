using System;

namespace MilesPerGallon
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string input2;
            double miles;
            double gallons;
            double total;

            Console.WriteLine("How many miles have you driven?");
            input = Console.ReadLine();
            miles = double.Parse(input);

            Console.WriteLine("How many gallons of gas have you used?");
            input2 = Console.ReadLine();
            gallons = double.Parse(input2);

            total = (miles / gallons);
            Console.WriteLine("Your miles per gallon is: " + total);
            Console.ReadLine();
        }
    }
}
