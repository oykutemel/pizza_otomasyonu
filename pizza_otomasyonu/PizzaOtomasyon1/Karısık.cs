using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOtomasyon1
{
    class Karısık:Pizza
    {
        public override string icindekiler()
        {
          
            string[] malzemeler = new string[6];
            malzemeler[0] = "kaşar";
            malzemeler[1] = "sucuk";
            malzemeler[2] = "zeytin";
            malzemeler[3] = "mısır";
            malzemeler[4] = "mantar";
            malzemeler[5] = "salam";
            malzemeler[5] = "sosis";

            return string.Format("{0}--{1}--{2}--{3}--{4}--{5}", malzemeler[0], malzemeler[1], malzemeler[2], malzemeler[3], malzemeler[4], malzemeler[5]);
        }
        public override string ToString()
        {
            return string.Format("{0}--{1}", Ad, PizzaFiyat);
        }
    }
}
