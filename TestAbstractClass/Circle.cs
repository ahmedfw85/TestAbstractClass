using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAbstractClass
{
    class Circle : Shape
    {

        private double radius { get; set; }

        // a default constructor
        public Circle(): base("circle")
        {
            radius = 0.5;
        }
        public Circle(double NewRadius)
        {
            radius = NewRadius;
        }
        public double CalcArea()
        {
            return Math.PI * radius * radius;
        }
    }
}
