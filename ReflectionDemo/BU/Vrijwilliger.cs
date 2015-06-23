using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo.BU
{
    class Vrijwilliger
    {
        private String voornaam;
        private String achternaam;
        private int schoenmaat;
        private DateTime geboortedatum;

        public string Voornaam
        {
            get { return voornaam; }
            set { voornaam = value; }
        }

        public string Achternaam
        {
            get { return achternaam; }
            set { achternaam = value; }
        }

        public int Schoenmaat
        {
            get { return schoenmaat; }
            set { schoenmaat = value; }
        }

        public DateTime Geboortedatum
        {
            get { return geboortedatum; }
            set { geboortedatum = value; }
        }
    }
}
