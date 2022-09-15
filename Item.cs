using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mäng
{
    //    2. Klass Ese realiseerib liidese Üksus.
    public class Ese : IEntity
    {
        //1. Klassis on privaatsed isendiväljad järgmise info jaoks: nimetus(String) ja punktide arv(int).
        private string nimetus;
        private int PunktideArv;

        //2. Klassis peab olema kahe parameetriga konstruktor, mille abil saab määrata nimetuse ja punktide
        public Ese(int punktideArv, string nimetus)
        {
            this.nimetus = nimetus;
            this.PunktideArv = punktideArv;
        }

        //3. Meetod punktideArv tagastab punktide arvu.
        public int punktideArv()
        {
            return PunktideArv;
        }

        //4. Meetod info tagastab selle eseme nimetuse.
        public string meetodInfo()
        {
            Console.WriteLine(nimetus);
            return nimetus;
        }

    }
