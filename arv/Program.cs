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
            Console.WriteLine("Skriv in höjden.");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in Bredden.");
            int width = int.Parse (Console.ReadLine());
            Console.WriteLine("Skriv in antingen rätvinklig triangel eller rektangel");
            Triangle triangle1 = new Triangle(height, width);
            Rektangle rektangle1 = new Rektangle(height, width);
            if (Console.ReadLine() == "rätvinklig triangel")
            {
                Console.WriteLine("arean och omkretsen är:" + triangle1.Area() + ", " + triangle1.Circumferance());
            }
            else if (Console.ReadLine() == "rektangle")
            {
                Console.WriteLine("arean och omkretsen är:" + rektangle1.Area() + ", " + rektangle1.Circumferance());
            }

            Rektangle shape = new Rektangle(1,1);
        }
    }
}
