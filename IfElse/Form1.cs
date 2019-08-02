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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*Karar Yapıları
         Uygulamanızda çalışma esnasında farklı senaryolar göre farklı yönlendirmeler yapmanız gerekebilir.
         Örneğin kullanıcıdan gelen değerin aralığına göre uygulamadaki mantıksal işlemlerimizn sonuçlarına göre yönlendirmeler yapabiliriz.

            If en başltaki kışul olamk zorundadır. Arada Else-İf kullanılabilir. Else var ise en sonunda olmak zorundadır.
            Birden çok if else olamaz. Ancak "else-if" yapısı biçok kez tekrar edilebilir.
             */

        /*Karşılaştırma Oparatörleri
         1. "==" (Karşılıklı iki değerin birbirleiryle eşit olma durumu)
         2. "!=" (Karşılıklı iki değerin birbirşeriyle eşit olamaması durum)
         3. "<" (Karşılıklı iki değlerin sağdaki değerden küçük olamsı)
         4. ">" (Karşılıklı iki değlerin sağdaki değerden büyük olamsı)
         5. "<=" (Soldaki değerin sağdaki değere elit yada ondan küçük olması durumu)
         6. ">=" (Soldaki değerin sağdaki değere eşit yada büyük olamsı durumu)
         */


        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (txtGirisAlani.Text == "admin")
            {
                MessageBox.Show("Hoşgeldiniz Sahip..!");
            }
            else
            {
                MessageBox.Show("Tanıyamadım Kardeşş...!");
            }
        }

        private void btnNot_Click(object sender, EventArgs e)
        {
            //Eğer girilen değer 100'den büyükse uyarı mesajı
            //eğer girilen değer 0'dan küçükse uyarı emsajı
            //Kalan duurmda "hatasız not girişi" yaptınız mesajı

            int girilenNot = Convert.ToInt32(txtGirisAlani.Text);//Texbox'dan aldığımız değeri Int32'ye convert ediyorum ve int tipindeki girilenNot değişkenin içine atıyorum

            if (girilenNot<0)
            {
                MessageBox.Show("Girilen not sıfırdan küçük olamaz");
            }
            else if (girilenNot>100)
            {
                MessageBox.Show("Girilen Not 100'den büyük olamaz");
            }
            else
            {
                MessageBox.Show("Hatasız not grişi yaptınız"); 
            }
        }

        private void btnCiftTek_Click(object sender, EventArgs e)
        {
            //Girilen değer çift mi tek mi?

            int girilenSayi = Convert.ToInt32(txtGirisAlani.Text);

            if (girilenSayi %2 == 0)
            {
                MessageBox.Show("Sayi çift");
            }
            else
            {
                MessageBox.Show("Sayi Tek");
            }
        }

        private void btnDeger_Click(object sender, EventArgs e)
        {
            //Dıaşrıdan girilen metnin uzunluğunu 8 karaktere eşit yada büyükse kayıt onaylandıi değilse "daha uzun bir şifre giriniz diye" ekran mesaj versin

            if (txtGirisAlani.Text.Length>=8)
            {
                MessageBox.Show("Kayıt Onaylandı!");
            }
            else
            {
                MessageBox.Show("Lütfen daha uzun bir şifre giriniz");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
