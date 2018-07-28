using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFunda.Algorithm.Sort
{
    public interface ISort<T>
    {
        T[] Sort(T[] arr);

        T[] SortDesc(T[] arr);
    }
}
