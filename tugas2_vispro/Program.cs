using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas2_vispro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Nilai_1, Nilai_2;
            double nilai_1, nilai_2, a, b, c, d;

            Console.Write("Masukkan Nilai 1: ");
            Nilai_1 = Console.ReadLine();
            Console.Write("Masukkan Nilai 2: ");
            Nilai_2 = Console.ReadLine();

            nilai_1 = Convert.ToDouble(Nilai_1);
            nilai_2 = Convert.ToDouble(Nilai_2);

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Console.Write("Pilih A untuk penambahan\n");
            Console.Write("Pilih B untuk pengurangan\n");
            Console.Write("Pilih C untuk perkalian\n");
            Console.Write("Pilih D untuk pembagian\n");

            a = nilai_1 + nilai_2;
            b = nilai_1 - nilai_2;
            c = nilai_1 * nilai_2;
            d = nilai_1 / nilai_2;

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            string pilihan;
            Console.Write("Silahkan Masukan Pilihan [A/B/C/D]: ");
            pilihan = Console.ReadLine();

            switch(pilihan)
            {
                case "A":
                    Console.Write("\nMaka hasil perhitungan dari {0} ditambah {1} adalah {2}", nilai_1,nilai_2, a);
                    break;
                case "B":
                    Console.Write("Maka hasil perhitungan dari {0} dikurang {1} adalah {2}", nilai_1, nilai_2, b);
                    break;
                case "C":
                    Console.Write("Maka hasil perhitungan dari {0} dikali {1} adalah {2}", nilai_1,nilai_2, c);
                    break;
                case "D":
                    Console.Write("Maka hasil perhitungan dari {0} dibagi {1} adalah {2}", nilai_1, nilai_2, d);
                    break;
                default:
                    Console.Write("Pilihan tidak tersedia");
                    break;


            
            }
            Console.Read();
        }
    }
}
