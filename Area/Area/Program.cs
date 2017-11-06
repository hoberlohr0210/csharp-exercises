using System;

namespace Area
{
    class ElseIf
    {
        static void Main(string[] args)
        {
            double radius;
            string input;
            double area;

            Console.WriteLine("Enter the radius: ");
            input = Console.ReadLine();
            radius = double.Parse(input);

            if (radius < 1)
            {
                Console.WriteLine("Please enter a positive number.");
                Console.ReadLine();
            }
            else if (radius > 1)
            {
                area = (3.14 * radius * radius);
                Console.WriteLine("The Area is: " + area);
                Console.ReadLine();
            }
        }
    }
}
