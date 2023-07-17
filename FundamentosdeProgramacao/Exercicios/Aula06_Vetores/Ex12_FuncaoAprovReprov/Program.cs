internal class Program
{
    static double RetornaMedia(double[] vetor)
    {
        double soma = 0, media = 0;

        for (int i = 0; i < vetor.Length; i++)
        {
            soma += vetor[i];
        }

        media = soma / vetor.Length;

        return media;
    }
    static int QddAprov(double[] vetor, double media)
    {
        int cont = 0;

        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] >= 60)
            {
                cont++;
            }
        }

        return cont;
    }
    static int QddReprov(double[] vetor, double media)
    {
        int cont = 0;

        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] < 60)
            {
                cont++;
            }
        }

        return cont;
    }
    private static void Main(string[] args)
    {
        double[] vetor = new double[5] {100, 100, 60, 50, 10};
        double media = 0;
        int aprov, reprov;

        media = RetornaMedia(vetor);

        aprov = QddAprov(vetor, media);

        reprov = QddReprov(vetor, media);

        Console.WriteLine("A média da turma foi de {0:N2}/100 pontos.", media);
        Console.WriteLine("  Houveream {0} aprovados e {1} reprovados.", aprov, reprov);

        Console.ReadKey();
    }
}
