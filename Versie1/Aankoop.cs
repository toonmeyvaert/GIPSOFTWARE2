using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Versie1
{
    class Aankoop
    {
        private int intIdAankoop, intAantal;
        private double dblPrijs;
        private string strVoorwerp;

        public int idAankoop
        {
            get { return intIdAankoop; }
            set { intIdAankoop = value; }
        }
        public double prijs
        {
            get { return dblPrijs; }
            set { dblPrijs = value; }
        }
        public int aantal
        {
            get { return intAantal; }
            set { intAantal = value; }
        }
        public string voorwerp
        {
            get { return strVoorwerp; }
            set { strVoorwerp = value; }
        }

        public Aankoop(double pdblPrijs, int pintAantal, string pstrVoorwerp)
        {
            dblPrijs = pdblPrijs;
            intAantal = pintAantal;
            strVoorwerp = pstrVoorwerp;
        }
    }
}
