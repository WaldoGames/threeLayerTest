using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Classes
{
    internal class DBcontext
    {
        List<int> Values= new List<int>();

        public bool TryAddNumber(int number)
        {
            if (!Values.Contains(number))
            {
                Values.Add(number);
                return true;
            }else
            {
                return false;
            }
        }
        public bool TryRemoveNumber(int number)
        {
            if (Values.Contains(number))
            {
                Values.Remove(number);
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<int> TryGetNumbers()
        {
            return Values;
        }
    }
}
