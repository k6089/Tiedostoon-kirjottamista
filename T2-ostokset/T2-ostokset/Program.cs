using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_ostokset
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            products.Add(new Product { Ostos = "Milk", Hinta = 1.4 });
            products.Add(new Product { Ostos = "Beer", Hinta = 2.2 });
            products.Add(new Product { Ostos = "Butter", Hinta = 3.2 });
            products.Add(new Product { Ostos = "Cheese", Hinta = 4.2 });

            foreach (Product product in products)
            {
                Console.WriteLine(product.ToString());
            }

        }
    }
}
