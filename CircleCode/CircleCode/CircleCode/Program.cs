using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleCode
{
    class Program
    {
        static decimal PI = 3.14159m;

        static void Main(string[] args)
        {
            Console.OpenStandardInput();
            bool inputtingData = true;
            decimal circleArea;
            decimal circleCircumference;

            while (inputtingData)
            {
                Console.Write("Enter the radius of a circle: (type ? to end)");
                string data = Console.ReadLine();
                if(data == "?")
                {
                    inputtingData = false;
                    break;
                }
                decimal result;
                if (decimal.TryParse(data, out result))
                {

                    circleArea = computeCircleArea(result);
                    circleCircumference = computeCircleCircumference(result);
                    Console.WriteLine("Area = {0}", circleArea);
                    Console.WriteLine("Circumference = {0}", circleCircumference);

                }
                else
                {
                    Console.WriteLine("Illegal Characters, Try again");
                }
            }


        }
        static decimal computeCircleArea(decimal radius)
        {
            decimal area = Program.PI * radius*radius;
            return area;
        }
        static decimal computeCircleCircumference(decimal radius)
        {
            decimal circum = 2.0m * Program.PI * radius;
            return circum;
        }
    }
}
