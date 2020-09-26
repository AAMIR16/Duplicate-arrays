using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            // counting # of duplicate vlues
            int ctr = 0;
            int[] a = new int[] { 5, 7, 3, 5, 7, 1, 3};

            for (int i = 0; i < a.Length; i++)
            {
                for (int j= i+1;  j<a.Length; j++)
                {
                    if (a[i] != a[j])
                    {
                        ctr++;
                    }
                }
            }
            Console.WriteLine("# of duplicate values are: " +ctr);
            Console.ReadLine();
            
        }
    }
}
