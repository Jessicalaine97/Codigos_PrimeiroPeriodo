internal class Program
{
const int TAM_VETOR=5;

static double PesquisaValorVetor(int[] vetor, int num)
{
    double resultado=0;

    for (int i=0; i<vetor.Length; i++)
    {
        if(vetor[i] == num)
        {
            resultado = i;
            break;
        }
        else
        {
            resultado = -1;
        }
    }
    return resultado;
}
    private static void Main(string[] args)
    {
    int[] vetor = new int[TAM_VETOR];
    double resultado;
    int num;

    Console.WriteLine("Digite os valores do vetor:");

    for (int i=0; i<vetor.Length; i++)
    {
        Console.Write("  {0} de {1}: ", i, vetor.Length);
        vetor[i]=Convert.ToInt32(Console.ReadLine());
    }

    Console.WriteLine("\nQual o valor a ser encontrado no vetor:");
    num=Convert.ToInt32(Console.ReadLine());

    resultado = PesquisaValorVetor(vetor, num);

    Console.WriteLine("\nO índice do valor {0} é {1}.", num, resultado);
    Console.ReadKey();

    }
}
