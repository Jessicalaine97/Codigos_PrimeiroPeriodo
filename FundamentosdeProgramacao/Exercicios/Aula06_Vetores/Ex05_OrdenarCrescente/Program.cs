internal class Program
{
    static void ordenaCrescente(double[] vetor)
    {
        int i, j;
        double aux;

        for (i = 0; i < vetor.Length; i++)
        {
            for (j = vetor.Length - 1; j > i; j--)
            {
                if (vetor[j] < vetor[j - 1])
                {
                    aux = vetor[j];
                    vetor[j] = vetor[j - 1];
                    vetor[j - 1] = aux;
                }
            }
        }
    }
    private static void Main(string[] args)
    {
        double[] vetor = new double[] { 1, 550, 7, 9, 500 };

        ordenaCrescente(vetor);

        Console.WriteLine("Os elementos do vetor em ordem crescente são:");

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write("  {0}", vetor[i]);
        }

        Console.ReadKey();
    }
}
