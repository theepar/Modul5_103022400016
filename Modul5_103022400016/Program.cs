using System;

namespace Modul5_103022400016
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SimpleDataBase<int> db = new SimpleDataBase<int>();
            db.AddNewData(12);
            db.AddNewData(34);
            db.AddNewData(54);

            db.printData();

        }
    }
}