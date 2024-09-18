using System;
using ClassAndObject.Kendaraan;
using ClassAndObject.OperasiMatematika;
using ClassAndObject.Perpustakaan;
using ClassAndObject.TokoLaptop;
using ClassAndObject.TokoSepeda;

namespace ClassAndObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Buku
            Buku buku1 = new Buku("Apaan Ya", "Budi", 2024);
            buku1.TampilkanInfo();

            // Kendaraan
            Mobil mobil1 = new Mobil("Toyota", "Avanza", 2020);
            mobil1.TampilkanSpesifikasi();

            // Laptop
            Laptop laptop1 = new Laptop("Dell", "Intel i7", 16, 512);
            laptop1.TampilkanSpesifikasi();

            // Sepeda
            Sepeda sepeda1 = new Sepeda("Polygon", "Mountain Bike", 15.5);
            sepeda1.TampilkanInformasi();

            // Kalkulator
            Kalkulator kalkulator = new Kalkulator();
            Console.WriteLine($"Penjumlahan: {kalkulator.Tambah(10, 5)}");
            Console.WriteLine($"Pengurangan: {kalkulator.Kurang(10, 5)}");
            Console.WriteLine($"Perkalian: {kalkulator.Kali(10, 5)}");
            Console.WriteLine($"Pembagian: {kalkulator.Bagi(10, 5)}");
        }
    }
}
