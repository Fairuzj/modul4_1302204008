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
            Console.WriteLine("Soal 1");
            Console.WriteLine("NIM = 1302204008");
            Console.Write("13 + 02 + 20 = ");
            Penjumlahan<int>.JumlahTigaAngka(13, 02, 20);
            Console.WriteLine();

            Console.WriteLine("Soal 2");
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
    public class Penjumlahan<T> {
        private T angka;

        public Penjumlahan(T angka)
        {
            this.angka = angka;
        }
        public static void JumlahTigaAngka(T x, T y, T z)
        {
            dynamic X = x;
            dynamic Y = y;
            dynamic Z = z;
            Console.WriteLine(X + Y + Z);
        }
    }
}
