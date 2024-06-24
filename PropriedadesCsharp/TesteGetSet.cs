using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropriedadesCsharp
{
    internal class TesteGetSet
    {
        static void Main (string[] args)
        {
            Pessoa meuObjetoFavorito = new Pessoa();
            meuObjetoFavorito.Nome = "LEONARDO"; // utilizei "Nome" e não "nome", pois "Nome" é public!
            Console.WriteLine(meuObjetoFavorito.Nome);
        }
    }
}
