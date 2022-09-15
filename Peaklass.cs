using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Mäng
{
    //  5. Peaklass peab olema nimega Peaklass.
    internal static class Peaklass
    {
        public static Random rnd = new Random();
        //1. Rakendatakse vastavat staatilist meetodit, et lugeda failist esemed.txt esemete andmed.
        public static List<Item> LoeEsemed()
        {
            List<Item> list = new List<Item>();
            StreamReader sr = new StreamReader(@"..\..\..\item_list.txt");
            while (!sr.EndOfStream)
            {
                string[] info = sr.ReadLine().Split(";");
                Item Item = new Item(stringToInt(info[1]), info[0]);
                list.Add(Item);
            }
            return list;
        }

        static int stringToInt(string s)
        {
            int y = 0;
            int total = 0;
            for (int i = 0; i < s.Length; i++)
                y = y * 10 + (s[i] - '0');
            total += y;
            return total;
        }
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        static string getName()
        {
            //2.Luuakse vähemalt 5 tegelast(nimed mõelge ise välja).
            string[] nimed = { "GigaChad", "Abobus", "Henry", "Nikita", "Genadi" };
            return nimed[rnd.Next(nimed.Length)];
        }

        static Character[] populatePlayers(int plrCount)
        {
            if (plrCount < 4) throw new Exception();
            Character[] plrs = new Character[plrCount];
            for (int i = 0; i < plrCount; i++)
            {
                Character plr = new Character(getName());
                plrs[i] = plr;
            }

            return giveOutItems(plrs);
        }

        static Character[] giveOutItems(Character[] plrs)
        {
            List<Ese> itemList = LoeEsemed();
            if (itemList.Count <= 0) throw new ArgumentOutOfRangeException();
            //4. Iga tegelase jaoks genereeritakse juhuslik arv n vahemikust[2, 10], mis näitab selle tegelase esemete
            //arvu.Iga tegelase jaoks valitakse juhuslikult n eset.
            foreach (Character plr in plrs)
            {
                Shuffle(itemList);
                int amount = rnd.Next(2, 10);
                for (int i = 0; i < amount; i++)
                {
                    plr.Equip(itemList[i]);
                }
            }
            return plrs;
        }

        static public void PlayGame(int plrCount)
        {
            //6. Luuakse mäng kasutades tegelaste massiivi.
            Character[] plrs = populatePlayers(plrCount);
            Game Game = new Game(plrs);
            //5. Tegelaste info ja esemed väljastatakse ekraanile (kasutades vastavaid meetodeid).
            foreach (Character winner in Game.SuurimaEsemeteArvuga())
            {
                Console.WriteLine(winner.meetodInfo());
            }
            Character win = Game.suurimaPunktideArvuga();
            Console.WriteLine(win.meetodInfo());
            Console.WriteLine("Tegelasel oli need esed:");
            Console.WriteLine("-------------------------------");
            //8.Leitakse ja väljastatakse ekraanile suurima punktide arvuga tegelase info(kasutades vastavaid meetodeid).
            win.valjastaEsemed();
            Console.WriteLine("-------------------------------");

        }
        public static void Game()
        {
            Console.WriteLine("Kas te soovite mängida? Ja/Ei");
            string yesorno = Console.ReadLine();
            if (yesorno == "Ja")
            {
                Console.WriteLine("\n");
                Peaklass.PlayGame(8);
                Console.WriteLine("Veel üks kord? Ja/Ei");
                string yesorno1 = Console.ReadLine();
                while (yesorno1 == "Ja")
                {
                    Console.WriteLine("\n");
                    Peaklass.PlayGame(8);
                    Console.WriteLine("Veel üks kord? Ja/Ei");
                    string yesorno2 = Console.ReadLine();
                    if (yesorno2 == "Ja")
                    {

                    }
                    else
                    {
                        Console.WriteLine("Head Aega!");
                        Environment.Exit(0);
                    }
                }
            }
            else
            {
                Console.WriteLine("\n");
                Console.WriteLine("Head Aega!");
            }
        }
    }
}
