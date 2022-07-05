using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDSAlgorithm.RecursionModule
{
    internal class RecusionVsIteration
    {

        //Iterative method
        public void Calculateiterative(int n)
        {
            while(n > 0)
            {
                int k = n * n;
                Console.WriteLine(k);
                n--;
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Recursions methods
        /// </summary>
        /// <param name="n"></param>
        public void CalculateRecursive(int n)
        {
            if(n > 0)
            {
                int k = n * n;
                Console.WriteLine(k);
                CalculateRecursive(n-1);
            }
            Console.ReadKey();
        }
    }
}
