using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b191210450
{
    abstract class Urun //Ürün sınıfı tanımlanıyor.
    {
        public string _Ad { get; set; }

        public string _Marka { get; set; }

        public string _Model { get; set; }

        public string _Ozellik { get; set; }

        public int _StokAdedi { get; set; }

        public int _HamFiyat { get; set; }

        public int _SecilenAdet { get; set; }

        public double KdvUygula(double kdvOrani)//Kdv uygula metodu yazılıyor.
        {
            return _HamFiyat * kdvOrani * _SecilenAdet;
        }
    }
}
