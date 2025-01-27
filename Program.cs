using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk2Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declarations

            //input
            double length = 0;
            double width = 0;

            //output
            double area = 0;
            double perimeter = 0;

            //user input the length of the rectangle
            Console.WriteLine("Enter the length of the rectangle: ");
            //collect the user input for the length
            length = Convert.ToInt32(Console.ReadLine());

            //user input the width of the rectangle
            Console.WriteLine("Enter the width of the rectangle: ");
            //collect the user input for the width
            width = Convert.ToInt32(Console.ReadLine());

            //calculate the area and perimeter of the rectangle
            area = length * width;
            perimeter = 2 * (length + width);

            //outputs the results for the area and perimeter
            Console.WriteLine($"Area of the rectangle: {area:F0}");
            Console.WriteLine($"Perimeter of the rectangle: {perimeter:F0}");
        }
    }
}
