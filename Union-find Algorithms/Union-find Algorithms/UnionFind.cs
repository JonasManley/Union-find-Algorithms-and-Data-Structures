using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Union_find_Algorithms
{
    public interface UnionFind
    {
        void Union(int p, int q);
        int Find(int p);
        bool Connected(int p, int q);
    }
}
