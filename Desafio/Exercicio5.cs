//Escreva um programa que leia três notas de um aluno e calcule a média.
//Informe se o aluno está aprovado (média >= 7), em recuperação (5 <= média < 7) ou reprovado (média < 5).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
{
    internal class Exercicio5
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Insira as três notas do aluno para calcular a média");
            double nota1 = Convert.ToDouble(Console.ReadLine());
            double nota2 = Convert.ToDouble(Console.ReadLine());
            double nota3 = Convert.ToDouble(Console.ReadLine());
            double media = (nota1 + nota2 + nota3) / 3.0;
            if (media >= 7)
            {
                Console.WriteLine("Aluno aprovado");
            }
            else if (5<= media && media >7)
            {
                Console.WriteLine("Aluno em recuperação");
            }
            else
            {
                Console.WriteLine("Aluno reprovado");
            }
        }
    }
}
