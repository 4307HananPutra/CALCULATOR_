using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int hasil = 0;

            Console.WriteLine("Pilih Menu Calculator");
            Console.WriteLine("1.Penambahan");
            Console.WriteLine("2.Pengurangan");
            Console.WriteLine("3.Perkalian");
            Console.WriteLine("4.Pembagian");
            Console.Write("\nInput nomor menu [1...4] : ");
            int pilih = int.Parse(Console.ReadLine());

            if (pilih == 1)
            {
                Console.Write("nInputkan Nilai a = ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Inputkan Nilai b = ");
                b = Convert.ToInt32(Console.ReadLine());

                hasil = a + b;
                Console.WriteLine("\nHasil Penambahan " + a + " + " + b + " = " + hasil);
            }
            else if (pilih == 2)
            {
                Console.Write("\nInputkan Nilai a = ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Inputkan Nilai b = ");
                b = Convert.ToInt32(Console.ReadLine());

                hasil = a - b;
                Console.WriteLine("\nHasil Pengurangan " + a + " + " + b + " = " + hasil);
            }

            else if (pilih == 3)
            {
                Console.Write("\nInputkan Nilai a = ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Inputkan Nilai b = ");
                b = Convert.ToInt32(Console.ReadLine());

                hasil = a * b;
                Console.WriteLine("\nHasil Perkalian " + a + " * " + b + " = " + hasil);
            }
            else if (pilih == 4)
            {
                Console.Write("\nInputkan Nilai a = ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Inputkan Nilai b = ");
                b = Convert.ToInt32(Console.ReadLine());

                hasil = a / b;
                Console.WriteLine("\nHasil pembagian " + a + " / " + b + " = " + hasil);
            }

            else
            {
                Console.WriteLine("maaf, menu yang anda pilih tidak tersedia");
            }
            Console.WriteLine("Tekan sembarang untuk keluar..");
            Console.ReadKey();
        }
    }
}

