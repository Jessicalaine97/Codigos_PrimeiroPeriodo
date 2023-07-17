internal class Program
{
    const int TAM=5;
    private static void Main(string[] args)
    {
        double[] vetor = new double[TAM];
        double escalar=0;

        Console.Write("Digite o valor do escalar: ");
        escalar=Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nDigite os valores do vetor:");

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write("  {0}/{1}: ", i + 1, vetor.Length);
            vetor[i] = Convert.ToDouble(Console.ReadLine());
        }

        Console.WriteLine("\nO resultado da multiplicação do vetor pelo escalar é:");

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.WriteLine("  {0} na posição {1}", vetor[i]*escalar, i);  
        }

        Console.ReadKey();

    }
}
