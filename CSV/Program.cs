using System;
using CsvHelper;
using System.IO;
using System.Linq;
using System.Collections; 
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;

namespace CSV
{
    //how to import the csv file //comma separated value file 
    internal class Program
    {
        static void Main(string[] args)
        {
            using(var reader = new StreamReader(@"C:\\Users\\m.yovchevski\\Desktop\\MOCK_DATA.csv"))
            
            using (var csv =   new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Data>().ToList();


                var queryOne = from z in records
                               where z.First_name == "John"
                               select z;


                foreach(var item in records)
                {
                    Console.WriteLine($"Hello my name is {item.First_name}," +
                        $"{item.Last_name},{item.Gender}");
                }
            }
          


        }

        class Data
        {
            public int id { get; set; }
            public string First_name { get; set; }              
           public string Last_name { get; set; }
            public string Email { get; set; }
            public string Gender { get; set; }
            public string Country { get; set; }
            public string Company_Name { get; set; }


        }
    }
}
