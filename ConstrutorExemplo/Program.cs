namespace ConstrutorExemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Eletronicos placa01 = new Eletronicos("Capacitor", "1mh", "X0-10", "100K", "2A", "AWG10", "12VA220VAC", "2A", "FIBRADEVIDRO", "6Ow", "Push-Pull", "Jack", " Led Infravermelho", "Esta placa esta pronta para delivery");


            Console.WriteLine(placa01.capacitor);
            Console.WriteLine(placa01.indutor);
            Console.WriteLine(placa01.flyback);
            Console.WriteLine(placa01.resistor);
            Console.WriteLine(placa01.relay);
            Console.WriteLine(placa01.fiodecobre);
            Console.WriteLine(placa01.transformador);
            Console.WriteLine(placa01.fusivel);
            Console.WriteLine(placa01.pcb);
            Console.WriteLine(placa01.ferrodesolda);
            Console.WriteLine(placa01.botao);
            Console.WriteLine(placa01.plugue);
            Console.WriteLine(placa01.led);
            Console.WriteLine(placa01.comentario);

        }
    }
}
