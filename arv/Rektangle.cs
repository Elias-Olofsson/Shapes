using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arv
{
    class Rektangle : Shape
    {
        public Rektangle(int height, int witdh) : base(height, witdh)
        {

        }

        public int Area()
        {
            return
                height * width;
        }

        public int Circumferance()
        {
            return
                height * 2 + width * 2;
        }
    }
}
