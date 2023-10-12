using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Core.Classes
{
    public class MathGuyObject
    {
        INumbers Numbers;

        public MathGuyObject(INumbers numbers)
        {
           Numbers = numbers;
        }

        public int GetAllNumbers()
        {
            return Numbers.GetNumbers().Sum();
        }

        public void AddNumber(int number)
        {
            Numbers.AddNumber(number);
        }
        public void RemoveNumber(int number) { 
            Numbers.RemoveNumber(number);
        }
    }
}
