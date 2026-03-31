using Modul5_103022400016;
using System;

public class Program
{
	public static void Main(string[] args)
	{
		PemrosesData data = new PemrosesData();
		int nilai = data.DapatkanNilaiTerbesar<int>(10, 30, 22);
		Console.WriteLine("nilai terbesar :" + nilai);

        SimpleDataBase<int> db = new SimpleDataBase<int>();
        db.AddNewData(10);
        db.AddNewData(30);
        db.AddNewData(22);

        db.printData();
    }
}
