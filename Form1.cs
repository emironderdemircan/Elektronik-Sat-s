using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2020-2021 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........:
**				ÖĞRENCİ ADI............:EMİR ÖNDER DEMİRCAN
**				ÖĞRENCİ NUMARASI.......:b191210450
**              DERSİN ALINDIĞI GRUP...:1-A
****************************************************************************/

namespace b191210450
{
    public partial class Form1 : Form
    {
        static Random random = new Random();//Random değişkeni tanımlanıyor.
        Buzdolabi buzdolabi = new Buzdolabi(random.Next(100));//Buzdolabı için 100'e kadar rastgele sayı ekleniyor.
        LedTv ledtv = new LedTv(random.Next(100));//Televizyon için 100'e kadar rastgele sayı ekleniyor.
        Laptop laptop = new Laptop(random.Next(100));//Laptop için 100'e kadar rastgele sayı ekleniyor.
        CepTel ceptel = new CepTel(random.Next(100));//Cep telefonu için 100'e kadar rastgele sayı ekleniyor.


        public Form1()
        {
            InitializeComponent();
            
            stokbuzdolabilabel.Text = Convert.ToString(buzdolabi._StokAdedi);//Rastgele stok adedi label'a yazdırılıyor.
            stokceptellabel.Text = Convert.ToString(ceptel._StokAdedi);//Rastgele stok adedi label'a yazdırılıyor.
            stoklaptoplabel.Text = Convert.ToString(laptop._StokAdedi);//Rastgele stok adedi label'a yazdırılıyor.
            stoktelevizyonlabel.Text = Convert.ToString(ledtv._StokAdedi);//Rastgele stok adedi label'a yazdırılıyor.
        }
        

