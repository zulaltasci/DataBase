using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
    public partial class Cell //Tabloların Satır ve sutun kesisimleri olan hücrenin modelidir.
    {

        public Cell(string ColumnName, object Value) // Hücre modelinin oluşturucu metodu
        {
            this.ColumnName = ColumnName;
            this.Value = Value;
        }

        public string GetColumnName() //Hücenin Sutun Adını dönen Metot
        { return ColumnName; }

        public object GetValue()//Hücenin Değerini dönen Metot
        { return Value; }

        public string ColumnName { get; set; } //Hücenin Sutun Adı değişkeni
        public object Value { get; set; }//Hücenin Değer değişkeni
    }
}
