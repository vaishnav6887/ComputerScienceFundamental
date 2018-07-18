using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFunda.Algorithm.Search
{
    public interface ISearch<T>
    {
        int Search(T item);
    }
}
