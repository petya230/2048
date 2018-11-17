using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048
{
    class Jatek
    {
        Palya palya = new Palya();
        public Jatek()
        {
            palya.FelEpit();
            do
            {
                palya.Kiir();
                palya.Mozgas();
            } while (palya.NyertVagyVeszett());
        }

    }
}
