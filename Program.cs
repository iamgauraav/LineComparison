using System;

namespace LineComparison
{/// <summary>
/// UC-2 For calculating equality of two lines
/// </summary>
    class Program
    {
        public static double distance(int x1, int x2, int y1, int y2)
        {
            //Using Math.pow for power,and squrt for squareroot 
            double lineLength = Math.Pow((x2 - x1), 2);
            double lineLength1 = Math.Pow((y2 - y1), 2);
            double result = Math.Sqrt(lineLength + lineLength1);

            return result;
        }
        public static void comparingLines(string len1, string len2)
        {
            if (len1.CompareTo(len2) > 0)
            {
                Console.WriteLine("Line1 is greter than Line2");
            }
            else if (len1.CompareTo(len2) < 0)
            {
                Console.WriteLine("Line1 is less than Line2");
            }
            else
            {
                Console.WriteLine("Both Lines are equal");
            }
        }

        static void Main(string[] args)
        {
            //Initialing two lines by calling distance method 
            double line1 = Program.distance(1, 2, 3, 4);
            double line2 = Program.distance(1, 6, 4, 5);

            Program.comparingLines(line1.ToString(), line2.ToString());
            Console.ReadLine();
        }

    }
}

