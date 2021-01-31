using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b191210450
{
    class Laptop : Urun //Değer atanıyor.
    {

        private string _EkranBoyutu;

        private string _EkranCozunurluk;

        private string _DahiliHafiza;

        private string _RamKapasitesi;

        private string _PilGucu;

        public Laptop(int stokAdedi)
        {           
            _Ad = "Dizüstü Bilgisayar";
            _Marka = "Monster";
            _Model = "Tulpar";
            _Ozellik = "Oyun Bilgisayarı";
            _HamFiyat = 6000;
            _EkranBoyutu = "17 inc";
            _EkranCozunurluk = "1920 * 1080";
            _DahiliHafiza = "2000gb";
            _RamKapasitesi = "16gb";
            _PilGucu = "3500 mha";
            _StokAdedi = stokAdedi;
        }
            
    }
}
