using System;
using System.Collections.Generic;
using System.Text;

namespace Kysymykset
{
    class KysymysVastaus
    {
        public string Kysymys { get; set; }
        public string Oikea { get; set; }

        public string Väärä { get; set; }

        public KysymysVastaus()
        {
        }

        public KysymysVastaus(string kysymys, string oikea, string väärä)
        {
            Kysymys = kysymys;
            Oikea = oikea;
            Väärä = väärä;
        }

        //override ToString()
        //{
        //    return Kysymys;
        //}
    }
}
