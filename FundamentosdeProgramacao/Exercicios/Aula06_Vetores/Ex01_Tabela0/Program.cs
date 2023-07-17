internal class Program
{
    const int TAMANHO = 10;
    private static void Main(string[] args)
    {
        int[] vetor = new int[TAMANHO];

        for (int i=0; i<TAMANHO; i++)
        {
            vetor[i] = i*2 + 2;
        }

        Console.WriteLine("Elemento | Valor");

        for (int i=0; i<TAMANHO; i++)
        {
            Console.WriteLine("{0,4} {1,9}", i, vetor[i]);
        }
        
        Console.ReadKey();
    }
}
