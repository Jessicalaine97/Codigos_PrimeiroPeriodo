internal class Program
{
static void Imprimir(int[] vetor)
{
    for (int i=0; i<vetor.Length; i++)
    {
        Console.WriteLine("  {0} na posição {1}", vetor[i], i);
    }
}
static void Inverter(int[] vetor)
{
int i=0, j=vetor.Length-1, aux;

    while (i < j)
    {
        aux = vetor[i];
        vetor[i] = vetor[j];
        vetor[j] = aux;
        i++;
        j--;
    }
}
    private static void Main(string[] args)
    {
        int[] vetor = new int[] {1, 2, 3, 4, 5};

        Console.WriteLine("Os valores do vetor são:");
        Imprimir(vetor);

        Inverter(vetor);
        
        Console.WriteLine("\nOs novos valores do vetor invertido são:");
        Imprimir(vetor);

        Console.ReadKey();
    }
}
