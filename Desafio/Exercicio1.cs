//Escreva um programa que leia um número inteiro e informe se ele é par ou ímpar.
using System;

namespace Desafio
{
    internal class Exercicio1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Escreva seu numero para identifica-lo como ímpar ou par:");
            int numero = Convert.ToInt32(Console.ReadLine());
            int auxiliar = numero % 2;
            if (auxiliar == 0)
            {
                Console.WriteLine("Parabéns, seu número é par!");
            }
            else
            {
                Console.WriteLine("Que infortúnio! Seu número é impar");
            }
        }
    }
}
