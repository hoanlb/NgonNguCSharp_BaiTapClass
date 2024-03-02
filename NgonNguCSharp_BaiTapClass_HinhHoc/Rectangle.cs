using System;
using System.Data;

namespace Models
{
    internal class Rectangle : Shape
    {
        private int width = 1;
        private int length = 2;

        public Rectangle()
        {
        }

        public double GetArea()
        {
            return width * this.length;
        }

        public double GetPerimeter()
        {
            return 2 * (width + this.length);
        }
    }
}
