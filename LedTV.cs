using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b191210450
{
    class LedTv : Urun //Değer atanıyor.
    {

        private string _EkranBoyutu;

        private string _EkranCozunurlugu;

        public LedTv(int stokAdedi)
        {
            _Ad = "Televizyon";
            _Marka = "Samsung";
            _Model = "Smart";
            _Ozellik = "Yüksek Çözünürlük";
            _HamFiyat = 4000;
            _EkranBoyutu = "50 inc";
            _EkranCozunurlugu = "1920 * 1080";
            _StokAdedi = stokAdedi;
        }
     
    }
   
}
