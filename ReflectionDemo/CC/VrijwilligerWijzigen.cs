using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ReflectionDemo.BU;
using ReflectionDemo.Util;

namespace ReflectionDemo.CC
{
    class VrijwilligerWijzigen
    {
        private Vrijwilliger iemand = new Vrijwilliger();

        public VrijwilligerWijzigen()
        {
            iemand.Voornaam = "A";
            iemand.Achternaam = "B";
            iemand.Schoenmaat = -133;
            iemand.Geboortedatum = DateTime.Now;
        }

        public Dictionary<String, object> DoeIets()
        {
            return LamaUtil.DictionaryFromType(iemand);
        }

        public void DoeIetsAnders(Dictionary<String, object> vrijwilliger)
        {
            LamaUtil.UpdateTypeFromDictionary(iemand, vrijwilliger);
        }

    }
}
