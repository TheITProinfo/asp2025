using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1day7demo5
{
    public static class Utility
    {
        public static double PI = 3.14159;

        public static double Square(int x)
        {
            return PI * x * x;
        }

        // calculator the square of the rectangle
        public static double RecSquare(double width, double length)
        {
            return width * length;

        }
    }
}
