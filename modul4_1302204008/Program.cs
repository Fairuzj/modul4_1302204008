using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302204008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleDataBase<int> simpleData = new SimpleDataBase<int>();
            simpleData.AddNewData(13);
            simpleData.AddNewData(02);
            simpleData.AddNewData(20);
            simpleData.PrintAllData();
        }
    }
    public class SimpleDataBase<T>
    {
        List<T> storedData;
        List<DateTime> inputDates;

        public SimpleDataBase()
        {
            this.storedData = new List<T>();
            this.inputDates = new List<DateTime>();
        }
        public void AddNewData(T data)
        {
            storedData.Add(data);
            inputDates.Add(DateTime.Now);
        }
        public void PrintAllData()
        {
            for(int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine("Data " + (i + 1) + " berisi : " + storedData[i] + ",yang disimpan pada waktu UTC: " + inputDates[i]);
            }
        }
    }
}
