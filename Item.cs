using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mäng
{
    public interface IEntity
    {
        string Info(int esemeteNumber);
        int pointsNumber();
    }
    class Item : IEntity
    {
        public string Name;
        public int pointNumber;

        public Item(string Name, int pointNumber)
        {
            this.Name = Name;
            this.pointNumber = pointNumber;
        }
        public int pointsNumber()
        {
            throw new NotImplementedException();
        }
        int IEntity.pointsNumber()
        {
            return pointsNumber();
        }
        public string Info()
        {
            return Name;
        }

        public string Info(int esemeteNumber)
        {
            throw new NotImplementedException();
        }
    }
}
