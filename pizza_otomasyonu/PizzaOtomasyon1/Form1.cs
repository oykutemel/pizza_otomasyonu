using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOtomasyon1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_pizza.Text = "PİZZA";
            lbl_pizzaad.Text = "PİZZA";
            lbl_ebat.Text = "EBAT";
            lbl_kenar.Text = "KENAR";
            lbl_icecek.Text = "İCECEK";
            lbl_adet.Text = "ADET";
            lbl_fiyat.Text = "FİYAT";
            lbl_isim.Text = "İSİM";
            lbl_adres.Text = "ADRES";
            lbl_telefon.Text = "TELEFON";
            lbl_ödeme.Text = "ÖDEME YÖNTEMİ";
            lbl_bilgi.Text = "MÜSTERİ BİLGİSİ";
            lbl_içindekiler.Text = "PİZZANIN İCİNDEKİLER";
            lbl_sipariş.Text = "SİPARİS BİLGİSİ";
            btn_hesapla.Text = "HESAPLA";
            btn_sepet.Text = "SEPETE EKLE";
            btn_onay.Text = "SİPARİS ONAY";

            // alttaki 5

            Pizza klasik = new Klasik { Ad = "KLASİK", PizzaFiyat = 20 };

            Pizza karışık = new Karısık { Ad = "KARIŞIK", PizzaFiyat = 25 };

            Pizza napoliten = new Napoliten { Ad = "NAPOLİTEN", PizzaFiyat = 30 };

            Pizza vegan = new Vegan { Ad = "VEGAN", PizzaFiyat = 30 };

            Pizza margerita = new Margerita { Ad = "MARGERİTA", PizzaFiyat = 30 };

            lst_görünüm.SelectionMode = SelectionMode.MultiSimple;

            cmb_pizza.Items.Add(klasik);
            cmb_pizza.Items.Add(margerita);
            cmb_pizza.Items.Add(karışık);
            cmb_pizza.Items.Add(napoliten);
            cmb_pizza.Items.Add(vegan);

            Ebat Kucuk = new Ebat { Ad = "KÜÇÜK", EbatFiyat = 1 };
            Ebat Orta = new Ebat { Ad = "ORTA", EbatFiyat = 2 };
            Ebat Buyuk = new Ebat { Ad = "BÜYÜK", EbatFiyat = 3 };

            cmb_ebat.Items.Add(Kucuk);
            cmb_ebat.Items.Add(Orta);
            cmb_ebat.Items.Add(Buyuk);

            Kenar kalın = new Kenar { Ad = "KALIN", KenarFiyat = 1 };
            Kenar ince = new Kenar { Ad = "İNCE", KenarFiyat = 2 };
            Kenar kaşar = new Kenar { Ad = "KAŞAR DOLGULU", KenarFiyat = 3 };
            Kenar susamlı = new Kenar { Ad = "SUSAMLI", KenarFiyat = 2 };
            Kenar sucuk = new Kenar { Ad = "SUCUKLU", KenarFiyat = 1 };

            cmb_kenar.Items.Add(kalın);
            cmb_kenar.Items.Add(ince);
            cmb_kenar.Items.Add(kaşar);
            cmb_kenar.Items.Add(susamlı);
            cmb_kenar.Items.Add(sucuk);

            İcecek bos = new İcecek { Ad = "NO" , İcecekFiyat = 0 };
            İcecek kola = new İcecek { Ad = "KOLA", İcecekFiyat = 5};
            İcecek gazoz = new İcecek { Ad = "GAZOZ", İcecekFiyat = 5 };
            İcecek icetea = new İcecek { Ad = "İCETEA" , İcecekFiyat = 5};
            İcecek ayran = new İcecek { Ad = "AYRAN" , İcecekFiyat = 5};
            İcecek fanta = new İcecek { Ad = "FANTA" , İcecekFiyat = 5};

            lst_görünüm.SelectionMode = SelectionMode.MultiSimple;
            cmb_icecek.Items.Add(bos);

            cmb_icecek.Items.Add(kola);
            cmb_icecek.Items.Add(gazoz);
            cmb_icecek.Items.Add(icetea);
            cmb_icecek.Items.Add(ayran);
            cmb_icecek.Items.Add(fanta);
 


            cmb_ödeme.Items.Add("kredi kartı");
            cmb_ödeme.Items.Add("nakit");
        }
         
        Sİparis siparis;
        Pizza p;
      
        private void btn_hesapla_Click(object sender, EventArgs e)
        {


            if (cmb_ebat.Text == " " || cmb_icecek.Text == " " || cmb_kenar.Text == "" || cmb_pizza.Text == "")
            {
                MessageBox.Show("Lütfen Pizza Bilgilerinizi Girin ");
                return;
            }                          

                    p = (Pizza)cmb_pizza.SelectedItem;
                    p.ebat = (Ebat)cmb_ebat.SelectedItem;
                    p.kenarTipi = (Kenar)cmb_kenar.SelectedItem;
                    p.icecek = (İcecek)cmb_icecek.SelectedItem;

                     


            siparis = new Sİparis
            {
                pizza = p,
                Adet = (int)numericUpDown1.Value,
               
               
            };

            decimal tutar = (decimal)siparis.toplamtutarfonksiyonu();  
    
           txt_fiyat.Text = tutar.ToString();
        }

        private void btn_sepet_Click(object sender, EventArgs e)
        {
            if (txt_ad.Text == " " || txt_adres.Text == " " || txt_telefon.Text == "" )
            {
                MessageBox.Show("Lütfen Müşteri Bilgilerinizi Girin ");
                return;
            }

            lst_görünüm.Items.Add(siparis);


            listBox1.Items.Add(txt_ad.Text);
            listBox1.Items.Add(txt_adres.Text);
            listBox1.Items.Add(txt_telefon.Text);
            listBox2.Items.Add(p.icindekiler());


        }

        private void btn_onay_Click(object sender, EventArgs e)
        {
            
            decimal toplamtutar = 0;
            int sayac = 0;

            foreach (Sİparis siparisson in lst_görünüm.Items)
            {
                toplamtutar += siparisson.Adet* siparisson.pizza.toplamtutarfonksiyonu();
                sayac++;
            }
            //altakini ekledim

            //MessageBox.Show(toplamtutar.ToString());
            MessageBox.Show("PİZZA'NIZI  " + cmb_pizza.Text + "   İSTEMİSSİNİZ." + "\nFiyatı " + txt_fiyat.Text + "₺ dır" + "\nTELEFONU " + txt_telefon.Text + "  NUMARADIR" + "\nADRESİ  " + txt_adres.Text + "  DİR" + "\nÖDEME  YÖNTEMİ  " + cmb_ödeme.Text + "  DİR" + "\n\n\n\tTEŞEKKÜR EDERİZ", "SİPARİŞ DETAYLARI", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void txt_adres_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void txt_telefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        
    }
}
