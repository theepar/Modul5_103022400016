using System;
using System.Security.Cryptography.X509Certificates;

public class SimpleDataBase<T>
{
	List<T> StoreData;
    List<DateTime> inputDates;

    public SimpleDataBase()
    {
        this.StoreData = new List<T>();
        this.inputDates = new List<DateTime>();
    }

    public void AddNewData(T dbbaru)
    {
        this.StoreData.Add(dbbaru);
        this.inputDates.Add(System.DateTime.Now);
    }

    public void printData()
    {
        for (int i = 0; i < StoreData.Count; i++)
        {
            Console.WriteLine("Data " + i + "berisi" + StoreData[i] + ",yang disimpan pada waktu UTC: " + inputDates[i]);
        }
    }
}


