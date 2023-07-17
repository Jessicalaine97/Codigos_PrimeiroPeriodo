internal class Program
{
    const int TAMANHO = 3;

    static void LeGabarito(int[] g)
    {
        Console.WriteLine("Digite o gabarito (0, 1 ou 2):");

        for (int i = 0; i < g.Length; i++)
        {
            Console.Write("  {0}/{1}: ", i + 1, g.Length);
            g[i] = Convert.ToInt32(Console.ReadLine());
        }
    }
    static void LeConfereAcertos(int[] g)
    {
        int cont = 0;
        int[] vetor = new int[TAMANHO];

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write("  {0}/{1}: ", i + 1, vetor.Length);
            vetor[i] = Convert.ToInt32(Console.ReadLine());

            if (vetor[i] == g[i])
            {
                cont++;
            }
        }

        Console.WriteLine("O jogador teve {0}/13 acertos!", cont);
    }
    private static void Main(string[] args)
    {
        int[] g = new int[TAMANHO];

        LeGabarito(g);

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("\nDigite os valores do cartão de apostas do Jogador {0}: ", i+1);
            LeConfereAcertos(g);
        }

        Console.ReadKey();
    }
}
