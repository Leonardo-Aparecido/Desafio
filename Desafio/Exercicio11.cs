//Escreva um programa que leia um número e verifique se ele está no intervalo de 10 a 20
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
{
    internal class Exercicio11
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Insira um numero, vou verificar se ele está entre 10 e 20:");
            Double numero = Convert.ToDouble(Console.ReadLine());
            if(numero<10 && numero > 20)
            {
                Console.WriteLine("Seu número está fora do intervalo");
            }
            else
            {
                Console.WriteLine("Seu número está entre 10 e 20!");
            }
        }
    }
}
