//Escreva um programa que leia um ano e verifique se ele é bissexto. Um ano é bissexto se for divisível por 4, mas não por 100, 
//exceto se for divisível por 400. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
{
    internal class Exercicio6
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Insira um ano. Vou dizer se ele é bissexto ou não");
            int ano = Convert.ToInt32(Console.ReadLine());
            if (ano%4 == 0 && ano % 100 != 0)
            {
                if(ano%400 == 0)
                {
                    Console.WriteLine("Não é bissexto");
                }
                else
                {
                    Console.WriteLine("Seu ano é bissexto!");
                }
            }
        }
    }
}
