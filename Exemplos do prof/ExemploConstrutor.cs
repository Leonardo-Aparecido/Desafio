using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos_do_prof
{
    internal class ExemploConstrutor
    {
       public string modelo;
       public ExemploConstrutor()
        {
            modelo = "Mustang";
        }
        public static void Main (string[] args)
        {
            ExemploConstrutor meuObjetoFavorito = new ExemploConstrutor();
            Console.WriteLine("O modelo do carro é:"+meuObjetoFavorito.modelo);
        }
    }
}
