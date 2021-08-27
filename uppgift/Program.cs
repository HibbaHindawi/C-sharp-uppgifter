using System;

namespace uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Är det fint väder? Y/N");
            string weather= Console.ReadLine();
            if (weather == "Y" || weather == "y")
            {
                Console.WriteLine("Vi går på picknick!");}
            else if (weather == "N" || weather == "n")
            {
                Console.WriteLine("Vi stannar inne och läser en bok.");
            }
            else
            {
                Console.WriteLine("Jag förstår inte!");
            }
            Console.Read();
        }
    }
}
