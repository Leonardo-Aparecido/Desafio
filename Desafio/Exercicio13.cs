////Escreva um programa que leia o valor de uma compra e a categoria do cliente (1 para comum, 2 para associado e 3 para VIP). 
//Aplique os seguintes descontos: 

//Comum: Sem desconto

//Associado: 10 % de desconto

//VIP: 20 % de desconto

//Informe o valor final da compra. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
{
    internal class Exercicio13
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Insira o valor da compra do cliente");
            double compra = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira a categoria do cliente:");
            int categoria = Convert.ToInt32(Console.ReadLine());
            switch (categoria)
            {
                case 1:
                    Console.WriteLine("Não tem desconto. Valor da compra é:"+compra);
                     break;
                case 2:
                    Console.WriteLine("Associado. Valor da compra é:" + (compra - (compra * 0.1)));
                    break;
                case 3:
                    Console.WriteLine("VIP. Valor da compra é:" + (compra - (compra * 0.2)));
                    break;
            }
        }
    }
}
