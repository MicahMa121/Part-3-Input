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
            do
            {
                Console.WriteLine(name + ", What is the Current Year?");
            }
            while (!int.TryParse(Console.ReadLine(), out year));
        }
    }
}
