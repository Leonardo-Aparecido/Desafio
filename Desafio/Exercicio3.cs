//Escreva um programa que leia dois números inteiros e informe qual deles é o maior. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
{
    internal class Exercicio3
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("insira dois numeros inteiros para comparar e ver qual é o maior");
            int numero1= Convert.ToInt32(Console.ReadLine());
            int numero2= Convert.ToInt32(Console.ReadLine());
            if (numero1 != numero2)
            {
                if (numero1 > numero2)
                {
                    Console.WriteLine(numero1 + " é" + " maior que " + numero2);
                }
                else
                {
                    Console.WriteLine(numero1+"é"+"menor que"+numero2);
                }
            }
            else
            {
                Console.WriteLine("Os numeros são iguais!");
            }
        }
    }
}
