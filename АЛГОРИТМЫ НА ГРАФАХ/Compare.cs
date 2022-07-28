using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace АЛГОРИТМЫ_НА_ГРАФАХ
{
    class EdgeCompare : IComparer<Edge>
    {
        public int Compare(Edge x, Edge y)
        {
            if (x.value > y.value)
                return 1;
            else
            if (x.value == y.value)
                return 0;
            else
                return -1;
        }
    }
}
