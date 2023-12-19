using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOtomasyon1
{
    class Vegan:Pizza
    {
       
        public override string icindekiler()
        {
         
            string[] malzemeler = new string[6];
            malzemeler[0] = "mısır";
            malzemeler[1] = "biber";
            malzemeler[2] = "zeytin";
            malzemeler[3] = "vegan sucuk";
            malzemeler[4] = "vegan pizza peyniri";
           

            return string.Format("{0}--{1}--{2}--{3}--{4}", malzemeler[0], malzemeler[1], malzemeler[2], malzemeler[3], malzemeler[4]);
        }
        public override string ToString()
        {
            return string.Format("{0}--{1}", Ad, PizzaFiyat);
        }
    }
}
