using System;

namespace LineComparison
{/// <summary>
/// UC-2 For calculating equality of two lines
/// </summary>
    class Program
    {
        public static double distance(double x1, double x2, double y1, double y2)
        {
            //Using Math.pow for power,and squrt for squareroot 
            var lineLength = Math.Pow((x2 - x1), 2);
            var lineLength1 = Math.Pow((y2 - y1), 2);
            var result = Math.Sqrt(lineLength + lineLength1);

            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter x1,y1,x2,y2 coordinates for line 1: ");
            var x1 = Convert.ToDouble(Console.ReadLine());
            var y1 = Convert.ToDouble(Console.ReadLine());
            var x2 = Convert.ToDouble(Console.ReadLine());
            var y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter a1,b1,a2,b2 coordinates for line 2: ");
            double a1 = Convert.ToDouble(Console.ReadLine());
            var b1 = Convert.ToDouble(Console.ReadLine());
            var a2 = Convert.ToDouble(Console.ReadLine());
            var b2 = Convert.ToDouble(Console.ReadLine());

            //initializing two lines (line1,lin2) by calling distance method 
            var line1 = Program.distance(x1, y1, x2, y2);
            var line2 = Program.distance(a1, b1, a2, b2);
            Console.WriteLine(line1);
            Console.WriteLine(line2);

            if (double.Equals(line1, line2))
            {
                Console.WriteLine("{0} is equal to {1}", line1, line2);
            }
            else
            {
                Console.WriteLine("{0} is not equal to {1}", line1, line2);
            }
            Console.ReadLine();
        }

    }
}

