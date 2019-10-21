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
            string vastaus;

            do
            {
                Console.Clear();
                vastaus = Kysy(kysnro);
                

                if (vastaus == KysVas[kysnro].Oikea)
                {
                    Console.Beep(500, 100);
                    Thread.Sleep(100);
                    Console.Beep(800, 500);
                    Console.WriteLine("Oikein!");

                    o++;
                }
                else if (vastaus == KysVas[kysnro].Väärä)
                {
                    SoitaVäärä();
                    Console.WriteLine("Väärin >:( ");
                }

            } while (vastaus != KysVas[kysnro].Väärä && vastaus != KysVas[kysnro].Oikea);

            KysVas.Remove(KysVas[kysnro]);

            string Kysy(int nro)
            {
                Console.WriteLine(KysVas[nro].Kysymys);
                Console.WriteLine(KysVas[nro].Oikea);
                Console.WriteLine(KysVas[nro].Väärä);
                string v = Console.ReadLine().ToLower().Trim();
                return v;
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
