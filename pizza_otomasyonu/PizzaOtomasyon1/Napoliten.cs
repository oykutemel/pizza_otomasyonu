using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOtomasyon1
{
    class Napoliten:Pizza
    {
        public override string icindekiler()
        {
            string[] malzemeler = new string [6];
            malzemeler[0] = "ançuez";
            malzemeler[1] = "kapari";
            malzemeler[2] = "kurutulmuş biber";
            malzemeler[3] = "mozerella";
            malzemeler[4] = "meksika biberi";
            malzemeler[5] = "mozerella";
          
           
            return string.Format("{0}--{1}--{2}--{3}--{4}--{5}", malzemeler[0], malzemeler[1], malzemeler[2], malzemeler[3], malzemeler[4], malzemeler[5]);
            
        }
        public override string ToString()
        {
            return string.Format("{0}--{1}", Ad, PizzaFiyat);
        }
    }
}
