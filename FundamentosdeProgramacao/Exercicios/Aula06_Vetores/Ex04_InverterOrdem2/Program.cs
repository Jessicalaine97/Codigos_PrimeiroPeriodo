internal class Program
{
    static void Imprimir(int[] vetor)
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.WriteLine("  {0} na posição {1}", vetor[i], i);
        }
    }
    static void Inverter(int[] vetor, int[] vetorInvertido)
    {
        int i =0, j=0; 

        for (i = 0, j=vetor.Length-1; i < vetor.Length; i++, j--)
        {
            vetorInvertido[j]=vetor[i];
        }
    }
    const int TAM=5;
    private static void Main(string[] args)
    {
        int[] vetor = new int[] {0, 1, 2, 3, 4};
        int[] vetorInvertido = new int[TAM];
        
        Console.WriteLine("Os valores do vetor são:");
        Imprimir(vetor);

        Inverter(vetor, vetorInvertido);

        Console.WriteLine("\nOs novos valores do vetor invertido são:");
        Imprimir(vetorInvertido);

        Console.ReadKey();
    }
}
