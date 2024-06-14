//Escreva um programa que leia dois números e uma operação (adição, subtração, multiplicação ou divisão) e realize a operação correspondente.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
{
    internal class Exercicio10
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Insira dois números");
            double numero1 = Convert.ToDouble(Console.ReadLine());
            double numero2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira sua operação (% , x , -, +)");
            string operador = Console.ReadLine();
            switch (operador)
            {
                case "%" :
                    double auxiliar = numero1 / numero2;
                    Console.WriteLine("seu numero é:"+auxiliar);
                    break;
                case "x":
                    auxiliar = numero1 * numero2;
                    Console.WriteLine();
                    break;
                case "-":
                    auxiliar = numero1 - numero2;
                    Console.WriteLine();
                    break;
                case "+":
                    auxiliar = numero1 + numero2;
                    Console.WriteLine();
                    break;
            }
        }
    }
}
