using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noppa
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            double kerta = 0;
            double ka = 0;
            double heitot = 0;
            int yks = 0, kaks = 0, kolme = 0, nelja = 0, viis = 0, kuus = 0;


            Console.Write("How many times you want to throw a dice : ");
            kerta = int.Parse(Console.ReadLine());
            // luodaan olio Noppa-luokassa
            
            NopanHeitto noppa = new NopanHeitto();

            for (i = 1; i < kerta; i++)
            {
                int luku = noppa.Heitto(); // 1-6
                heitot = heitot + luku;

                switch (luku)
                {
                    case 1:
                        yks++;
                        break;
                    case 2:
                        kaks++;
                        break;
                    case 3:
                        kolme++;
                        break;
                    case 4:
                        nelja++;
                        break;
                    case 5:
                        viis++;
                        break;
                    case 6:
                        kuus++;
                        break;
                }
            }
            ka = (heitot / kerta);
            Console.WriteLine("\nDice is now thrown {0} times\n- average is {1:f4}", kerta, ka);
            Console.WriteLine("- 1 count is {0}", yks);
            Console.WriteLine("- 2 count is {0}", kaks);
            Console.WriteLine("- 3 count is {0}", kolme);
            Console.WriteLine("- 4 count is {0}", nelja);
            Console.WriteLine("- 5 count is {0}", viis);
            Console.WriteLine("- 6 count is {0}\n", kuus);

        }
    }
}
