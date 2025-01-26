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
            int length = '0';
            int width = '0';

            //user input the length of the rectangle
            Console.WriteLine("Enter the length of the rectangle: ");
            //collect the user input for the length
            length = Convert.ToInt32(Console.ReadLine());

            //user input the width of the rectangle
            Console.WriteLine("Enter the width of the rectangle: ");
            //collect the user input for the width
            width = Convert.ToInt32(Console.ReadLine());

            //calculate the area and perimeter of the rectangle
            int area = length * width;
            int perimeter = 2 * (length + width);

            //outputs the results for the area and perimeter
            Console.WriteLine($"Area of the rectangle: {area}");
            Console.WriteLine($"Perimeter of the rectangle: {perimeter}");
        }
    }
}
