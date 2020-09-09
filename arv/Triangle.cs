using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arv
{
    class Triangle : IShape
    {
        int height;
        int width;
        public Triangle(int height, int witdh)
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
                width + height + (int)Math.Sqrt(width * width + height * height);
        }
    }
}
