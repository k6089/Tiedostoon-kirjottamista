using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int koko = 0;
            double desi = 0;
            string temp = null;
            double numtemp = 0;
            double kerto = 0;
            StreamWriter swint;
            StreamWriter swdoub;

            swint = new StreamWriter(@"d:\T2Integer.txt");
            swdoub = new StreamWriter(@"d:\T2Doubles.txt");

            

            do
            {
                Console.Write("Give a number (enter or not a number ends) : ");
                temp = Console.ReadLine();
                if (temp.Length == 0)
                {
                    break;
                }
                numtemp = double.Parse(temp);
                kerto = numtemp * 10;

                if (kerto % 10 == 0)
                {
                    koko = Convert.ToInt16(numtemp);
                    swint.WriteLine(koko);
                }
                else
                {
                    desi = numtemp;
                    swdoub.WriteLine(desi);
                }



            } while (temp.Length != 0);

            swdoub.Close();
            swint.Close();

        }
    }
}
