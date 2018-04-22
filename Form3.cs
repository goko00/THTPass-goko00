using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödevler
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
    

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            nmrUzunluk.Maximum = 7;
            nmrUzunluk.Minimum = 4;
        }

        
      

        private void btnOl_Click(object sender, EventArgs e)
        {

       

            if (rBtnNs.Checked && nmrUzunluk.Value == 4  )
            {
                progressBar1.Value = 0;
                progressBar1.Value = 100;

                Random sifre = new Random();
                int kar = sifre.Next(0, 9);
                string son = Convert.ToString(kar);
                int kar12 = sifre.Next(0, 9);
                string son2 = Convert.ToString(kar12);
                int kar2 = sifre.Next(0, 9);
                kar2.ToString();
                int kar3 = sifre.Next(0, 9);
                kar3.ToString();
               
                txtBx1.Text = son + kar2 + son2 + kar3;
                

            }

            else if (rBtnNs.Checked && nmrUzunluk.Value == 5)
            {
                progressBar1.Value = 0;
                progressBar1.Value = 100;
                nmrUzunluk.Maximum = 7;
                Random sifre = new Random();
                int ascii2 = sifre.Next(35, 40);
                char karakter2 = Convert.ToChar(ascii2);
                int kar = sifre.Next(0, 9);
                int kar2 = sifre.Next(0, 9);
                kar2.ToString();
                int kar12 = sifre.Next(0, 9);
                string son2 = Convert.ToString(kar12);
                int ascii23 = sifre.Next(35, 40);
                char karakter23 = Convert.ToChar(ascii23);

                string son = Convert.ToString(kar);
                txtBx1.Text = son + kar2 + karakter2 + son2 + son;

            }

            else if (rBtnNs.Checked && nmrUzunluk.Value == 6){
                progressBar1.Value = 0;
                progressBar1.Value = 100;
                nmrUzunluk.Maximum = 7;
                Random sifre = new Random();
                int ascii2 = sifre.Next(35, 40);
                char karakter2 = Convert.ToChar(ascii2);
                int kar = sifre.Next(0, 0);
                int kar2 = sifre.Next(0, 9);
                kar2.ToString();
                int kar12 = sifre.Next(0, 9);
                string son2 = Convert.ToString(kar12);
                int ascii23 = sifre.Next(35, 40);
                char karakter23 = Convert.ToChar(ascii23);

                string son = Convert.ToString(kar);
                txtBx1.Text = son + kar2 + karakter2 + son2 + kar2+son;

            }

            else if (rBtnNs.Checked && nmrUzunluk.Value == 7)
            {
                progressBar1.Value = 0;
                progressBar1.Value = 100;

                Random sifre = new Random();
                int ascii2 = sifre.Next(33, 38);
                char karakter2 = Convert.ToChar(ascii2);
                int kar = sifre.Next(33, 47);
                int kar2 = sifre.Next(0, 10);
                kar2.ToString();
                int ascii22 = sifre.Next(65, 90);
                string son = Convert.ToString(kar);
                char karakter23 = Convert.ToChar(ascii22);
                txtBx1.Text = son + kar2 + karakter23 + son + karakter2 +kar2;

            }

            if (rBtnGs.Checked &&nmrUzunluk.Value==8)
            {
                progressBar1.Value = 0;
                progressBar1.Value = 100;
                Random gsifre = new Random();
                int ilkSayı = gsifre.Next(0, 9);
                int tekharF = gsifre.Next(65, 90);
                int karakter = gsifre.Next(36, 38);
                int et = gsifre.Next(63, 72);
                int harf = gsifre.Next(97, 122);
                int Sayi = gsifre.Next(1, 10);
                int sayii = gsifre.Next(1, 9);
                int harff = gsifre.Next(97, 122);
             


                char h = Convert.ToChar(tekharF);
                char k = Convert.ToChar(karakter);
                char ea = Convert.ToChar(et);
                char ha = Convert.ToChar(harf);
                char har = Convert.ToChar(harff);

                txtBx1.Text = ilkSayı.ToString()+h+k+har+Sayi+ha+sayii+ea;

               
            }

            else if (rBtnGs.Checked && nmrUzunluk.Value == 9)
            {
                progressBar1.Value = 0;
                progressBar1.Value = 100;

                Random gsifre = new Random();
                int ilkSayı = gsifre.Next(0, 9);
                int tekharF = gsifre.Next(65, 90);
                int karakter = gsifre.Next(36, 38);
                int et = gsifre.Next(63, 72);
                int harf = gsifre.Next(97, 122);
                int Sayi = gsifre.Next(1, 10);
                int sayii = gsifre.Next(1, 9);
                int harff = gsifre.Next(97, 122);
                int karakterr = gsifre.Next(36, 38);



                char h = Convert.ToChar(tekharF);
                char k = Convert.ToChar(karakter);
                char ea = Convert.ToChar(et);
                char ha = Convert.ToChar(harf);
                char har = Convert.ToChar(harff);
                char kaa = Convert.ToChar(karakterr);

                txtBx1.Text = ilkSayı.ToString() + kaa + h + k + har + Sayi + ha + sayii + ea;
            }

            else if (rBtnGs.Checked && nmrUzunluk.Value == 10)
            {
                progressBar1.Value = 0;
                progressBar1.Value = 100;
                Random gsifre = new Random();
                int ilkSayı = gsifre.Next(0, 9);
                int tekharF = gsifre.Next(65, 90);
                int karakter = gsifre.Next(37, 38);
                int et = gsifre.Next(63, 72);
                int harf = gsifre.Next(97, 122);
                int Sayi = gsifre.Next(1, 10);
                int sayii = gsifre.Next(1, 9);
                int harff = gsifre.Next(97, 122);
                int karakterr = gsifre.Next(36, 38);
                int harf1f = gsifre.Next(97, 122);



                char h = Convert.ToChar(tekharF);
                char k = Convert.ToChar(karakter);
                char ea = Convert.ToChar(et);
                char ha = Convert.ToChar(harf);
                char har = Convert.ToChar(harff);
                char kaa = Convert.ToChar(karakterr);
                char haad = Convert.ToChar(harf1f);
                

                txtBx1.Text = ilkSayı.ToString() + kaa+haad + h + har + Sayi + ha + k + sayii + ea;
            }
            else if (rBtnGs.Checked && nmrUzunluk.Value == 11)
            {
                progressBar1.Value = 0;
                progressBar1.Value = 100;
                Random gsifre = new Random();
                int ilkSayı = gsifre.Next(0, 9);
                int tekharF = gsifre.Next(65, 90);
                int karakter = gsifre.Next(37, 38);
                int et = gsifre.Next(63, 72);
                int harf = gsifre.Next(97, 122);
                int Sayi = gsifre.Next(1, 10);
                int sayii = gsifre.Next(1, 9);
                int harff = gsifre.Next(97, 123);
                int karakterr = gsifre.Next(36, 38);
                int harf1f = gsifre.Next(97, 123);
                int harf1f2 = gsifre.Next(97, 123);
                int harf1f23 = gsifre.Next(97, 123);


                char h = Convert.ToChar(tekharF);
                char ka = Convert.ToChar(harf1f2);
                char ea = Convert.ToChar(et);
                char ha = Convert.ToChar(harf);
                char har = Convert.ToChar(harff);
                char kaa = Convert.ToChar(karakterr);
                char haad = Convert.ToChar(harf1f);
                char haads = Convert.ToChar(harf1f23);

                txtBx1.Text = ilkSayı.ToString() + kaa + haad + h + har + Sayi + ha + ka + sayii + ea+ haads;



            }

            else if (rBtnGs.Checked && nmrUzunluk.Value == 12)
            {
                progressBar1.Value = 0;
                progressBar1.Value = 100;
                Random gsifre = new Random();
                int ilkSayı = gsifre.Next(0, 9);
                int tekharF = gsifre.Next(65, 90);
                int karakter = gsifre.Next(37, 38);
                int et = gsifre.Next(63, 72);
                int harf = gsifre.Next(97, 122);
                int Sayi = gsifre.Next(1, 10);
                int sayii = gsifre.Next(1, 9);
                int harff = gsifre.Next(97, 123);
                int karakterr = gsifre.Next(36, 38);
                int harf1f = gsifre.Next(97, 123);
                int harf1f2 = gsifre.Next(97, 123);
                int harf1f23 = gsifre.Next(97, 123);
                int harf1f232 = gsifre.Next(97, 123);

                char a = Convert.ToChar(harf1f232);
                char h = Convert.ToChar(tekharF);
                char ka = Convert.ToChar(harf1f2);
                char ea = Convert.ToChar(et);
                char ha = Convert.ToChar(harf);
                char har = Convert.ToChar(harff);
                char kaa = Convert.ToChar(karakterr);
                char haad = Convert.ToChar(harf1f);
                char haads = Convert.ToChar(harf1f23);

                txtBx1.Text = ilkSayı.ToString() + kaa + haad + h+ a+ har + Sayi + ha + ka + sayii + ea + haads;
            }
            else if (rBtnGs.Checked && nmrUzunluk.Value == 13)
            {
                progressBar1.Value = 0;
                progressBar1.Value = 100;
                Random gsifre = new Random();
                int ilkSayı = gsifre.Next(0, 9);
                int tekharF = gsifre.Next(65, 90);
                int karakter = gsifre.Next(37, 38);
                int et = gsifre.Next(63, 72);
                int harf = gsifre.Next(97, 122);
                int Sayi = gsifre.Next(1, 10);
                int sayii = gsifre.Next(1, 9);
                int harff = gsifre.Next(97, 123);
                int karakterr = gsifre.Next(36, 38);
                int harf1f = gsifre.Next(97, 123);
                int harf1f2 = gsifre.Next(97, 123);
                int harf1f23 = gsifre.Next(97, 123);
                int harf1f232 = gsifre.Next(97, 123);
                int harfaa = gsifre.Next(97, 123);

                char ba = Convert.ToChar(harfaa);
                char a = Convert.ToChar(harf1f232);
                char h = Convert.ToChar(tekharF);
                char ka = Convert.ToChar(harf1f2);
                char ea = Convert.ToChar(et);
                char ha = Convert.ToChar(harf);
                char har = Convert.ToChar(harff);
                char kaa = Convert.ToChar(karakterr);
                char haad = Convert.ToChar(harf1f);
                char haads = Convert.ToChar(harf1f23);

                txtBx1.Text = ba+ ilkSayı.ToString() + kaa + haad + h + a + har + Sayi + ha + ka + sayii + ea + haads;
            }
            else if (rBtnGs.Checked && nmrUzunluk.Value == 14)
            {
                progressBar1.Value = 0;
                progressBar1.Value = 100;
                Random gsifre = new Random();
                int ilkSayı = gsifre.Next(0, 9);
                int tekharF = gsifre.Next(65, 90);
                int karakter = gsifre.Next(37, 38);
                int et = gsifre.Next(63, 72);
                int harf = gsifre.Next(97, 122);
                int Sayi = gsifre.Next(1, 10);
                int sayii = gsifre.Next(1, 9);
                int harff = gsifre.Next(97, 123);
                int karakterr = gsifre.Next(36, 38);
                int harf1f = gsifre.Next(97, 123);
                int harf1f2 = gsifre.Next(97, 123);
                int harf1f23 = gsifre.Next(97, 123);
                int harf1f232 = gsifre.Next(97, 123);
                int harfaa = gsifre.Next(97, 123);
                int tekharFa = gsifre.Next(65, 90);

                char bsa = Convert.ToChar(tekharFa);
                char ba = Convert.ToChar(harfaa);
                char a = Convert.ToChar(harf1f232);
                char h = Convert.ToChar(tekharF);
                char ka = Convert.ToChar(harf1f2);
                char ea = Convert.ToChar(et);
                char ha = Convert.ToChar(harf);
                char har = Convert.ToChar(harff);
                char kaa = Convert.ToChar(karakterr);
                char haad = Convert.ToChar(harf1f);
                char haads = Convert.ToChar(harf1f23);

                txtBx1.Text = ba + ilkSayı.ToString() + kaa + haad + h + a + har + Sayi + ha + ka + sayii + ea + haads+bsa;
            }

        }

        private void rBtnGs_CheckedChanged(object sender, EventArgs e)
        {
            nmrUzunluk.Maximum = 14;
            nmrUzunluk.Minimum = 8;
        }
    }
}
