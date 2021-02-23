using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Database
{
    
    public class Set : ICRUD//Database Sınıfımız.
    {
        
        public List<Table> Tables = new List<Table>(); //Database İçindeki Tabloların tutulduğu dizidir.

        
        public Set(string DbName) //Database Oluşturucu metodudur. İsim değişkeni alır.
        {
            _Set = DbName;
        }


        private string _Set = "";//Database adının tutulduğu değişkendir.
        

        public object this[string index] //Database İndis İle İşlem yapmak için gereklidir.
        {
            get => Tables.Where(x=>x.table==index).First().table;//Database'de İsmi verilen tablonun varlığını sorgular. 
            
        }


        public void Add(object x) //Database'e tablo eklemek için kullanılır.
        {
            Tables.Add((Table)x);//Listelere değişken eklerken Add metodu kullanılır.
        }

        public void Update(object x)//Database'de tablo güncellemek için kullanılır.
        {
            Delete(x);
            Add(x);
        }

        
        public void Delete(object x)//Database'den tablo silmek için kullanılır.
        {
            Tables.Remove((Table)x);//Listelerden değer silerken Remove metodu kullanılır.
        }

        public int Count() //Database'deki tablo sayısını öğrenmek için kullanılır.
        {
            return Tables.Count;//Listelerin eleman sayısı öğrenilirken Count değişkeni kullanılır
        }
    }
}
