using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
    public interface ICRUD //Crud işlemlerinin arayüzü(arabirimi) (Ekleme,Çıkarma,Güncelleme)
    {
        void Add(object x);//Ekleme Metodu
        void Update(object x);//Güncelleme Metodu
        void Delete(object x);//Silme metodu
        int Count();//Sayı Öğrenme Metodu
    }
}
