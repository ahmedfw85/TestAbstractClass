using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAbstractClass
{
    class Rectangle : Shape
    {
        private double width { get; set; }
        private double height { get; set; }

        // a default constructor
        public Rectangle() : base("Rectangle")
        {
            width = 5;
            height = 10;
        }
        public Rectangle(double NewWidth, double NewHeight)
        {
            width = NewWidth;
            height = NewHeight;
        }
        public double CalcArea()
        {
            return width * height;
        }
    }
}