        private void sepeteeklebutton_Click(object sender, EventArgs e)
        {

            Sepet sepet = new Sepet();

            if (buzdolabinumericUpDown.Value != 0)
            {
                adetlistBox.Items.Add(buzdolabinumericUpDown.Value);//Numeric Up Down aracından ürün adedi seçtiriliyor ve adet listbox'a yazdırılıyor.
                urunlistBox.Items.Add(buzdolabi._Ad);//Ürün ismi ürün listbox'a yazdırılıyor.
                buzdolabi._SecilenAdet = Convert.ToInt32(buzdolabinumericUpDown.Value);//Dönüşüm yapılıyor.
                sepet.urunKdvOrani = 1.05;//Buzdolabı kdv oranı belirtiliyor.
                kdvlistBox.Items.Add(sepet.SepeteUrunEkle(buzdolabi));//Sepet sınıfından alınan veriler ile kdv listbox'a kdv'li fiyat yazdırılıyor.
                stokbuzdolabilabel.Text = (buzdolabi._StokAdedi - buzdolabinumericUpDown.Value).ToString();//Stok adetten seçilen adet düşürülüyor.
                //Stok adedinden fazla seçim yapılmış ise program hata veriyor.
                if (buzdolabi._StokAdedi < buzdolabi._SecilenAdet)
                {
                    //Messagebox kontrol ediliyor.
                    DialogResult secenek = MessageBox.Show("Buzdolabı için yeterli stok yok.Yeniden giriş için 'Evet' tuşuna basınız ve ardırdan sepeti temizleyiniz, programı kapatmak için 'Hayır' tuşuna basınız", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    
                    if (secenek == DialogResult.Yes)
                    {
                        adetlistBox.Items.Clear();
                        urunlistBox.Items.Clear();
                        kdvlistBox.Items.Clear();
                        label25.Text = "0 TL";
                    }
                    else if (secenek == DialogResult.No)
                    {
                        Close();
                    }
                }
            }
                                
            if (televizyonnumericUpDown.Value != 0)
            {
                adetlistBox.Items.Add(televizyonnumericUpDown.Value);//Numeric Up Down aracından ürün adedi seçtiriliyor ve adet listbox'a yazdırılıyor.
                urunlistBox.Items.Add(ledtv._Ad);//Ürün ismi ürün listbox'a yazdırılıyor.
                ledtv._SecilenAdet = Convert.ToInt32(televizyonnumericUpDown.Value);//Dönüşüm yapılıyor.
                sepet.urunKdvOrani = 1.18;//Televizyon kdv oranı belirtiliyor.
                kdvlistBox.Items.Add(sepet.SepeteUrunEkle(ledtv));//Sepet sınıfından alınan veriler ile kdv listbox'a kdv'li fiyat yazdırılıyor.
                stoktelevizyonlabel.Text = (ledtv._StokAdedi - televizyonnumericUpDown.Value).ToString();//Stok adetten seçilen adet düşürülüyor.
                //Stok adedinden fazla seçim yapılmış ise program hata veriyor.
                if (ledtv._StokAdedi < ledtv._SecilenAdet)
                {
                    //Messagebox kontrol ediliyor.
                    DialogResult secenek = MessageBox.Show("Televizyon için yeterli stok yok.Yeniden giriş için 'Evet' tuşuna basınız ve ardırdan sepeti temizleyiniz, programı kapatmak için 'Hayır' tuşuna basınız", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                    if (secenek == DialogResult.Yes)
                    {
                        adetlistBox.Items.Clear();
                        urunlistBox.Items.Clear();
                        kdvlistBox.Items.Clear();
                        label25.Text = "0 TL";
                    }
                    else if (secenek == DialogResult.No)
                    {
                        Close();
                    }
                }
            }

            if (laptopnumericUpDown.Value != 0)
            {
                adetlistBox.Items.Add(laptopnumericUpDown.Value);//Numeric Up Down aracından ürün adedi seçtiriliyor ve adet listbox'a yazdırılıyor.
                urunlistBox.Items.Add(laptop._Ad);//Ürün ismi ürün listbox'a yazdırılıyor.
                laptop._SecilenAdet = Convert.ToInt32(laptopnumericUpDown.Value);//Dönüşüm yapılıyor.
                sepet.urunKdvOrani = 1.15;//Laptop kdv oranı belirtiliyor.
                kdvlistBox.Items.Add(Convert.ToInt32(sepet.SepeteUrunEkle(laptop)));//Sepet sınıfından alınan veriler ile kdv listbox'a kdv'li fiyat yazdırılıyor.
                stoklaptoplabel.Text = (laptop._StokAdedi - laptopnumericUpDown.Value).ToString();//Stok adetten seçilen adet düşürülüyor.
                //Stok adedinden fazla seçim yapılmış ise program hata veriyor.
                if (laptop._StokAdedi < laptop._SecilenAdet)
                {
                    //Messagebox kontrol ediliyor.
                    DialogResult secenek = MessageBox.Show("Laptop için yeterli stok yok.Yeniden giriş için 'Evet' tuşuna basınız ve ardırdan sepeti temizleyiniz, programı kapatmak için 'Hayır' tuşuna basınız", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                    if (secenek == DialogResult.Yes)
                    {
                        adetlistBox.Items.Clear();
                        urunlistBox.Items.Clear();
                        kdvlistBox.Items.Clear();
                        label25.Text = "0 TL";
                    }
                    else if (secenek == DialogResult.No)
                    {
                        Close();
                    }
                }
            }

            if (telefonnumericUpDown.Value != 0)
            {
                adetlistBox.Items.Add(telefonnumericUpDown.Value);//Numeric Up Down aracından ürün adedi seçtiriliyor ve adet listbox'a yazdırılıyor.
                urunlistBox.Items.Add(ceptel._Ad);//Ürün ismi ürün listbox'a yazdırılıyor.
                ceptel._SecilenAdet = Convert.ToInt32(telefonnumericUpDown.Value);//Dönüşüm yapılıyor.   
                sepet.urunKdvOrani = 1.20;//Cep telefonu kdv oranı belirtiliyor.
                kdvlistBox.Items.Add(sepet.SepeteUrunEkle(ceptel));//Sepet sınıfından alınan veriler ile kdv listbox'a kdv'li fiyat yazdırılıyor.
                stokceptellabel.Text = (ceptel._StokAdedi - telefonnumericUpDown.Value).ToString();//Stok adetten seçilen adet düşürülüyor.
                //Stok adedinden fazla seçim yapılmış ise program hata veriyor.
                if (ceptel._StokAdedi < ceptel._SecilenAdet)
                {
                    //Messagebox kontrol ediliyor.
                    DialogResult secenek = MessageBox.Show("Cep telefonu için yeterli stok yok.Yeniden giriş için 'Evet' tuşuna basınız ve ardırdan sepeti temizleyiniz, programı kapatmak için 'Hayır' tuşuna basınız", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                    if (secenek == DialogResult.Yes)
                    {
                        adetlistBox.Items.Clear();
                        urunlistBox.Items.Clear();
                        kdvlistBox.Items.Clear();
                        label25.Text = "0 TL";
                    }
                    else if (secenek == DialogResult.No)
                    {
                        Close();
                    }
                }
            }
            
            label25.Text = Convert.ToString(sepet.toplamKdvliFiyat);//Toplam fiyat yazdırılıyor.
            sepeteeklebutton.Enabled = false;
            //Hiç seçim yapılmamış ise uyarı veriliyor.
            if (buzdolabinumericUpDown.Value == 0 && televizyonnumericUpDown.Value == 0 && laptopnumericUpDown.Value == 0 && telefonnumericUpDown.Value == 0)
            {
                MessageBox.Show("Lütfen seçim yapınız..");
                sepeteeklebutton.Enabled = true;
            }
        }

        //Stoklar tekrar ekleniyor ve veriler temizleniyor.
        private void temizlebutton_Click(object sender, EventArgs e)
        {
            adetlistBox.Items.Clear();
            urunlistBox.Items.Clear();
            kdvlistBox.Items.Clear();
            label25.Text = "0 TL";
            sepeteeklebutton.Enabled = true;
            stokbuzdolabilabel.Text = (buzdolabi._StokAdedi).ToString();
            stoktelevizyonlabel.Text = (ledtv._StokAdedi).ToString();
            stoklaptoplabel.Text = (laptop._StokAdedi).ToString();
            stokceptellabel.Text = (ceptel._StokAdedi).ToString();
            buzdolabinumericUpDown.Value = 0;
            televizyonnumericUpDown.Value = 0;
            laptopnumericUpDown.Value = 0;
            telefonnumericUpDown.Value = 0;
        }
    }
}
