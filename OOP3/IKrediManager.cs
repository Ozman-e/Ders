using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediManager //interfaceleri I harfi ile başlat. okunurluk için.
                            //class yerine interface yaparak öteki classların bu özellikleri "kendi kurallarıyla" uygulamasını sağlıyoruz.
    {
        void Hesapla();
        void BiseyYap();
        
    }
}
