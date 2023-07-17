internal class Program
{
    private static void Main(string[] args)
    {
        int[] vetor = new int[10];

        for (int i=0; i<10; i++)
        {
            vetor[i] = 0;
        }

        Console.WriteLine("Elemento | Valor");
        for(int i=0; i<10; i++)
        {
            Console.WriteLine("{0,4} {1,8}", i, vetor[i]);
        }

        Console.ReadKey();
    }
}
