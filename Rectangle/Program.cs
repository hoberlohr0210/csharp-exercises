using System;

namespace AreaOfRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string input2;
            double length;
            double width;
            double area;

            Console.WriteLine("What is the length?");
            input = Console.ReadLine();
            length = double.Parse(input);

            Console.WriteLine("What is the width?");
            input2 = Console.ReadLine();
            width = double.Parse(input2);

            area = (length * width);
            Console.WriteLine("The area is: " + area);
            Console.ReadLine();
        }
    }
}
