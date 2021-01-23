using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService) //interface hepsinin referansını tuttuğu için hangi türden krediyi yollarsan onu çalıştırır.
        {
            //Başvuran bilgilerini değerlendirme                                      //tekli
            //vs.vs
            krediManager.Hesapla();
            loggerService.Log();
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)          //liste halinde
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();

            }

        }
    }
}
