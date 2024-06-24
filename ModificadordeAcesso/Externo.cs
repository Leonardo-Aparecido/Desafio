using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadordeAcesso
{
    internal class Externo
    {
        static void Main(string[] args)
        {
            Eletronico meuComponente = new Eletronico();
            Console.WriteLine(meuComponente.diodo); //programa nao executa pois o campo/variável/atributo é privado e não pode ser acessado!
        }
    }
}
