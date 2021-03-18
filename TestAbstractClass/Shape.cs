using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAbstractClass
{
    abstract class Shape
    {
        //field or variable 
        private string name;

        // a default constructor
        public Shape()
        {
            name = "Unknown";
        }
        //constructor with one input
        public Shape(string newName)
        {
            name = newName;
        }

        public void setName(string newName)
        {
            name = newName;
        }
    }
}
