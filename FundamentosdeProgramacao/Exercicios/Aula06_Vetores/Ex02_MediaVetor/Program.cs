internal class Program
{
const int TAM_VETOR=5;

static double CalculaMedia(int[] vetor)
{
    double soma=0, media=0;

    for (int i=0; i<TAM_VETOR; i++)
    {
        soma += vetor[i];
    }

    media = soma / TAM_VETOR;
    return media;

}
    private static void Main(string[] args)
    {
    int[] vetor= new int[TAM_VETOR];

    //Se quisesse passar os valores do vetor:
    //int[] vetor= new int[TAM_VETOR] {1, 2, 3, 4, 5};
    
    int i;
    double media;

    Console.WriteLine("Digite os valores do vetor:");

    for (i=0; i<TAM_VETOR; i++)
    {
        Console.Write("  {0} de {1}: ", i, TAM_VETOR);
        vetor[i]=Convert.ToInt32(Console.ReadLine());
    }

    media = CalculaMedia(vetor);

    Console.WriteLine("\nA media obetida foi de: {0}.", media);
    Console.ReadKey();

    }
}
