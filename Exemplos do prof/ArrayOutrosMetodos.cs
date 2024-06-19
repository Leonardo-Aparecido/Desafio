using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos_do_prof
{
    internal class ArrayOutrosMetodos
    {
        public static void Main(string[] args)
        {
            int[] numero = { 10000, 2, 3, 43, 5, 6, 557, 8, 9, 103, 11, 12, 13, 14, 15 };
            Console.WriteLine(numero.Length);
            Console.WriteLine(numero[5]);
            Console.WriteLine(numero.Max());
            Console.WriteLine(numero.Min());
            Console.WriteLine(numero.Average());

        }
    }
}
