using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mäng
{
    public class Item : IEntity
    {
        private string nimetus;
        private int PunktideArv;
        public Item(int punktideArv, string nimetus)
        {
            this.nimetus = nimetus;
            this.PunktideArv = punktideArv;
        }

        public int punktideArv()
        {
            return PunktideArv;
        }

        public string meetodInfo()
        {
            Console.WriteLine(nimetus);
            return nimetus;
        }

    }
