using System.Text;
internal class Program
{
    private static void Main(string[] args)
    {
        string s1, s2, s3;

        Console.Write("Digite a 1° string: ");
        s1 = Console.ReadLine();

        Console.Write("Digite a 2° string: ");
        s2 = Console.ReadLine();

        s3 = s1 + " " + s2 + " ";

        Console.Write("\nConcatenação entre strings:");

        Console.Write("  {0}", s3);

        Console.ReadKey();
    }
}
