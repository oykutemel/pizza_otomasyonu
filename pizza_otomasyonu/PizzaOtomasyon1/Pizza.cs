using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOtomasyon1
{
    class Pizza : Tutar, IAd
    {
        public Ebat ebat { get; set; }
        public Kenar  kenarTipi { get; set; }
        public İcecek icecek { get; set; }
       
        public virtual string icindekiler()
        {
            List<string> malzeme = new List<string>();
            return Ad.ToString();
        }

        public override decimal toplamtutarfonksiyonu()
        {
            decimal pizzatutari = 0;
            pizzatutari = PizzaFiyat + ebat.EbatFiyat + kenarTipi.KenarFiyat + icecek.İcecekFiyat;
            return pizzatutari;
        }
       
       public int PizzaFiyat { get; set; }
        public string Ad { get; set; }
    }
}
