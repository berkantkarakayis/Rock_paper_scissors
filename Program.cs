using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tas_Kagıt_Makas
{
    class Program
    {
        static void Main(string[] args)
        {
            int uzunluk = 0;
            Console.Write("Hoşgeldiniz! Bu oyunu kaç kez oynamak istersiniz : ");
            uzunluk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            for (int i = 0; i < uzunluk; i++)
            {
                Console.WriteLine(i + 1 + ".Tur İçin Seçiminizi Yapın:");
                Console.WriteLine("----------------------------");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Taş = t" + "\n" + "Kağıt = k" + "\n" + "Makas = m");
                Console.ResetColor();
                Console.WriteLine("----------------------------");

                string tas, kagit, makas;
                char secim;
                int sayi = 0;
                string kr = " ";
                Random rnd = new Random();

                secim = Convert.ToChar(Console.ReadLine());

                if (secim == 't')
                {
                    Console.WriteLine("Siz Taş'ı seçtiniz");
                    sayi = rnd.Next(1, 3);
                    if (sayi == 1)
                    {
                        kr = "Taş";
                        Console.WriteLine("Bilgisayar " + kr + "'ı seçti");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Oyun berabere"+"\n");
                        Console.ResetColor();
                    }
                    else if (sayi == 2)
                    {
                        kr = "Kağıt";
                        Console.WriteLine("Bilgisayar " + kr + "'ı seçti");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("!Kağıt taşı sarar bu oyunu bilgisayar kazandı!" + "\n");
                        Console.ResetColor();
                    }
                    else if (sayi == 3)
                    {
                        kr = "Makas";
                        Console.WriteLine("Bilgisayar " + kr + "'ı seçti");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("!Taş makası kırar bu oyunu siz kazandınız!\n*Tebrikler*" + "\n");
                        Console.ResetColor();
                    }
                }
                else if (secim == 'k')
                {
                    Console.WriteLine("Siz Kağıt'ı seçtiniz");
                    sayi = rnd.Next(1, 3);
                    if (sayi == 1)
                    {
                        kr = "Taş";
                        Console.WriteLine("Bilgisayar " + kr + "'ı seçti");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("!Kağıt taşı sarar bu oyunu siz kazandınız!\n*Tebrikler*" + "\n");
                        Console.ResetColor();
                    }
                    else if (sayi == 2)
                    {
                        kr = "Kağıt";
                        Console.WriteLine("Bilgisayar " + kr + "'ı seçti");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Oyun berabere" + "\n");
                        Console.ResetColor();
                    }
                    else if (sayi == 3)
                    {
                        kr = "Makas";
                        Console.WriteLine("Bilgisayar " + kr + "'ı seçti");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("!Makas kağıdı keser bu oyunu bilgisayar kazandı!" + "\n");
                        Console.ResetColor();
                    }
                }

                else if (secim == 'm')
                {
                    Console.WriteLine("Siz Makas'ı seçtiniz");
                    sayi = rnd.Next(1, 3);
                    if (sayi == 1)
                    {
                        kr = "Taş";
                        Console.WriteLine("Bilgisayar " + kr + "'ı seçti");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("!Taş makası kırar bu oyunu bilgisayar kazandı" + "\n");
                        Console.ResetColor();
                    }
                    else if (sayi == 2)
                    {
                        kr = "Kağıt";
                        Console.WriteLine("Bilgisayar " + kr + "'ı seçti");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("!Makas kağıdı keser bu oyunu siz kazandınız!\n*Tebrikler*" + "\n");
                        Console.ResetColor();
                    }
                    else if (sayi == 3)
                    {
                        kr = "Makas";
                        Console.WriteLine("Bilgisayar " + kr + "'ı seçti");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("!Oyun berabere" + "\n");
                        Console.ResetColor();
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
