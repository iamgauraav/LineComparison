using System;

namespace LineComparison
{/// <summary>
/// UC-3 For comparing two lines
/// </summary>
    class Program
    {
        public int x1, y1, x2, y2;

        public void LineComparison()
        {
            double[] StoreCoords = new double[5];
            for (int i = 1; i < 2; i++)
            {
                Console.WriteLine("Enter coordinate-x1:");
                this.x1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter coordinate-y1:");
                this.y1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter coordinate-x2:");
                this.x2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter coordinate-y2:");
                this.y2 = Convert.ToInt32(Console.ReadLine());
            }
        }

        public double Length()
        {
            // To evaluate math expression Math method() used
            double lineLength = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            //Round method() used for rounding decimal value up to 2 digit
            double length = Math.Round(lineLength, 2);
            return length;
        }

        public void Equal(string line1, string line2)
        {
            //Using Equals method() to check eqyality of two line 
            if (double.Equals(line1, line2))
            {
                Console.WriteLine("{0} is equals to {1}", line1, line2);
            }
            else
            {
                Console.WriteLine("{0} is not equal to {1}", line1, line2);
            }
        }

        //creating a comparing line method 
        public void ComparingLines(string line1, string line2)
        {
            if (line1.CompareTo(line2) > 0)
            {
                Console.WriteLine("Line1 is greater than line2");
            }
            else if (line1.CompareTo(line2) < 0)
            {
                Console.WriteLine("Line1 is lesser than line2");
            }
            else
            {
                Console.WriteLine("Both lines are equal");
            }
        }

        static void Main(string[] args)
        {
            //creating objects 
            Program obj1 = new Program();
            double line1 = obj1.Length();
            Program obj2 = new Program();
            double line2 = obj2.Length();
            Console.WriteLine("Length of the first line " + line1);
            Console.WriteLine("Length of the secod line " + line2);
            obj1.Equal(line1.ToString(), line2.ToString());
            obj1.ComparingLines(line1.ToString(), line2.ToString());
            Console.ReadLine();
        }

    }
}

