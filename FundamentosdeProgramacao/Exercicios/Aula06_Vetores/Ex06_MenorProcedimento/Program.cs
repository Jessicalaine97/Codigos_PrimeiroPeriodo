internal class Program
{
    static void AchaMenor (int[] vetor)
    {
        int menor, indice=0;

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
    }
    private static void Main(string[] args)
    {
        int[] vetor = new int[5];

        Console.WriteLine("Digite os valores do vetor:");

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write("  {0}/{1}: ", i + 1, vetor.Length);
            vetor[i] = Convert.ToInt32(Console.ReadLine());
        }

        AchaMenor(vetor);
        
        Console.ReadKey();

    }
}
