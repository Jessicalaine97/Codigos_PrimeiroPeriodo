internal class Program
{
    private static void Main(string[] args)
    {
        int[] vetor = new int[10];

        Console.WriteLine("Digite os elementos do vetor:");

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write("  {0}/{1}: ", i, vetor.Length);
            vetor[i]=Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("A impressão dos elementos do vetor com a ordem invertida é:");

         for (int i = vetor.Length-1; i <= 9; i--)
        {
            Console.WriteLine("  {0}", vetor[i]);
        }

        Console.ReadKey();
    }
}
