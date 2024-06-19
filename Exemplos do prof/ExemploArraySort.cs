using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos_do_prof
{
    internal class ExemploArraySort
    {
        public static void Main(string[] args)
        {
            string[] carro = {"BMW","FIAT","VOLVO" };
            Array.Sort(carro);
            foreach (string i in carro)
            {
                Console.WriteLine(i);
            }
        }
    }
}
