internal class Program
{
    private static void Main(string[] args)
    {
        string nome = "Jessica";
        char inicial = nome[0];

        Console.Write("Inicial: {0}", inicial);

        Console.Write("\nString: {0} ", nome);

        Console.WriteLine("\nSoletrando: ");
        for (int i = 0; i < nome.Length; i++)
        {
            Console.Write("  {0} ", nome[i]);
        }
        Console.ReadKey();
    }
}
