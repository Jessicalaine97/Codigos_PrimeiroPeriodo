internal class Program
{
    static void LeVetor(double[] vetor)
    {
        double valor = 0;
        int cont = 0;

        Console.WriteLine("Digite os valores do vetor:");

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write("{0}/{1}: ", i + 1, vetor.Length);
            vetor[i] = Convert.ToDouble(Console.ReadLine());
        }

        Console.WriteLine("Digite o valor procurado:");
        valor = Convert.ToDouble(Console.ReadLine());

        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] == valor)
            {
                cont++;
            }
        }

        if (cont >= 1)
        {
            Console.WriteLine("\nO valor {0} foi encontrado {1} vezes no vetor!", valor, cont);
        }
        else
        {
            Console.WriteLine("\nO valor {0} não foi encontrado no vetor!", valor);
        }

    }
    private static void Main(string[] args)
    {
        double[] vetor = new double[5];

        LeVetor(vetor);

        Console.ReadKey();
    }
}
