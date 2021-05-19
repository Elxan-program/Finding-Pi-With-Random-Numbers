using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finding_П__With_Random_Numbers
{
    class Program
    {
        private static readonly Random Random = new Random();
        static void Main(string[] args)
        {
            int countInCircle = 0;
            int countAll = 0;


            Console.WriteLine("Enter Number of Points : ");

            countAll = Int32.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            // write : 100000000

            for (int i = 0; i < countAll; i++)
            {
                double x = RandFrom0To1();
                double y = RandFrom0To1();

                if (Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)) <= 1)
                {
                    countInCircle++;
                }
            }

            double Pi = 4 * (double)countInCircle / countAll;
            Console.WriteLine($"Pi : {Pi}");
        }
        private static double RandFrom0To1()
        {
            return Random.NextDouble();
        }
    }
}

