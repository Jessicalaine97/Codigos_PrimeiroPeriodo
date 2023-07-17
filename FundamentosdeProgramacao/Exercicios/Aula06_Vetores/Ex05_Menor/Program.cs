internal class Program
{
    private static void Main(string[] args)
    {
        int[] vetor = new int[5];
        int menor = 0, indice = 0;

        Console.WriteLine("Digite os valores do vetor:");

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write("  {0}/{1}: ", i + 1, vetor.Length);
            vetor[i] = Convert.ToInt32(Console.ReadLine());
        }

        menor = vetor[0];

        for (int i = 1; i < vetor.Length; i++)
        {
            if (vetor[i] < menor)
            {
                menor = vetor[i];
                indice = i;
            }
        }

        Console.WriteLine("\nO menor valor encontrado é {0} e está na posição {1}.", menor, indice);
        Console.ReadKey();

    }
}
