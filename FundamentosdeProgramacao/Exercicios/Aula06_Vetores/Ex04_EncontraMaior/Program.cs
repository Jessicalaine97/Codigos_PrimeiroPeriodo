internal class Program
{
    static int retornaIndiceMaior(double[] vetor, int TAM)
    {
        int i, indice = 0;
        double maior = 0;

        maior = vetor[0];

        for (i = 1; i < TAM; i++)
        {
            if (vetor[i] > maior)
            {
                maior = vetor[i];
                indice = i;
            }
        }
        return indice;
    }
    private static void Main(string[] args)
    {
        int TAM = 0, i, indiceMaior = 0;
        double[] vetor = new double[TAM];

        Console.WriteLine("Digite o tamanho do vetor:");
        TAM = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite os elementos do vetor:");

        for (i = 0; i < TAM; i++)
        {
            Console.Write("  {0} de {1}: ", i, TAM);
            vetor[i] = Convert.ToDouble(Console.ReadLine());
        }

        indiceMaior = retornaIndiceMaior(vetor, TAM);

        Console.WriteLine("O indice do maior valor é {0}.", indiceMaior);
        Console.ReadKey();
    }
}
