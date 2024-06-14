using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

internal class Temporizador
{
    public static void Main(string[] args)
    {
        int segundos = 00;
        int minutos = 00;

        Console.WriteLine("-------------- Cronometro SENAC --------------");

        while (minutos < 60)
        {
            while (segundos < 60)
            {
                Console.WriteLine($"Tempo: {minutos}:{segundos}");
                segundos++;
            }
            segundos = 0;
            minutos++;
        }


    }

}