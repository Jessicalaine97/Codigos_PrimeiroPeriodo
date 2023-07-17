internal class Program
{
    const int TAM = 7;
    private static void Main(string[] args)
    {
        double somaQuedas = 0, mediaQuedas = 0;
        int cont = 0;

        Futebol[] jogos = new Futebol[TAM];

        for (int i = 0; i < jogos.Length; i++)
        {
            jogos[i] = new Futebol();

            Console.WriteLine("Digite com os dados dos jogos {0}/{1}: ", i + 1, TAM);

            Console.Write("  Adversário: ");
            jogos[i].Adversario = Console.ReadLine();

            Console.Write("  Número de pontos: ");
            jogos[i].NumPontos = Convert.ToInt32(Console.ReadLine());

            Console.Write("  Número de quedas: ");
            jogos[i].NumQuedas = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < jogos.Length; i++)
        {
            somaQuedas += jogos[i].NumQuedas;
        }

        mediaQuedas = somaQuedas / TAM;

        for (int i = 0; i < jogos.Length; i++)
        {
            if (jogos[i].NumQuedas < mediaQuedas)
            {
                cont++;
            }
        }

        Console.WriteLine("Média de quedas de Clerysmar: {0:N2}\nQuantidade de jogos em que o número de quedas ficou abaixo da média: {1}.", mediaQuedas, cont);

        Console.ReadKey();
    }
}