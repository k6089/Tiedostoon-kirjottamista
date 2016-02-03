using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_ostokset
{
    class Product
    {
        public string Ostos { get; set; }
        public double Hinta { get; set; }

        public override string ToString()
        {
            return "Ostos : " + Ostos + " " + Hinta + "e";
        }
    }
}
