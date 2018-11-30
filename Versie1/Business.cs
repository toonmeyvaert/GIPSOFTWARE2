using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Versie1
{
    class Business
    {
        private Persistence _persistence;

        private List<Aankoop> _aankoop;
        public List<Aankoop> aankoop
        {
            get { return _aankoop; }
            set { _aankoop = value; }
        }

        public Business()
        {
            _persistence = new Persistence();
            _aankoop = _persistence.getAankoopFromDB();
        }

        public List<string> getAankopen()
        {
            List<string> result = new List<string>();
            foreach (Aankoop item in _aankoop)
            {
                result.Add(item.ToString());
            }
            return result;
        }

        public void voegToe(double pdblPrijs, int pintAantal, string pstrVoorwerp)
        {
            Aankoop a = new Aankoop(pdblPrijs, pintAantal, pstrVoorwerp);
            _persistence.addAankoop(a);
        }
    }
}
