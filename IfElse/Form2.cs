using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IfElse
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //Maktıksal Oparatörler
        //Birden fazla duurmun aynı anda kontorl edilmesi senaryosunda kullanılan oparatörlerdir
        // "&&" (Ve) Kontorl bloğu içerisnde yer alan tüm koşulların sağlanamsı durmuna iaşret eder. Koşullardan biri dahi sağlamazsa bloğumuz harekete geçmez.
        // "||" (Veya) Kontorl bloğun içerisnde yer alan koşulalrdan birisiin sağlanması duurmunu işaret eder. Böylece bir koşul sağlansa bile bloğumuz harekete geçer.
        
        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtBirinciDeger.Text=="admin" && txtIkinciDeger.Text == "123")
            {
                MessageBox.Show("Tebrikler! Tüm bilgiler doğru");
            }
            else
            {
                MessageBox.Show("Kullanıcı adınız yada şiferniz yanlış");
            }
        }

        private void btnNot_Click(object sender, EventArgs e)
        {
            //İlk texbox kullanılacak
            //Girien Not 0-30 arasında ise "FF" 30-50 aralığında ise "DD" 50-70 aralığında ise "CC" 70-90 aralığında ise "BB" 90-100 aralığında ise "AA"

            int not = Convert.ToInt32(txtBirinciDeger.Text);

            if (not >= 0 && not <= 30)
            {
                MessageBox.Show("Harf Notunuz: FF");
            }
            else if (not >= 31 && not<=50)
            {
                MessageBox.Show("Harf Notunuz: DD");
            }
            else if (not >= 51 && not <= 70)
            {
                MessageBox.Show("Harf Notunuz: CC");
            }
            else if (not >=71 && not <= 90)
            {
                MessageBox.Show("Harf Notunuz: BB");
            }
            else if (not >=91 && not <= 100)
            {
                MessageBox.Show("Harf Notunuz: AA");
            }
            else
            {
                MessageBox.Show("Girilen not geçersizdir");
            }
        }

        private void btnMarket_Click(object sender, EventArgs e)
        {
            //ilt textbox kulaılaca
            //DIşarıdan üürn girilecek, kasiyer bize ürün hangir eyonda olduğunu söyleyecek
            //Domates, biber patlıcan => sebze reyonu
            //Diş macunu, parfün, şampuan => kozmatik reyonu    
            //Cep telefonu , bilgisayar, ses sistemi =>teknoloji reyonu
            //başka bir üürn giirldiğinde "Bu ürün bizde yok" uyarısı versin

            string urun = txtBirinciDeger.Text.ToLower();//ToLower() => fonksiyonum texten giirlen değerin bütün karakterleirni küçük harf yapar

            if (urun == "domates" || urun== "biber" || urun == "patlican")
            {
                MessageBox.Show("Sebze Reyonu");
            }
            else if (urun== "diş macunu" || urun== "parfüm" || urun == "şampuan")
            {
                MessageBox.Show("Kozmetik Reyonu");
            }
            else if (urun=="cep telefonu" || urun == "bilgisayar" || urun== "ses sistemi")
            {
                MessageBox.Show("Teknoloji Reyonu");
            }
            else
            {
                MessageBox.Show("Bu ürün karşıda ki mağzada");
            }
        }

        private void btnSatıs_Click(object sender, EventArgs e)
        {
            //ilk texbox kullanılacak
            //Dışarıdan sipaş alındığında kitap miktarı girilsin. Sipariş sayısı 20'den az sa toplam ücretten %5 düşülsün, 20-50 aralığında is %15 50-100 ise %20 100'den fazla ise %25 indirim yapılsın . Kitabın biirm fiyatı 5tl
            //ödenecek tutarı kullanıcıyı gösteriniz.

            double toplamOdenecekTutar = 0;
            double birimFiyat = 5;
            double siparisMiktari = Convert.ToDouble(txtBirinciDeger.Text);

            if (siparisMiktari>0 && siparisMiktari<=20)
            {
                toplamOdenecekTutar = (birimFiyat * siparisMiktari) * 0.95;
            }
            else if (siparisMiktari>20 && siparisMiktari<=50)
            {
                toplamOdenecekTutar = (siparisMiktari * birimFiyat) * 0.85;
            }
            else if (siparisMiktari>50 && siparisMiktari<=100)
            {
                toplamOdenecekTutar = (siparisMiktari * birimFiyat) * 0.80;
            }
            else if (siparisMiktari>100)
            {
                toplamOdenecekTutar = (siparisMiktari * birimFiyat) * 0.75;
            }

            MessageBox.Show("Ödemeniz gerek toplam tutar: " + toplamOdenecekTutar);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
