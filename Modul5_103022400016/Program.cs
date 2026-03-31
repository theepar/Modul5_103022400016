using Modul5_103022400016;
using System;

<<<<<<< HEAD
public class Program
{
	public static void Main(string[] args)
	{
		PemrosesData data = new PemrosesData();
		int nilai = data.DapatkanNilaiTerbesar<int>(10, 03, 02);
		Console.WriteLine("nilai terbesar :" + nilai);

        SimpleDataBase<int> db = new SimpleDataBase<int>();
        db.AddNewData(12);
        db.AddNewData(34);
        db.AddNewData(54);

        db.printData();
    }
}
