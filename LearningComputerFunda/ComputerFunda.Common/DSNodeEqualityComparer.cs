using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFunda.Common
{
    public class IntDSNodeEqualityComparer : IEqualityComparer<int>
    {
        public bool Equals(int x, int y)
        {
            return x == y; 
        }

        public int GetHashCode(int obj)
        {
            throw new NotImplementedException();
        }
    }
}
