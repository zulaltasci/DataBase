using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
    public class Column //Tablonun sutunlarının modelidir.
    {
        private string _Column;//Sutun ismi değişkeni
        public Column(string ColumnName) //Sutun modelinin oluşturucu metodu
        {
            _Column = ColumnName;
        }
        public string column { get { return _Column; } set { _Column = value; } } //Sutun nesnesinde Getirme Ve atama işlemleri için yazılan özelliktir.
    }
}
