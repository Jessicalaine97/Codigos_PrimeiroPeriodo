using System;
using System.Text;
internal class Program
{
    const int TAM = 7;
    private static void Main(string[] args)
    {
        JogodeFutebol[] jogos = new JogodeFutebol[TAM];
        double qddQuedas = 0, mediaQuedas = 0, cont = 0;

        for (int i = 0; i < jogos.Length; i++)
        {
            jogos[i] = new JogodeFutebol();

            Console.WriteLine("Jogo {0}/{1}: ", i + 1, jogos.Length);

            Console.Write("  Adversário: ");
            jogos[i].Adversario = Console.ReadLine();
            Console.Write("  Número de pontos: ");
            jogos[i].NumPontos = Convert.ToInt32(Console.ReadLine());
            Console.Write("  Número de quedas: ");
            jogos[i].NumQuedas = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < jogos.Length; i++)
        {
            qddQuedas += jogos[i].NumQuedas;
        }
        mediaQuedas = qddQuedas / TAM;

        for (int i = 0; i < jogos.Length; i++)
        {
            if (jogos[i].NumQuedas < mediaQuedas)
            {
                cont++;
            }
        }

        Console.WriteLine("\nMédia de quedas de Clerysmar: {0} por jogo", mediaQuedas);
        Console.WriteLine("Jogos em que o número de quedas ficou abaixo da média: {0}", cont);

        Console.ReadKey();
    }
}