using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b191210450
{
    class CepTel : Urun //Değer atanıyor.
    {

        private string _DahiliHafiza;

        private string _RamKapasitesi;

        private string _PilGucu;

        public CepTel(int stokAdedi)
        {
            _Ad = "Cep Telefonu";
            _Marka = "LG";
            _Model = "G3";
            _Ozellik = "Yeni Teklonoji";
            _HamFiyat = 2500;
            _DahiliHafiza = "64gb";
            _RamKapasitesi = "8gb";
            _PilGucu = "2500mah";
            _StokAdedi = stokAdedi;
        }
        
    }
}
