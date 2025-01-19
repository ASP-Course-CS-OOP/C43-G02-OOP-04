using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Circle:ICircle
    {
        public double Radius { get; }

        public double Area { get { return Math.PI * Radius * Radius; } }

        public Circle(double radius)
        {
            Radius = radius;
        }
        
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle: Radius = {Radius}, Area = {Area:F2}");
        }
    }
}
