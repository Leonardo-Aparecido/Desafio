// Escreva um programa que leia três lados de um triângulo e verifique se eles formam um triângulo válido. 
//Para isso, a soma de dois lados deve ser sempre maior que o terceiro lado. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
{
    internal class Exercicio4
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Insira a dimensão dos três lados de um triângulo e verifiarei se ele existe:");
            int dimensao1 = Convert.ToInt32(Console.ReadLine());
            int dimensao2 = Convert.ToInt32(Console.ReadLine());
            int dimensao3 = Convert.ToInt32(Console.ReadLine());
            if (dimensao1+dimensao2 > dimensao3 && dimensao1+dimensao3> dimensao2 && dimensao3 + dimensao2 > dimensao1)
            {
                Console.WriteLine("Seu triangulo existe");
            }
            else
            {
                Console.WriteLine("Seu trianngulo não existe");
            }
        }
    }
}
