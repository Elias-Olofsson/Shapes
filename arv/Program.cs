using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arv
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv bara heltal.");
            Console.WriteLine("Skriv in höjden.");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in Bredden.");
            int width = int.Parse (Console.ReadLine());
            Console.WriteLine("Skriv in antingen cirkel, rätvinklig triangel eller rektangel");
            Triangle triangle1 = new Triangle(height, width);
            Rektangle rektangle1 = new Rektangle(height, width);
            Circle circle1 = new Circle(width);
            string input = Console.ReadLine();
            if (input == "rätvinklig triangel")
            {
                Console.WriteLine("arean och omkretsen är:" + triangle1.Area() + ", " + triangle1.Circumferance());
            }
            else if (input == "rektangel")
            {
                Console.WriteLine("arean och omkretsen är:" + rektangle1.Area() + ", " + rektangle1.Circumferance());
            }
            else if (input == "cirkel")
            {
                Console.WriteLine("arean och omkretsen är:" + circle1.Area() + ", " + circle1.Circumferance());
            }
            Console.Read();
        }
    }
}
