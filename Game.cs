using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mäng
{
    //    4. Klassis Mäng peab olema privaatne isendiväli fikseeritud pikkusega tegelaste nimekirja
    //(Tegelane[]) jaoks.Klassis peab olema ühe parameetriga konstruktor, mille abil saab määrata tegelaste
    //nimekirja.
    internal class Game
    {
        private Tegelene[] tegelased;

        public Mang(Tegelene[] tegelased)
        {
            this.tegelased = tegelased;
        }
        //1. Klassis on Tegelane-tüüpi parameetriteta meetod suurimaEsemeteArvuga, mis tagastab
        //suurima esemete arvuga tegelase.Meetodis tegelased sorteeritakse vastavalt meetodis compareTo
        //kirjeldatud järjekorrale ja sorteeritud massiivist võetakse suurima esemete arvuga tegelast.
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
        //2. Klassis on Tegelane-tüüpi parameetriteta meetod suurimaPunktideArvuga, mis tagastab suurima punktide arvuga tegelase.
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
