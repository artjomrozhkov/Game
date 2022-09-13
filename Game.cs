using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mäng
{
    internal class Game
    {
        private Character[] characters;
        public Game(Character[] characters)
        {
            this.characters = characters;
        }
        public List<Character> suurimaEsemeteArvuga()
        {
            Character player = characters[0];
            List<Character> list = new List<Character>();
            foreach (Character item in characters)
            {
                int check=player.CompareTo(item);
                if (check < 0)
                {
                    player = item;
                    list.Clear();
                }
                else if (check > 0)
                {
                    list.Add(item);
                }
                list.Add(player);
                return list;
            }
            public Character suurimaPunktideArvuga()
            {
                foreach (Character item in characters)
                {

                }
            }
        }
    }
}
