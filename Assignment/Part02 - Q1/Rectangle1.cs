using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Rectangle1 : IRectangle1
    {

        #region Properties
        
        public int Height { get; set; }
        public int Width { get; set; }
        public double Area { get => Height * Width; }

        #endregion

        #region Constructors

        public Rectangle1(int height, int width)
        {
            Height = height;
            Width = width;
        }

        #endregion

        #region Methods
        
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangle Height = {Height}, Width = {Width}");
            Console.WriteLine($"Rectangle Area = {Area}");
            Console.WriteLine("Rectangle Shape => ");
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    // Print '*' for the border, space for the inside
                    if (i == 0 || i == Height - 1 || j == 0 || j == Width - 1)
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
