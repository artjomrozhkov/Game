using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mäng
{
    internal class Game
    {
        private Tegelene[] tegelased;

        public Game(Tegelene[] tegelased)
        {
            this.tegelased = tegelased;
        }
        public List<Tegelene> SuurimaEsemeteArvuga()
        {
            List<Tegelene> voitjad = new List<Tegelene>();
            Tegelene sorted = tegelased[0];
            foreach (Tegelene t in tegelased)
            {
                int num = sorted.CompareTo(t);
                if (num < 0)
                {
                    sorted = t;
                    voitjad.Clear();
                }
                if (num==0)
                {
                    voitjad.Add(t);
                }
            }
            voitjad.Add(sorted);
            return voitjad;
        }
        public Tegelene suurimaPunktideArvuga()
        {
            int parim = 0;
            Tegelene voitja = tegelased[0];
            foreach (var t in tegelased)
            {
                int arv = t.punktideArv();
                if (arv>parim)
                {
                    parim = arv;
                    voitja = t;
                }
            }
            return voitja;
        }
    }
}
