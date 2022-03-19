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
            Console.WriteLine("NIM = 1302204008");
            Console.Write("13 + 02 + 20 = ");
            Penjumlahan<int>.JumlahTigaAngka(13, 02, 20);
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
