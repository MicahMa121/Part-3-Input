using System.Xml.Linq;

namespace Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, What is Your Name?");
            string name = Console.ReadLine();
            int age;
            int year;
            do
            {
                Console.WriteLine(name + ", How Old Are You?");
            }
            while (!int.TryParse(Console.ReadLine(), out age));
            Console.WriteLine(name + ", What is the Current Year? (Press \"ENTER\" to use default time)");
            if (!int.TryParse(Console.ReadLine(), out year))
            {
                year = DateTime.Today.Year;
            }
                Console.WriteLine("You were born in " + (year - age) + "!");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("I'll add 3 numbers up!");
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                int addend;
                do
                {
                    Console.WriteLine("Please Enter Number " +(i+1) + "!");
                }
                while (!int.TryParse(Console.ReadLine(),out addend));
                sum = sum + addend;
            }
            Console.WriteLine("The sum of the 3 numbers is "+sum+"!");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("I'll find the average of the 3 distance!");
            double distance = 0;
            for (int i = 0; i < 3; i++)
            {
                double addend;
                do
                {
                    Console.WriteLine("Please Enter Distance " + (i+1) + "!(Do not include the unit)");
                }
                while (!double.TryParse(Console.ReadLine(), out addend));
                distance = distance + addend;
            }
            Console.WriteLine("The average of the 3 distance is " + (distance/3).ToString("0.00") + "!");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("I'll solve for the length of the hypotenuse!");
            double leg1;
            do
            {
                Console.WriteLine("Please enter the length of leg " + 1 + "!(Do not include the unit)");
            }
            while (!double.TryParse(Console.ReadLine(), out leg1));
            double leg2;
            do
            {
                Console.WriteLine("Please enter the length of leg " + 2 + "!(Do not include the unit)");
            }
            while (!double.TryParse(Console.ReadLine(), out leg2));
            Console.WriteLine("The length of the hypotenuse is "+(Math.Sqrt(Math.Pow(leg1,2)+ Math.Pow(leg2, 2))).ToString("0.00") + "!");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
