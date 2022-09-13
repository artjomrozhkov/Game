using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mäng
{
    class Character : IEntity
    {
        public string Name;
        protected double m_value = 0.0;
        public 
        List<Item> item_list = new List<Item>();
        List<Character> characters = new List<Character>();
        public Character(string name)
        {
            Name = name;
        }
        public Item addItem(Item item)
        { return item; }
        public int pointsNumber()
        {
            int arv_item = 0;
            foreach (Item item in item_list)
            {
                arv_item+= item.pointsNumber();
            }
            return arv_item;
        }
        public string Info(int esemeteNumber)
        {
            string info=($"{Name}\nTEST{esemeteNumber}, point number{pointsNumber()}");
            return info;
        }
        public void issueItems()
        {
            foreach (Item item in item_list)
            {
                Console.WriteLine(item);
            }
        }
        public int CompareTo(Character other)
        {   
            if (other == null) return 1;
            return m_value.CompareTo(other.m_value);
        }
    }
}
