using System;

namespace AreaOfACircle
{
    class Program
    {
        public static void Main(string[] args)
        {
            double area;
            double pi = System.Math.PI;
            double radius;
            string input;
            string mpg;
            double numMPG;
            double gas;
            double diameter;
            double circumference;

            Console.WriteLine("Enter a radius:");
            input = Console.ReadLine();
            radius = double.Parse(input);

            area = (pi * radius * radius);

            Console.WriteLine("The area of a circle of radius " + input + " is: {0:F3}", area);

            circumference = (2 * pi * radius);
            diameter = (2 * radius);
            Console.WriteLine("The circumference of this circle is: {0:F3}", circumference);
            Console.WriteLine("The diameter of this circle is: {0:F3}", diameter);

            Console.WriteLine("What's the miles per gallon of your vehicle? ");
            mpg = Console.ReadLine();
            numMPG = double.Parse(mpg);

            gas = circumference / numMPG;

            Console.WriteLine("You would use {0:F2} gallons of gas", gas);
         
        }
    }
}
