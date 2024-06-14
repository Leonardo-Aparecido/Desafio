// Escreva um programa que leia a idade de uma pessoa e informe se ela é 
//uma criança (0-12 anos), adolescente (13-17 anos), adulto (18-59 anos) ou idoso (60 anos ou mais)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
{
    internal class Exercicio7
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Insira a idade");
            int idade = Convert.ToInt32(Console.ReadLine());
            if (idade>=0 && idade<=12)
            {
                Console.WriteLine("Criaça");
            }
            else if (idade>=13 && idade<=17)
            {
                Console.WriteLine("adolescente");
            }
            else if (idade>=18 && idade<=59)
            {
                Console.WriteLine("Adulto");
            }
            else
            {
                Console.WriteLine("idoso");
            }
        }
    }
}
