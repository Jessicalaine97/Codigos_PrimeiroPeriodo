internal class Program
{
    static int LeVetor(int[] vetor)
    {
        int valor = 0, indice=0;

        Console.WriteLine("Digite os valores do vetor:");

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write("{0}/{1}: ", i + 1, vetor.Length);
            vetor[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Digite o valor procurado:");
        valor = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] == valor)
            {
                indice = i;
            }
        }

        if (indice == 0)
        {
            return -1;
        }
        else
        {
            return indice;
        }

    }
    private static void Main(string[] args)
    {
        int[] vetor = new int[5];

        int resultado;

        resultado=LeVetor(vetor);

        if(resultado == -1)
        {
            Console.WriteLine("O valor não foi escontrado!");
        }
        else
        {
            Console.WriteLine("O valor escontrado está no índice {0}!", resultado);
        }
        
        Console.ReadKey();
    }
}
