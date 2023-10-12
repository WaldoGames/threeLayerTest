using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Classes
{
    public class Numbers : INumbers
    {
        DBcontext DBcontext = new DBcontext();

        public bool AddNumber(int number)
        {
            return DBcontext.TryAddNumber(number);
        }

        public List<int> GetNumbers()
        {
            return DBcontext.TryGetNumbers();
        }

        public bool RemoveNumber(int number)
        {
            return DBcontext.TryRemoveNumber(number);
        }
    }
}
