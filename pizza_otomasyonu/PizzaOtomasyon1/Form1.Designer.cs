
namespace PizzaOtomasyon1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_pizza = new System.Windows.Forms.Label();
            this.lbl_pizzaad = new System.Windows.Forms.Label();
            this.lbl_ebat = new System.Windows.Forms.Label();
            this.lbl_kenar = new System.Windows.Forms.Label();
            this.lbl_icecek = new System.Windows.Forms.Label();
            this.lbl_adet = new System.Windows.Forms.Label();
            this.lbl_fiyat = new System.Windows.Forms.Label();
            this.lbl_isim = new System.Windows.Forms.Label();
            this.lbl_adres = new System.Windows.Forms.Label();
            this.lbl_telefon = new System.Windows.Forms.Label();
            this.lbl_ödeme = new System.Windows.Forms.Label();
            this.btn_hesapla = new System.Windows.Forms.Button();
            this.btn_sepet = new System.Windows.Forms.Button();
            this.btn_onay = new System.Windows.Forms.Button();
            this.cmb_pizza = new System.Windows.Forms.ComboBox();
            this.cmb_ebat = new System.Windows.Forms.ComboBox();
            this.cmb_kenar = new System.Windows.Forms.ComboBox();
            this.cmb_icecek = new System.Windows.Forms.ComboBox();
            this.cmb_ödeme = new System.Windows.Forms.ComboBox();
            this.txt_telefon = new System.Windows.Forms.TextBox();
            this.txt_adres = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.lst_görünüm = new System.Windows.Forms.ListBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txt_fiyat = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.lbl_bilgi = new System.Windows.Forms.Label();
            this.lbl_içindekiler = new System.Windows.Forms.Label();
            this.lbl_sipariş = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_pizza
            // 
            this.lbl_pizza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_pizza.Font = new System.Drawing.Font("Ravie", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pizza.Location = new System.Drawing.Point(-59, -6);
            this.lbl_pizza.Name = "lbl_pizza";
            this.lbl_pizza.Size = new System.Drawing.Size(1030, 49);
            this.lbl_pizza.TabIndex = 0;
            this.lbl_pizza.Text = "label1";
            this.lbl_pizza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_pizzaad
            // 
            this.lbl_pizzaad.AutoSize = true;
            this.lbl_pizzaad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_pizzaad.Location = new System.Drawing.Point(22, 54);
            this.lbl_pizzaad.Name = "lbl_pizzaad";
            this.lbl_pizzaad.Size = new System.Drawing.Size(35, 13);
            this.lbl_pizzaad.TabIndex = 1;
            this.lbl_pizzaad.Text = "label2";
            // 
            // lbl_ebat
            // 
            this.lbl_ebat.AutoSize = true;
            this.lbl_ebat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_ebat.Location = new System.Drawing.Point(22, 93);
            this.lbl_ebat.Name = "lbl_ebat";
            this.lbl_ebat.Size = new System.Drawing.Size(35, 13);
            this.lbl_ebat.TabIndex = 2;
            this.lbl_ebat.Text = "label3";
            // 
            // lbl_kenar
            // 
            this.lbl_kenar.AutoSize = true;
            this.lbl_kenar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_kenar.Location = new System.Drawing.Point(22, 125);
            this.lbl_kenar.Name = "lbl_kenar";
            this.lbl_kenar.Size = new System.Drawing.Size(35, 13);
            this.lbl_kenar.TabIndex = 3;
            this.lbl_kenar.Text = "label4";
            // 
            // lbl_icecek
            // 
            this.lbl_icecek.AutoSize = true;
            this.lbl_icecek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_icecek.Location = new System.Drawing.Point(22, 161);
            this.lbl_icecek.Name = "lbl_icecek";
            this.lbl_icecek.Size = new System.Drawing.Size(35, 13);
            this.lbl_icecek.TabIndex = 4;
            this.lbl_icecek.Text = "label5";
            // 
            // lbl_adet
            // 
            this.lbl_adet.AutoSize = true;
            this.lbl_adet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_adet.Location = new System.Drawing.Point(22, 198);
            this.lbl_adet.Name = "lbl_adet";
            this.lbl_adet.Size = new System.Drawing.Size(35, 13);
            this.lbl_adet.TabIndex = 5;
            this.lbl_adet.Text = "label6";
            // 
            // lbl_fiyat
            // 
            this.lbl_fiyat.AutoSize = true;
            this.lbl_fiyat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_fiyat.Location = new System.Drawing.Point(22, 273);
            this.lbl_fiyat.Name = "lbl_fiyat";
            this.lbl_fiyat.Size = new System.Drawing.Size(35, 13);
            this.lbl_fiyat.TabIndex = 6;
            this.lbl_fiyat.Text = "label7";
            // 
            // lbl_isim
            // 
            this.lbl_isim.AutoSize = true;
            this.lbl_isim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_isim.Location = new System.Drawing.Point(22, 314);
            this.lbl_isim.Name = "lbl_isim";
            this.lbl_isim.Size = new System.Drawing.Size(35, 13);
            this.lbl_isim.TabIndex = 7;
            this.lbl_isim.Text = "label8";
            // 
            // lbl_adres
            // 
            this.lbl_adres.AutoSize = true;
            this.lbl_adres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_adres.Location = new System.Drawing.Point(22, 360);
            this.lbl_adres.Name = "lbl_adres";
            this.lbl_adres.Size = new System.Drawing.Size(35, 13);
            this.lbl_adres.TabIndex = 8;
            this.lbl_adres.Text = "label9";
            // 
            // lbl_telefon
            // 
            this.lbl_telefon.AutoSize = true;
            this.lbl_telefon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_telefon.Location = new System.Drawing.Point(22, 405);
            this.lbl_telefon.Name = "lbl_telefon";
            this.lbl_telefon.Size = new System.Drawing.Size(41, 13);
            this.lbl_telefon.TabIndex = 9;
            this.lbl_telefon.Text = "label10";
            // 
            // lbl_ödeme
            // 
            this.lbl_ödeme.AutoSize = true;
            this.lbl_ödeme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_ödeme.Location = new System.Drawing.Point(22, 455);
            this.lbl_ödeme.Name = "lbl_ödeme";
            this.lbl_ödeme.Size = new System.Drawing.Size(41, 13);
            this.lbl_ödeme.TabIndex = 10;
            this.lbl_ödeme.Text = "label11";
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_hesapla.Location = new System.Drawing.Point(25, 233);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(264, 23);
            this.btn_hesapla.TabIndex = 11;
            this.btn_hesapla.Text = "button1";
            this.btn_hesapla.UseVisualStyleBackColor = false;
            this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click);
            // 
            // btn_sepet
            // 
            this.btn_sepet.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_sepet.Location = new System.Drawing.Point(25, 502);
            this.btn_sepet.Name = "btn_sepet";
            this.btn_sepet.Size = new System.Drawing.Size(264, 42);
            this.btn_sepet.TabIndex = 12;
            this.btn_sepet.Text = "button2";
            this.btn_sepet.UseVisualStyleBackColor = false;
            this.btn_sepet.Click += new System.EventHandler(this.btn_sepet_Click);
            // 
            // btn_onay
            // 
            this.btn_onay.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_onay.Location = new System.Drawing.Point(387, 502);
            this.btn_onay.Name = "btn_onay";
            this.btn_onay.Size = new System.Drawing.Size(504, 42);
            this.btn_onay.TabIndex = 13;
            this.btn_onay.Text = "button3";
            this.btn_onay.UseVisualStyleBackColor = false;
            this.btn_onay.Click += new System.EventHandler(this.btn_onay_Click);
            // 
            // cmb_pizza
            // 
            this.cmb_pizza.FormattingEnabled = true;
            this.cmb_pizza.Location = new System.Drawing.Point(168, 46);
            this.cmb_pizza.Name = "cmb_pizza";
            this.cmb_pizza.Size = new System.Drawing.Size(121, 21);
            this.cmb_pizza.TabIndex = 14;
            // 
            // cmb_ebat
            // 
            this.cmb_ebat.FormattingEnabled = true;
            this.cmb_ebat.Location = new System.Drawing.Point(168, 85);
            this.cmb_ebat.Name = "cmb_ebat";
            this.cmb_ebat.Size = new System.Drawing.Size(121, 21);
            this.cmb_ebat.TabIndex = 15;
            // 
            // cmb_kenar
            // 
            this.cmb_kenar.FormattingEnabled = true;
            this.cmb_kenar.Location = new System.Drawing.Point(168, 122);
            this.cmb_kenar.Name = "cmb_kenar";
            this.cmb_kenar.Size = new System.Drawing.Size(121, 21);
            this.cmb_kenar.TabIndex = 16;
            // 
            // cmb_icecek
            // 
            this.cmb_icecek.FormattingEnabled = true;
            this.cmb_icecek.Location = new System.Drawing.Point(168, 158);
            this.cmb_icecek.Name = "cmb_icecek";
            this.cmb_icecek.Size = new System.Drawing.Size(121, 21);
            this.cmb_icecek.TabIndex = 17;
            // 
            // cmb_ödeme
            // 
            this.cmb_ödeme.FormattingEnabled = true;
            this.cmb_ödeme.Location = new System.Drawing.Point(168, 452);
            this.cmb_ödeme.Name = "cmb_ödeme";
            this.cmb_ödeme.Size = new System.Drawing.Size(121, 21);
            this.cmb_ödeme.TabIndex = 20;
            // 
            // txt_telefon
            // 
            this.txt_telefon.Location = new System.Drawing.Point(168, 402);
            this.txt_telefon.Name = "txt_telefon";
            this.txt_telefon.Size = new System.Drawing.Size(121, 20);
            this.txt_telefon.TabIndex = 23;
            this.txt_telefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telefon_KeyPress);
            // 
            // txt_adres
            // 
            this.txt_adres.Location = new System.Drawing.Point(168, 353);
            this.txt_adres.Name = "txt_adres";
            this.txt_adres.Size = new System.Drawing.Size(121, 20);
            this.txt_adres.TabIndex = 24;
            this.txt_adres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_adres_KeyPress);
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(168, 308);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(121, 20);
            this.txt_ad.TabIndex = 25;
            // 
            // lst_görünüm
            // 
            this.lst_görünüm.FormattingEnabled = true;
            this.lst_görünüm.Location = new System.Drawing.Point(387, 224);
            this.lst_görünüm.Name = "lst_görünüm";
            this.lst_görünüm.Size = new System.Drawing.Size(504, 121);
            this.lst_görünüm.TabIndex = 26;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(169, 198);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 28;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(387, 79);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(504, 95);
            this.listBox1.TabIndex = 29;
            // 
            // txt_fiyat
            // 
            this.txt_fiyat.AllowDrop = true;
            this.txt_fiyat.Location = new System.Drawing.Point(189, 273);
            this.txt_fiyat.Name = "txt_fiyat";
            this.txt_fiyat.Size = new System.Drawing.Size(100, 23);
            this.txt_fiyat.TabIndex = 30;
            this.txt_fiyat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(387, 389);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(504, 95);
            this.listBox2.TabIndex = 31;
            // 
            // lbl_bilgi
            // 
            this.lbl_bilgi.AutoSize = true;
            this.lbl_bilgi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_bilgi.Location = new System.Drawing.Point(384, 54);
            this.lbl_bilgi.Name = "lbl_bilgi";
            this.lbl_bilgi.Size = new System.Drawing.Size(35, 13);
            this.lbl_bilgi.TabIndex = 32;
            this.lbl_bilgi.Text = "label1";
            // 
            // lbl_içindekiler
            // 
            this.lbl_içindekiler.AutoSize = true;
            this.lbl_içindekiler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_içindekiler.Location = new System.Drawing.Point(384, 360);
            this.lbl_içindekiler.Name = "lbl_içindekiler";
            this.lbl_içindekiler.Size = new System.Drawing.Size(35, 13);
            this.lbl_içindekiler.TabIndex = 33;
            this.lbl_içindekiler.Text = "label2";
            // 
            // lbl_sipariş
            // 
            this.lbl_sipariş.AutoSize = true;
            this.lbl_sipariş.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_sipariş.Location = new System.Drawing.Point(384, 198);
            this.lbl_sipariş.Name = "lbl_sipariş";
            this.lbl_sipariş.Size = new System.Drawing.Size(35, 13);
            this.lbl_sipariş.TabIndex = 34;
            this.lbl_sipariş.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(967, 621);
            this.Controls.Add(this.lbl_sipariş);
            this.Controls.Add(this.lbl_içindekiler);
            this.Controls.Add(this.lbl_bilgi);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.txt_fiyat);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lst_görünüm);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.txt_adres);
            this.Controls.Add(this.txt_telefon);
            this.Controls.Add(this.cmb_ödeme);
            this.Controls.Add(this.cmb_icecek);
            this.Controls.Add(this.cmb_kenar);
            this.Controls.Add(this.cmb_ebat);
            this.Controls.Add(this.cmb_pizza);
            this.Controls.Add(this.btn_onay);
            this.Controls.Add(this.btn_sepet);
            this.Controls.Add(this.btn_hesapla);
            this.Controls.Add(this.lbl_ödeme);
            this.Controls.Add(this.lbl_telefon);
            this.Controls.Add(this.lbl_adres);
            this.Controls.Add(this.lbl_isim);
            this.Controls.Add(this.lbl_fiyat);
            this.Controls.Add(this.lbl_adet);
            this.Controls.Add(this.lbl_icecek);
            this.Controls.Add(this.lbl_kenar);
            this.Controls.Add(this.lbl_ebat);
            this.Controls.Add(this.lbl_pizzaad);
            this.Controls.Add(this.lbl_pizza);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_pizza;
        private System.Windows.Forms.Label lbl_pizzaad;
        private System.Windows.Forms.Label lbl_ebat;
        private System.Windows.Forms.Label lbl_kenar;
        private System.Windows.Forms.Label lbl_icecek;
        private System.Windows.Forms.Label lbl_adet;
        private System.Windows.Forms.Label lbl_fiyat;
        private System.Windows.Forms.Label lbl_isim;
        private System.Windows.Forms.Label lbl_adres;
        private System.Windows.Forms.Label lbl_telefon;
        private System.Windows.Forms.Label lbl_ödeme;
        private System.Windows.Forms.Button btn_hesapla;
        private System.Windows.Forms.Button btn_sepet;
        private System.Windows.Forms.Button btn_onay;
        private System.Windows.Forms.ComboBox cmb_pizza;
        private System.Windows.Forms.ComboBox cmb_ebat;
        private System.Windows.Forms.ComboBox cmb_kenar;
        private System.Windows.Forms.ComboBox cmb_icecek;
        private System.Windows.Forms.ComboBox cmb_ödeme;
        private System.Windows.Forms.TextBox txt_telefon;
        private System.Windows.Forms.TextBox txt_adres;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.ListBox lst_görünüm;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label txt_fiyat;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label lbl_bilgi;
        private System.Windows.Forms.Label lbl_içindekiler;
        private System.Windows.Forms.Label lbl_sipariş;
    }
}

