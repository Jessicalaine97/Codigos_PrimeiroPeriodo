internal class Program
{
    private static void Main(string[] args)
    {
        Aluno aluno1 = new Aluno();

        Console.Write("Digite o nome do Aluno 1: ");
        aluno1.nome=Console.ReadLine();

        for (int i=0; i< aluno1.notas.Length; i++)
        {
            Console.Write("Nota {0}/4: ", i+1);
            aluno1.notas[i]=Convert.ToDouble(Console.ReadLine());
        }

        Console.WriteLine("Dados do Aluno 1:");
        Console.WriteLine("  Nome: {0}", aluno1.nome);
        for (int i=0; i< aluno1.notas.Length; i++)
        {
            Console.WriteLine("  Nota {0}/4: {1}", i+1, aluno1.notas[i]);
        }

        Console.ReadKey();
    }
}