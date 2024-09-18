using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject.TokoSepeda
{
    public class Sepeda
    {
        public string Merk { get; set; }
        public string Tipe { get; set; }
        public double Berat { get; set; }

        // Konstruktor yang menerima int untuk Berat
        public Sepeda(string merk, string tipe, double berat)
        {
            Merk = merk;
            Tipe = tipe;
            Berat = berat;
        }

        public void TampilkanInformasi()
        {
        // Menampilkan berat sebagai integer
            Console.WriteLine($"Merek: {Merk}, Tipe: {Tipe}, Berat: {Berat.ToString(CultureInfo.InvariantCulture)} kg");
        }
    }
}

