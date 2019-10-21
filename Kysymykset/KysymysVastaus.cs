using System;
using System.Collections.Generic;
using System.Text;

namespace Kysymykset
{
    class KysymysVastaus
    {
        public string Kysymys { get; set; }
        public string Vastaus { get; set; }

        public KysymysVastaus()
        {
        }

        public KysymysVastaus(string kysymys, string vastaus)
        {
            Kysymys = kysymys;
            Vastaus = vastaus;
        }

        //override ToString()
        //{
        //    return Kysymys;
        //}
    }
}
