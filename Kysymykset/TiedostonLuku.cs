using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Kysymykset
{
    class TiedostonLuku
    {
        private string sijainti = @"..\..\..\KysymyksetJaVastaukset.txt";
        StreamReader sr;

        public StreamReader TeeStreamReader()
        {

            if (!File.Exists(sijainti))
            {
                Console.WriteLine("Virheellinen tiedostosijainti");
                //File.Create(sijainti);
                sr = null;
            }

            else
            {
                sr = new StreamReader(sijainti);
            }
            return sr;
        }

        public List<string> LueTiedostonRivit()
        {
            TeeStreamReader();

            List<string> luetutRivit = new List<string>();
            string luettuRivi;

            while ((luettuRivi = sr.ReadLine()) != null)
            {
                luetutRivit.Add(luettuRivi);
            }

            sr.Dispose();

            return luetutRivit;
        }
    }
}
