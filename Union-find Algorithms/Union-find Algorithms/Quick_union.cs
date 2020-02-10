using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Union_find_Algorithms
{
    class Quick_union : UnionFind
    {
        private int count;
        private int[] pointSets;  //Set of all values. 

        /// <summary>
        /// Setting up the data (by making a simple list with the descired amount of numbers "Count") 
        /// </summary>
        /// <param name="count"></param>
        public Quick_union(int count)
        {
            this.count = count;
            this.pointSets = new int[count];
            for (int i = 0; i < count; i++) pointSets[i] = i;
        } 

        /// <summary>
        /// Giving an index (id/identifyer) will return the specific unioun the descired value is a part of.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public int Find(int p)
        {
            return pointSets[p];
        }

        /// <summary>
        /// Checks if the are in the same union.
        /// </summary>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        public bool Connected(int p, int q)
        {
            if(Find(p) == Find(q))
            {
               return true;
            }
            return false;
        }

        /// <summary>
        /// Make all members of q's, set member of p.
        /// </summary>
        /// <param name="p"></param>
        /// <param name="q"></param>
        public void Union(int p, int q)
        {
            int setOfp = pointSets[p];
            int setOfq = pointSets[q];
            for (int i = 0; i < pointSets.Length; i++)
                if (pointSets[i] == setOfq) pointSets[i] = setOfp;
            count--;
        }


        /// <summary>
        /// returning the updated list.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            String result = "";
            for (int i = 0; i < pointSets.Length; i++)
            {
                result += pointSets[i] + " ";
            }
            return result;
        }
    }
}
