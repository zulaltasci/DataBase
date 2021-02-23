using System;
using System.Linq;
using System.Collections.Generic;

namespace Database
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            Set set = new Set("DbSchool");//Yeni bir database oluşturulur.
            Table table = new Table("TblStudent");//Yeni bir tablo oluşturulur.
            set.Tables.Add(table);//tablo oluşturulan database'e atanır.
            table.Columns.Add(new Column("No"));//tabloya sutun eklenir.
            table.Columns.Add(new Column("Name"));//tabloya sutun eklenir.

            Row row = table.NewRow(); //tabloya ait özelliklerde satır oluşturulur.
            row["No"] = "123"; //Satırın tablodaki sutununa değer atanır.
            row["Name"] = "Zülal Taşçı";//Satırın tablodaki sutununa değer atanır.
            table.Rows.Add(row); //Satır ilgili tabloya eklenir

            Row row2 = table.NewRow();//tabloya ait özelliklerde satır oluşturulur.
            row2["No"] = "456";//Satırın tablodaki sutununa değer atanır.
            row2["Name"] = "Taşçı Zülal";//Satırın tablodaki sutununa değer atanır.
            table.Rows.Add(row2);//Satır ilgili tabloya eklenir

            table.Rows[1]["No"] = "345";//Tablonun 2. satırının "No" sutundaki değer 345 ile değiştirilir.  

            foreach (Row item in table.Rows)//Tablonun satırları içinde dönülür.
            {
                Console.WriteLine("No: {0}\tName: {1}", item["No"], item["Name"]);//Consol'a tablonun satırları yazdırılır.
            }
            Console.WriteLine();
            Console.WriteLine(set.Tables.First().Rows[1]["No"]);//databasedeki tablonun ilkinin satırlarının 2. sinin "No" sutunundaki değeri yazdırmak için kullanılır.

            foreach (Row _row in table.Rows) //Tablonun satırlarında döngü ile dönülüyor.
            {
                foreach (Column column in table.Columns)//Tablonun sutunları döngü ile dönülüyor.
                {
                    Console.Write($"{column.column} : {_row[column.column]}\t ");//Console Tablonun sutun adı ve satırın o sutundaki değerini yazdırıp sonuna bir tab bolşuğu ekliyoruz.
                }
                Console.WriteLine();//satır bittiğinde alt satıra geçmek için kullandık.

            }
            Console.WriteLine();
            Console.WriteLine($"Database'deki tablo sayısı : {set.Count()}");//Ekrana yazdırır
            Console.WriteLine($"Database'deki ilk Tablodaki satır sayısı : {set.Tables.First().Count()}");//Ekrana yazdırır

            Console.ReadKey();//Consolun hata vermeden beklemesi için yazılır. 
        }
    }
}
