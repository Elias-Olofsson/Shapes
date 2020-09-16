using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arv
{
    class Rektangle: IShape
    {
        int height;
        int width;
        public Rektangle(int height, int width)
        {
            this.height = height;
            this.width = width;
        }

        public double Area()
        {
            return
                height * width;
        }

        public double Circumferance()
        {
            return
                height * 2 + width * 2;
        }
    }
}
