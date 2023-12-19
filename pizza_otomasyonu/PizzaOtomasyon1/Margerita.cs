using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOtomasyon1
{
    class Margerita:Pizza
    {
        public override string icindekiler()
        {
            string[] malzemeler = new string[6];
            malzemeler[0] = "mozerella";
            malzemeler[1] = "domates";
            malzemeler[2] = "fesleğen yaprakları";


            return string.Format("{0}--{1}--{2}", malzemeler[0], malzemeler[1], malzemeler[2]);
        }
        public override string ToString()
        {
            return string.Format("{0}--{1}", Ad, PizzaFiyat);
        }
    }
}
