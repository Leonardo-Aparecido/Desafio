using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos_do_prof
{
    internal class ExemploArraySort2
    {
        public static void Main(string[] args)
        {
            int[] numero = { 1, 2, 39, 4, 55, 6, 73 };
            Array.Sort(numero);
            foreach (int i in numero)
            {
                Console.WriteLine(i);
            }
        }
    }
}