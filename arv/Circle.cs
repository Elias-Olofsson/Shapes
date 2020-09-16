using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arv
{
    class Circle: IShape
    {
        int diameter; 
        public Circle(int diameter)
        {
            this.diameter = diameter;
        }

        public double Area()
        {
            return Math.PI * diameter / 2 * diameter / 2;
        }

        public double Circumferance()
        {
            return diameter * Math.PI;
        }
    }
}
