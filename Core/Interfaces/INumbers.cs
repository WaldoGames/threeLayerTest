using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface INumbers
    {
        public List<int> GetNumbers();

        public bool AddNumber(int number);

        public bool RemoveNumber(int number);



    }
}
