internal class Program
{
    const int TAMANHO_VETOR=10;
    private static void Main(string[] args)
    {
        int[] vetor1 = new int[TAMANHO_VETOR];
        int[] vetor2 = new int[TAMANHO_VETOR];
        int[] vetorSoma = new int[TAMANHO_VETOR];

        Console.WriteLine("Informe os elementos do Vetor 1: ");
        LeVetor(vetor1);

        Console.WriteLine("\nInforme os elementos do Vetor 2: ");
        LeVetor(vetor2);

        for (int i=0; i<TAMANHO_VETOR; i++)
        {
            vetorSoma[i] = vetor1[i] + vetor2[i];
        }

        Console.WriteLine("\nElementos do vetor soma: ");

        for (int i=0; i<TAMANHO_VETOR; i++)
        {
            Console.WriteLine("  {0} na posição {1}", vetorSoma[i], i);
        }

        Console.ReadKey();
    }
     static void LeVetor (int[] vetor)
    {
        int i;

        for (i=0; i<TAMANHO_VETOR; i++)
        {
            Console.Write("  {0} de {1}:", i+1, TAMANHO_VETOR);
            vetor[i]=Convert.ToInt32(Console.ReadLine());
        }
    }
}
