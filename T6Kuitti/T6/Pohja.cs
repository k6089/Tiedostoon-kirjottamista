using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class Pohja
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }



        public override string ToString()
        {
            return Name + "\t" + Price + "e " + Quantity + " pieces " + Price * Quantity + " total";
        }
    }
}
