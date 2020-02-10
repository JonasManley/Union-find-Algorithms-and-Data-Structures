using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Union_find_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Quick_union quick_Union = new Quick_union(10);
            Console.WriteLine($"the value of index 2 will be 3:  {quick_Union.Find(0)}");

            ////Quick union test
            //quick_Union.Union(7, 8);
            //Console.WriteLine(quick_Union.ToString());
            //quick_Union.Union(1, 3);
            //Console.WriteLine(quick_Union.ToString());
            //quick_Union.Union(2, 3);
            //Console.WriteLine(quick_Union.ToString());
            //quick_Union.Union(7, 9);
            //Console.WriteLine(quick_Union.ToString());
            //quick_Union.Union(9, 3);
            //Console.WriteLine(quick_Union.ToString());
            //quick_Union.Union(3, 4);
            //Console.WriteLine(quick_Union.ToString());
            //quick_Union.Union(5, 6);
            //Console.WriteLine(quick_Union.ToString());
            //quick_Union.Union(0, 5);
            //Console.WriteLine(quick_Union.ToString());


            //Weighted union test 
            Weighted_Union weightedQuickUnionUF = new Weighted_Union(10);
            weightedQuickUnionUF.Union(1, 5);
            Console.WriteLine(weightedQuickUnionUF.ToString());
            weightedQuickUnionUF.Union(5, 3);
            Console.WriteLine(weightedQuickUnionUF.ToString());
            weightedQuickUnionUF.Union(6, 2);
            Console.WriteLine(weightedQuickUnionUF.ToString());
            weightedQuickUnionUF.Union(6, 4);
            Console.WriteLine(weightedQuickUnionUF.ToString());
            weightedQuickUnionUF.Union(6, 9);
            Console.WriteLine(weightedQuickUnionUF.ToString());
            weightedQuickUnionUF.Union(8, 9);
            Console.WriteLine(weightedQuickUnionUF.ToString());
            weightedQuickUnionUF.Union(7, 5);
            Console.WriteLine(weightedQuickUnionUF.ToString());
            weightedQuickUnionUF.Union(0, 6);
            Console.WriteLine(weightedQuickUnionUF.ToString());
            weightedQuickUnionUF.Union(4, 0);
            Console.WriteLine(weightedQuickUnionUF.ToString());
            weightedQuickUnionUF.Union(0, 8);
            Console.WriteLine(weightedQuickUnionUF.ToString());

            Console.WriteLine("----------------------------------");
            Console.WriteLine(weightedQuickUnionUF.UnionSize());

            Console.ReadLine();


            Console.ReadLine();
        }
    }
}
