using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b191210450
{
    class Buzdolabi : Urun //Değer atanıyor.
    {
        private int _IcHacim;

        private string _EnerjiSinifi;

        public Buzdolabi(int stokAdeti)
        {
            _Ad = "Buzdolabı";
            _Marka = "Arçelik";
            _Model = "TR85569";
            _Ozellik = "NoFrost";
            _HamFiyat = 3500;
            _IcHacim = 1200;
            _EnerjiSinifi = "A++";
            _StokAdedi = stokAdeti;
        }
        
    }
}
