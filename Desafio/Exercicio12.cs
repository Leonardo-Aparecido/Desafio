//Escreva um programa que leia um número e verifique se ele é maior que 100. Se não for, informe o dobro desse número.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
{
    internal class Exercicio12
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Insira seu número, vou verificar se ele é maior que 100");
            int numero = Convert.ToInt32(Console.ReadLine());
            if (numero > 100)
            {
                Console.WriteLine("Seu número é maior que 100");
            }
            else
            {
                numero = numero * 2;
                Console.WriteLine($"O dobro de seu número é:{numero}");
            }
        }
    }
}
