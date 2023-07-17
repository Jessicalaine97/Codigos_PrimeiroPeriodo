internal class Program
{
    static void LeVetor(double[] vetor)
    {
        Console.WriteLine("Digite os valores do vetor:");

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write("{0}/{1}: ", i + 1, vetor.Length);
            vetor[i] = Convert.ToDouble(Console.ReadLine());
        }
    }
    static void EncontraMenor(double[] vetor)
    {
        double menor = 0;
        int indice = 0;

        menor = vetor[0];

        for (int i = 1; i < vetor.Length; i++)
        {
            if (vetor[i] < menor)
            {
                menor = vetor[i];
                indice = i;
            }
        }

        Console.WriteLine("O menor valor do vetor é {0} e está na posição {1}!", menor, indice);
    }
    private static void Main(string[] args)
    {
        double[] vetor = new double[5];

        LeVetor(vetor);

        EncontraMenor(vetor);

        Console.ReadKey();
    }
}
