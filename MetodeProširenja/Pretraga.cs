using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp
{
    public class Pretraga
    {
        public static bool Sadrži(IEnumerable<string> nizRiječi, string tražena)
        {
            /*
            foreach(string rijec in nizRiječi)
            {
                if (rijec == tražena) return true;
            }
            throw new NotImplementedException();
            */
            return nizRiječi.Contains(tražena);
        }

        public static int Zbroj(IEnumerable<int> brojevi)
        {
            /*
            int zbroj = 0;
            foreach(int broj in brojevi)
            {
                zbroj += broj;
            }return zbroj;

            //throw new NotImplementedException();
            */
            return brojevi.Sum();
        }

        public static IEnumerable<string> NađiSveIza(IEnumerable<string> riječi, string riječ)
        {
           return  riječi.Where(r => r.CompareTo(riječ) > 0);
          // throw new NotImplementedException();
        }
    }
}
