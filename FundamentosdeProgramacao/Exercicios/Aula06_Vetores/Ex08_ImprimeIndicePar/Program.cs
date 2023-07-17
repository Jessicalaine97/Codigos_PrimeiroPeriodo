internal class Program
{
    static void IndicePar(int[] vetor)
    {
        Console.WriteLine("Digite os elementos do vetor:");

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write("  {0}/{1}: ", i+1, vetor.Length);
            vetor[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("\nA impressão dos elementos de índice par do vetor é: ");

        for (int i = 0; i < vetor.Length; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write("{0}  ", vetor[i]);
            }
        }
    }
    private static void Main(string[] args)
    {
        int[] vetor = new int[10];

        IndicePar(vetor);

        Console.ReadKey();
    }
}
