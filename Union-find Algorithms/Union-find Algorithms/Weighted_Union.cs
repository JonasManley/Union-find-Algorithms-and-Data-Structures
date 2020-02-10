using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Union_find_Algorithms
{
    public class Weighted_Union
    {
        private int[] parent;   // parent[i] = parent of i
        private int[] size;     // size[i] = number of sites in subtree rooted at i
        private int count;      // number of components


        public Weighted_Union(int N)
        {
            count = N;
            parent = new int[N];
            size = new int[N];
            for (int i = 0; i < N; i++)
            {
                parent[i] = i;
                size[i] = 1;
            }
        }

        //Find and validate p 
        public int Find(int p)
        {
            Validate(p);
            while (p != parent[p])
                p = parent[p];
            return p;
        }

        // validate that p is a valid index
        private void Validate(int p)
        {
            int N = parent.Length;
            if (p < 0 || p >= N)
            {
                throw new IndexOutOfRangeException
                ("index " + p + " is not between 0 and " + (N - 1));
            }
        }
        /// <summary>
        /// Not every used there.. but allow you to see wheater or not to members are connected. 
        /// </summary>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        public bool Connected(int p, int q)
        {
            return Find(p) == Find(q);
        }


        /// <summary>
        ///  Make all members of q's, set member of p - based on which union that has the most members
        /// </summary>
        /// <param name="p"></param>
        /// <param name="q"></param>
        public void Union(int p, int q)
        {
            int rootP = Find(p);
            int rootQ = Find(q);
            if (rootP == rootQ) return;

            // make smaller root point to larger one
            if (size[rootP] < size[rootQ])
            {
                parent[rootP] = rootQ;
                size[rootQ] += size[rootP];
            }
            else
            {
                parent[rootQ] = rootP;
                size[rootP] += size[rootQ];
            }
            count--;
        }

        /// <summary>
        /// Give a string that clear show how many member there are in different unions 
        /// </summary>
        /// <returns></returns>
        public string UnionSize()
        {
            string result = "";
            foreach (var item in size)
            {
                result += item.ToString();
            }
            return result;
        }

        /// <summary>
        /// Give a string which contains all the array with values 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            String result = "";
            for (int i = 0; i < parent.Length; i++)
            {
                result += parent[i] + " ";
            }
            return result;
        }
    }
}
