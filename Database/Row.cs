using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Database
{
    public class Row //Tabloya göre oluşan dinamik satır modelimiz.
    {
        Dictionary<string, object> _Rows;//Satırların tutulduğu Dizi
        public Row(List<Column> _columns) // Tablonun sutunlarına göre dinamik satır oluşuran oluşturucu metotdur.
        {
            _Rows = new Dictionary<string, object>(); //Satırların tutulduğu Dizi'nin yapıcı metodudur.
            foreach (Column _column in _columns)
            {
                _Rows.Add(_column.column, null); //Kütüphaneye değişken eklerken Add metodu kullanılır.
            }
            
        }

        public object this[string index] //Satırda İndis İle İşlem yapmak için gereklidir.
        {
            get => _Rows[index];  //Satırda İndis İle İşlem yapmak için gereklidir.
            set => _Rows[index] = value; //Satırda İndis İle İşlem yapmak için gereklidir.
        }

        
    }
}
