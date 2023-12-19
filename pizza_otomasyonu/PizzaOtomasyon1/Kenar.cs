using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOtomasyon1
{
    class Kenar:IAd
    {
         public int KenarFiyat { get; set; }
    
        public string Ad { get; set; }

        public string icindekiler()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return string.Format("{0}--{1}", Ad, KenarFiyat);
        }
    }
}
