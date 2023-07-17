internal class Program
{
    private static void Main(string[] args)
    {
        Pessoa pessoa1=new Pessoa();

        Console.Write("Digite o peso da Pessoa 1: ");
        pessoa1.peso=Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a altura da Pessoa 1: ");
        pessoa1.altura=Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nPessoa 1:");
        Console.WriteLine("  Peso: {0}kg \n  Altura: {1}m", pessoa1.peso, pessoa1.altura);

        Console.ReadKey();
    }
}