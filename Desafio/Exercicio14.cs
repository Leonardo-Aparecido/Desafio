//14) Escreva um programa que leia um número e informe se ele é positivo ou negativo.
//Se for positivo, calcule a raiz quadrada; se for negativo, informe o número ao quadrado. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
{
    internal class Exercicio14
    {
        public static  void Main(string[] args)
        {
            int numero = Convert.ToInt32(Console.ReadLine());     
            if (numero <=0)
            {
                Console.WriteLine(Math.Sqrt(numero));
            }
            else
            {
                Console.WriteLine(Math.Pow(numero,2));//Comentario
            }

        }
    }
}
