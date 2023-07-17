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
    static int LeConfereAcertos(int[] vetor, int[] g)
    {
        int cont = 0, cont2 = 0;

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write("  {0}/{1}: ", i + 1, vetor.Length);
            vetor[i] = Convert.ToInt32(Console.ReadLine());

            if (vetor[i] == g[i])
            {
                cont++;
            }
        }

        if (cont >= 10 && cont <= 13)
        {
            cont2++;
        }

        Console.WriteLine("O jogador teve {0}/13 acertos!", cont);

        return cont2;
    }
    private static void Main(string[] args)
    {
        int[] g = new int[TAMANHO];
        int[] vetor1 = new int[TAMANHO];
        int[] vetor2 = new int[TAMANHO];
        int[] vetor3 = new int[TAMANHO];
        int[] vetor4 = new int[TAMANHO];
        int[] vetor5 = new int[TAMANHO];
        int ponto1 = 0, ponto2 = 0, ponto3 = 0, ponto4 = 0, ponto5 = 0;
        double percent10_13 = 0, percentmenor10 = 0;

        LeGabarito(g);

        Console.WriteLine("\nDigite o cartão de respostas do jogador 1:");
        ponto1 = LeConfereAcertos(vetor1, g);

        Console.WriteLine("\nDigite o cartão de respostas do jogador 2:");
        ponto2 = LeConfereAcertos(vetor2, g);

        Console.WriteLine("\nDigite o cartão de respostas do jogador 3:");
        ponto3 = LeConfereAcertos(vetor3, g);

        Console.WriteLine("\nDigite o cartão de respostas do jogador 4:");
        ponto4 = LeConfereAcertos(vetor4, g);

        Console.WriteLine("\nDigite o cartão de respostas do jogador 5:");
        ponto5 = LeConfereAcertos(vetor5, g);

        percent10_13 = ((ponto1 + ponto2 + ponto3 + ponto4 + ponto5) / TAMANHO) * 100;
        percentmenor10 = 1 - percent10_13;

        Console.WriteLine("\nA porcentagem de jogadores que acertou de 10 a 13 pontos foi de {0}%, e a que acertou menos de 10 pontos foi {1}%.", percent10_13, percentmenor10);

        Console.ReadKey();
    }
}
