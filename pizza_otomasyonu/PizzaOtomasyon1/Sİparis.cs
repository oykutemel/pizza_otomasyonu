using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOtomasyon1
{
    class Sİparis:Tutar
    {
        public  Pizza pizza { get; set; }
        public int Adet { get; set; }
            
        public override decimal toplamtutarfonksiyonu()
        {
            decimal toplamtutar = 0;
            toplamtutar = pizza.toplamtutarfonksiyonu() * Adet;
            return toplamtutar;
        }
        public override string ToString()
        {
            string siparis1 = "";
            siparis1 += pizza.ebat.Ad + " , ";
            siparis1 += pizza.Ad + " , ";
            siparis1 += pizza.kenarTipi.Ad + " , ";
            siparis1 += pizza.icecek.Ad + " , ";
            siparis1 = siparis1.Remove(siparis1.Length - 1, 1);  //son elemandan bi öncekine git ve onu kaldır yani virgülü
            siparis1 += string.Format(" {0} *( {1})+ {2}  + {3} + {4} = {5} ", Adet, pizza.PizzaFiyat,pizza.ebat.EbatFiyat,pizza.kenarTipi.KenarFiyat,pizza.icecek.İcecekFiyat, toplamtutarfonksiyonu());

            return siparis1;
          
        }

    }
}
