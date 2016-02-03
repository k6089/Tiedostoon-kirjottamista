using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noppa
{
    class NopanHeitto
    {

        Random rnd = new Random();
        public int Heitto()
        {
            
            return rnd.Next(1, 7);

            
        }

    }
}
