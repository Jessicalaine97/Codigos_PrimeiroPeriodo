internal class Program
{
    static void LeVetor(int[] vetor)
    {
        Console.WriteLine("Digite os valores do vetor:");

        for (int i=0; i<vetor.Length; i++)
        {
            Console.Write("  {0}/{1}: ", i+1, vetor.Length);
            vetor[i]=Convert.ToInt32(Console.ReadLine());
        }
    }
     static void OrdenaCrescente(int[] vetor)
    {
        int i, j;
        int aux;

        for (i = 0; i < vetor.Length; i++)
        {
            for (j = vetor.Length - 1; j > i; j--)
            {
                if (vetor[j] < vetor[j - 1])
                {
                    aux = vetor[j];
                    vetor[j] = vetor[j - 1];
                    vetor[j - 1] = aux;
                }
            }
        }
    }
    private static void Main(string[] args)
    {
        int[] vetor=new int[5];
       
       LeVetor(vetor);

       OrdenaCrescente(vetor);

        Console.Write("Os valores em ordem crescente do vetor são:");

        for (int i=0; i<vetor.Length; i++)
        {
            Console.Write(" {0}", vetor[i]);
        }

        Console.ReadKey();
    }
}
