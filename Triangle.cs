using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arv
{
    class Triangle : Shape
    {
        public Triangle(int height, int witdh):base(height, witdh)
        {
           
        }

        public int Area()
        {
            return 
                (height * width) /2;
        }

        public int Circumferance()
        {
            return
                width * 3;
        }
    }
}
