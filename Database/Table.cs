using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{

    public class Table : ICRUD // Tablo Modelimizin sınıfıdır.
    {
        public List<Column> Columns = new List<Column>();//Tablodaki Sutun listesinin tutulduğu Modeldir.

        public List<Row> Rows = new List<Row>();//Tablodaki Satır listesinin tutulduğu Modeldir.
        public Table(string TableName) //Tablo oluştururken ismini atayan yapıcı metotdur
        {
            _Table = TableName;
        }
        
        private string _Table ="";//Tablonun isminin tutulduğu değişkendir.

        public string table { get { return _Table; } set { _Table = value; } } //Tablo nesnesinde Getirme Ve atama işlemleri için yazılan özelliktir.

        public Row NewRow() //Tabloya yeni satır eklemek için kullanılır.
        {
            return new Row(Columns); //Sutunlara göre satır modeli Oluşturulur.
        }

        public void Add(object x) //Tabloya Sutun ekleyen metotdur.
        {
            Columns.Add((Column)(x));//Listelere değişken eklerken Add metodu kullanılır.
        }

        public void Update(object x)//Tablodan Sutun Güncelleyen metotdur.
        {
            Delete(x);
            Add(x);
        }

        public void Delete(object x)//Tablodan Sutun silen metotdur.
        {
            Columns.Remove((Column)(x));//Listelerden değer silerken Remove metodu kullanılır.
        }

        public int Count()//Tabloya Sutun sayısını döndüren metotdur.
        {
           return Columns.Count;//Listelerin eleman sayısı öğrenilirken Count değişkeni kullanılır
        }
    }
}

