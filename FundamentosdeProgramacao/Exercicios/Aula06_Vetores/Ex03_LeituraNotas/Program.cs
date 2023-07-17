internal class Program
{
    const int TAMANHO = 100;
    private static void Main(string[] args)
    {
        int[] vetor = new int[TAMANHO];
        int numAlunos;

        Console.WriteLine("Deseja fazer a leitura de quantos alunos? ");
        numAlunos=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nDigite as notas: ");

        for (int i=0; i<numAlunos; i++)
        {
            Console.Write("  {0} de {1}: ", i+1, numAlunos);
            vetor[i]=Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("\nAs notas digitadas foram: ");
        Console.WriteLine("Aluno | Notas");

        for (int i=0; i<numAlunos; i++)
        {
            Console.WriteLine("{0,3} {1,6}", i, vetor[i] );
        }

        Console.ReadKey();
    }
}
