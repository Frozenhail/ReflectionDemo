using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo.Util
{
    class LamaUtil
    {
        public static Dictionary<string, object> DictionaryFromType(object atype)
        {
            if (atype == null) return new Dictionary<string, object>();
            Type t = atype.GetType();
            PropertyInfo[] props = t.GetProperties();
            Dictionary<string, object> dict = new Dictionary<string, object>();
            foreach (PropertyInfo prp in props)
            {
                object value = prp.GetValue(atype, new object[] { });
                dict.Add(prp.Name, value);
            }
            return dict;
        }

        public static void UpdateTypeFromDictionary(object atype, Dictionary<string, object> dictionary)
        {
            Type t = atype.GetType();
            PropertyInfo[] props = t.GetProperties();
            foreach (PropertyInfo p in props)
            {
                if (dictionary[p.Name] != null)
                {
                    object value = p.GetValue(atype, new object[] { });
                    if (value != Convert.ChangeType(dictionary[p.Name], p.PropertyType))
                    {
                        p.SetValue(atype, Convert.ChangeType(dictionary[p.Name], p.PropertyType), null);
                    }
                }
            }

        }

    }
}
