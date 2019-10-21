using System;
using System.Collections.Generic;
using System.Threading;

namespace Kysymykset
{
    class Program
    {
        public static List<KysymysVastaus> KysVas = new List<KysymysVastaus>();

        static TiedostonLuku tl = new TiedostonLuku();

        static int oikein = 0;

        static void Main(string[] args)
        {
            //SoitaMario();

            Console.Beep();
            Console.Beep(659, 125);
            Console.Beep(659, 125);

            Console.Write("Anna nimi: ");
            string pelaaja = Console.ReadLine();
            List<string> luetutRivit = tl.LueTiedostonRivit();
            TeeOlioita(luetutRivit);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Vastaa kyllä tai ei. Kysymys " + (i + 1) + ":");
                oikein = KysyKysymys(oikein);
                Thread.Sleep(1500);
                Console.Clear();
            }

            Console.WriteLine($"Peli päättyi. {pelaaja}, sait {oikein} / 10 pistettä.");
            SoitaMario();

        }

        static void TeeOlioita(List<string> luetutRivit)
        {
            foreach (var rivi in luetutRivit)
            {
                if (rivi.Trim().Length != 0)
                {
                    var arvot = rivi.Split(';');
                    KysymysVastaus uusikysvas = new KysymysVastaus(arvot[0], arvot[1], arvot[2]); // 0 = kysymys, 1 = oikea, 2 = väärä
                    KysVas.Add(uusikysvas);
                }
            }
        }

        static int KysyKysymys(int oikein)
        {
            int o = oikein;
            Random arpoja = new Random();

            int kysnro = arpoja.Next(0, KysVas.Count);

            Console.Clear();
            bool vastaus = Kysy(kysnro);


            if (vastaus)
            {
                Console.Beep(500, 100);
                Thread.Sleep(100);
                Console.Beep(800, 500);
                Console.WriteLine("Oikein!");

                o++;
            }
            else
            {
                SoitaVäärä();
                Console.WriteLine("Väärin >:( ");
            }

            KysVas.Remove(KysVas[kysnro]);

            bool Kysy(int nro)
            {
                Console.WriteLine(KysVas[nro].Kysymys);


                Random kumpiensin = new Random();
                int ke = kumpiensin.Next(1, 3);
                int oik = default;

                switch (ke)
                {
                    case 1:
                        Console.WriteLine($"1 = { KysVas[nro].Oikea}");
                        Console.WriteLine($"2 = { KysVas[nro].Väärä}");
                        oik = 1;
                        break;

                    case 2:
                        Console.WriteLine($"1 = {KysVas[nro].Väärä}");
                        Console.WriteLine($"2 = {KysVas[nro].Oikea}");
                        oik = 2;
                        break;
                }

                int v = default;

                do
                {
                    Console.WriteLine();
                    Console.WriteLine("Anna oikean vastauksen numero ja paina enter:");
                    Console.WriteLine();
                    int.TryParse(Console.ReadLine().Trim(), out v);
                } while (v < 1 || v > 2);

                return v == oik;
            }

            return o;
        }

        static void SoitaMario()
        {
            Console.Beep(659, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(523, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(375); Console.Beep(392, 125); Thread.Sleep(375); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(375); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125); Thread.Sleep(1125); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125);
        }

        static void SoitaVäärä()
        {
            Console.Beep(500, 100);
            Thread.Sleep(100);
            Console.Beep(300, 500);
        }
    }
}
