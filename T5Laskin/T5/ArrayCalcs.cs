using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5
{
    public class ArrayCalcs
    {
        public static void Lasku(double[] x)
        {
            double[] array = x;

            // double Sum = array.Sum();
            // double Average = array.Average();
            // double Min = array.Min();
            // double Max = array.Max();

            Console.WriteLine("Sum = {0:f2}", array.Sum());
            Console.WriteLine("Ave = {0:f2}", array.Average());
            Console.WriteLine("Min = {0:f2}", array.Min());
            Console.WriteLine("Max = {0:f2}", array.Max());
        }
    }

}
