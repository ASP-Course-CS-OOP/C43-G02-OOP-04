using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Rectangle: IRectangle
    {
        public double Width { get; }
        public double Height { get; }
        public double Area { get { return Width * Height; } }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }


        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangle: Width = {Width}, Height = {Height}, Area = {Area:F2}");
        }
    }
}
