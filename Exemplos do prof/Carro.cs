using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos_do_prof
{
    internal class Carro
    {
        public string Ano;
        public string Modelo;
        public string Cor;
        
        public Carro()
        {
            Ano = "1980";
            Modelo = "Opala";
            Cor = "Roxo";
        }
        public static void Main (string[] args)
        {
            Carro carrinho = new Carro();
            Console.WriteLine(carrinho.Modelo);
        }
    }
    
}
