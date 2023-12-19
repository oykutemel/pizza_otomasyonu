using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOtomasyon1
{
    class İcecek:IAd
    {
      
     /*   int icecekFiyat;
        public İcecek()
        {
            icecekFiyat = 5;
        }
        public int İcecekFiyat { get { return icecekFiyat; } set { icecekFiyat = value; } }
     */
     public int İcecekFiyat { get; set; }
        public string Ad { get; set; }

        public override string ToString()
        {
            return string.Format("{0}--{1}", Ad, İcecekFiyat);
        }

        
    }
}
