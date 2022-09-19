using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mäng
{
    class Character : IEntity, IComparable<Character>
    {
        private string nimi;
        List<Item> eseList;
        public Character(string nimi)
        {
            this.nimi = nimi;
            eseList = new List<Item>();
        }
        public int lisaitem(int arv)
        {
            return arv;
        }

        public void Equip(Item Item) { eseList.Add(ese); }

        public int punktideArv()
        {
            int summa = 0;
            foreach (Item Item in eseList)
            {
                summa += ese.punktideArv();
            }
            return summa;
        }


        public string meetodInfo()
        {
            string teg_info = $"Tegelase nime - {nimi}, esemete arv - {eseList.Count}, punktide arv - {punktideArv()}";
            return teg_info;
        }


        public void valjastaEsemed()
        {
            foreach (Item item in eseList)
            {
                Console.WriteLine(ese.meetodInfo());
            }
        }

   

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
