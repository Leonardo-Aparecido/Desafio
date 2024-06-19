using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos_do_prof
{
    internal class ArrayMult
    {
        public static void Main(string[] args)
        {
            int[,] numero = { { 1, 2, 3 }, { 9, 30, 2 } };
            foreach (int i in numero)
            {
                Console.WriteLine(i);
            }
        }
    }
}
