using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void Catherine()
        {
            Console.WriteLine("Tugas Week 11\nCatherine Lim_0706022110002\n");
            Console.Write("");
        }
        static void Main(string[] args)
        {
            Catherine();
            int inputBilangan, jumlahFaktor, pengecekBilangan;
            string Ulang = "y";
            do
            {
                inputBilangan = 0;
                jumlahFaktor = 0;
                pengecekBilangan = 1;
                Console.Write("Masukan Bilangan= ");
                inputBilangan = Convert.ToInt16(Console.ReadLine());
                do
                {
                    if (inputBilangan % pengecekBilangan == 0)
                    {
                        jumlahFaktor = jumlahFaktor + 1;
                    }
                    pengecekBilangan = pengecekBilangan + 1;
                }
                while (pengecekBilangan <= inputBilangan);
                if (jumlahFaktor == 2)
                {
                    Console.Write("Bilangan Prima\n");
                }
                else
                {
                    Console.Write("Bukan Bilangan Prima\n");
                }
                Console.Write("\nApakah Ingin Mengulang Program?");
                Ulang = Console.ReadLine();
                Console.WriteLine("");
            }
            while (Ulang == "y" && Ulang != "n");
        }
    }
}
