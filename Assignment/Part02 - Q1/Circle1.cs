using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Circle1 : ICircle1
    {

        #region Properties
        
        public double Radius { get; set; }
        public double Area { get => 3.14 * Radius * Radius; }

        #endregion

        #region Constructors
        
        public Circle1(double radius)
        {
            Radius = radius;
        }

        #endregion

        #region Methods
        
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle Radius = {Radius}");
            Console.WriteLine($"Circle Area = {Area}");
            Console.WriteLine("Circle Shape => ");
            double centerX = Radius;  // Center X-coordinate
            double centerY = Radius;  // Center Y-coordinate

            for (int y = 0; y <= 2 * Radius; y++) // Loop for rows
            {
                for (int x = 0; x <= 2 * Radius; x++) // Loop for columns
                {
                    // Calculate distance from the center
                    double distance = Math.Sqrt(Math.Pow(x - centerX, 2) + Math.Pow(y - centerY, 2));

                    // Print '*' if the point is close to the circle's edge
                    if (Math.Abs(distance - Radius) < 0.5)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine(); // Move to the next line
            }
        } 

        #endregion

    }
}
