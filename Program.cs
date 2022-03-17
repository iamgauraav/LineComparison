using System;

namespace LineComparison
{
    class Program
    {/// <summary>
     /// UC1 For calculating length of two lines 
     /// </summary>
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter x1 and y1 coordinates: ");
            var x1 = Convert.ToDouble(Console.ReadLine());
            var y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter x2 and y2 coordinates: ");
            var x2 = Convert.ToDouble(Console.ReadLine());
            var y2 = Convert.ToDouble(Console.ReadLine());

            var finalResult = Distance(x1, x2, y1, y2);
            //Initializing by calling final result 
            Console.WriteLine("Distance between coordinates {0},{1} and {2},{3} is {4:F}", x1, y1, x2, y2, finalResult);
            Console.ReadLine();


        }
         static double Distance(double x1, double x2, double y1, double y2)
        {
            //Using Math.pow for power,and squrt for squareroot 
            var temp1 = Math.Pow((x2 - x1), 2);
            var temp2 = Math.Pow((y2 - y1), 2);
            var result = Math.Sqrt(temp1 + temp2);


            return result;
        }
    }
}
