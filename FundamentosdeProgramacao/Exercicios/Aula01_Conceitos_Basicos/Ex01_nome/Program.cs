internal class Program
{
    private static void Main(string[] args)
    {
        string nome, sobrenome;

        Console.WriteLine("Qual o seu nome?");
        nome=Console.ReadLine();
        Console.WriteLine("Qual o seu sobrenome?");
        sobrenome=Console.ReadLine();

        Console.WriteLine("{0}, {1}", sobrenome, nome);
        Console.ReadKey();
    }
}