using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtor00
{
    internal class Construtor
    {
        public string name;
        public string modelo;
        public string cor;

        //no trecho de código seguinte a passagem de parâmetros é feita por posição. Igual um vetor. 
        
        //Posição 0 = modeloNome

        public Construtor(string modeloNome, string modeloModelo , string modeloCor)
        {
            name = modeloNome;
            modelo = modeloModelo;
            cor =  modeloCor;
        }
    }
}
