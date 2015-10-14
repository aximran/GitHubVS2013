using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Module_08
{
    class Rectangle:Shape
    {
        
        public double Area()
        {
            double area = Length * Width;
            return area;
        }
    }
}
