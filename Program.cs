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
            Console.WriteLine("Börja med att skriva höjd.");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv bredd.");
            int bredd = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            
            Triangle tri = new Triangle(height, 0);
        }
    }
}
