using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b191210450
{
    class Sepet
    {
        public double urunKdvOrani;//Urunkdvoranı şeklinde değişken atanıyor.
        public double toplamKdvliFiyat;//Toplam kdv'li fiyat şeklinde değişken atanıyor.
        public double SepeteUrunEkle(Urun urun) //Ürün sınıfından miras alınan bir metod yazılıyor.
        {
            double kdvliFiyat = urun.KdvUygula(this.urunKdvOrani);//Ürün kısmında oluşturulan kdv uygula metodu kullanılıyor.
            this.toplamKdvliFiyat += kdvliFiyat;//Kdv'li fiyat hesaplanıyor.
            return kdvliFiyat;
        }

    }

}
