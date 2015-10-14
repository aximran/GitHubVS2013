using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Module_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.Length = 4.0;
            r.Width = 5.0;

            double area = r.Area();
            Console.Write("Area of the Rectangle::" + area + "\n"  );
            Console.Read();
        }
    }
}
