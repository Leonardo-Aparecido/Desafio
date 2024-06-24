namespace Construtor00
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Construtor meuCarroFavorito = new Construtor("Opala","XyZ","Amarelo");
            Console.WriteLine("O nome do meu carro é:"+meuCarroFavorito.name);
            Console.WriteLine("O modelo do meu carro é:"+meuCarroFavorito.modelo);
            Console.WriteLine("A cor do meu carro é:" +meuCarroFavorito.cor);
        }
    }
}
