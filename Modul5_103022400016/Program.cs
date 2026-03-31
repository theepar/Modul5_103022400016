using Modul5_103022400016;
using System;

public class Program
{
	public static void Main(string[] args)
	{
		PemrosesData data = new PemrosesData();
		int nilai = data.DapatkanNilaiTerbesar<int>(10, 03, 02);
		Console.WriteLine("nilai terbesar :" + nilai);
	}
}
