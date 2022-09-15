using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mäng
{
    //    3. Klass Character realiseerib liidese Üksus.
    class Character : IEntity, IComparable<Character>
    {
        //1. Klassis on privaatsed isendiväljad järgmise info jaoks: nimi(String) ja esemete nimekiri
        private string nimi;
        List<Ese> eseList;

        //2. Klassis peab olema ühe parameetriga konstruktor, mille abil saab määrata nime.
        public Character(string nimi)
        {
            this.nimi = nimi;
            eseList = new List<Ese>();
        }

        //3. Äsjaloodud tegelasel ei ole ühtegi eset. Eseme lisamiseks peab olema meetod lisaEse, mis jätab argumendiks antud eseme meelde.
        public int lisaEse(int arv)
        {
            return arv;
        }

        public void Equip(Ese ese) { eseList.Add(ese); }

        //4. Meetod punktideArv tagastab punktide arvu.
        public int punktideArv()
        {
            int summa = 0;
            foreach (Ese ese in eseList)
            {
                summa += ese.punktideArv();
            }
            return summa;
        }

        //5. Meetod info tagastab selle eseme nimetuse.
        public string meetodInfo()
        {
            string teg_info = $"Tegelase nime - {nimi}, esemete arv - {eseList.Count}, punktide arv - {punktideArv()}";
            return teg_info;
        }

        //6. Klassis peab olema ka meetod väljastaEsemed, kus väljastatakse ekraanile tegelase esemed nii, et iga ese on eraldi real.
        public void valjastaEsemed()
        {
            foreach (Ese ese in eseList)
            {
                Console.WriteLine(ese.meetodInfo());
            }
        }

        //7. Klass Character realiseerib liidese Comparable<Character>, kusjuures compareTo meetod realiseeritakse nii, et võrdlemine toimub esemete arvu alusel. (Näidis kood)

        public int CompareTo(Character? muu)
        {
            if (muu==null)
            {
                return 1;
            }
            return this.eseList.Count - muu.eseKogus();
        }
        private int eseKogus() { return this.eseList.Count; }
        
    }
}
