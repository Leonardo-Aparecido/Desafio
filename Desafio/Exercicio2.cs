//Escreva um programa que leia um número inteiro e informe se ele é positivo, negativo ou zero.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
{
    internal class Exercicio2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Insira seu numero, seja ela positivo ou negativo:");
            
            long numero = Convert. ToInt32(Console.ReadLine());
            if (numero == 0)
            {
                Console.WriteLine("Seu numero é nulo");
            }
            else if (numero >0)
            {
                Console.WriteLine("Seu numero é positivo");
            }
            else
            {
                Console.WriteLine("Seu número é negativo");
            }
        }
    }
}
