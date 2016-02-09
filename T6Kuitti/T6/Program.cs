using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pohja> kuitti = new List<Pohja>();

            kuitti.Add(new Pohja { Name = "Milk", Price = 1.75, Quantity = 1 });
            kuitti.Add(new Pohja { Name = "Beer", Price = 5.25, Quantity = 1 });
            kuitti.Add(new Pohja { Name = "Butter", Price = 2.52, Quantity = 1 });

            string Customer;

            Console.Write("Who was shopping ?  ");
            Customer = Console.ReadLine();



            Console.Clear();

            Console.WriteLine("Customer " + Customer + "'s invoice:\n=================================");

            foreach (Pohja summa in kuitti)
            {
                Console.WriteLine(summa.ToString());
            }
            Console.WriteLine("=================================");

        }
    }
}
