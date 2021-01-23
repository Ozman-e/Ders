using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{
    //Coorporate
    // bu olaya miras denir (inheritance) //musteride olan her şey tüzelmüsteride de kabul edilir. 
    //ortak olan şeyleri direkt müsteride tutmalısın.yoksa zaten altını yeşil çizip hata verir.
    class TuzelMusteri :Musteri 
    {
        
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
