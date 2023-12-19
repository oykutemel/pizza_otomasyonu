using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOtomasyon1
{
    class Ebat:IAd
    {
    
        public int EbatFiyat { get; set; }
        public string Ad { get; set; }

        public override string ToString()
        {
            return string.Format("{0}--{1}", Ad, EbatFiyat);
        }
    }
}
