internal class Program
{
    private static void Main(string[] args)
    {
        char caractere;

        Console.WriteLine("Digite um caractere:");
        caractere = Convert.ToChar(Console.ReadLine());

        if (caractere == '<')
            Console.WriteLine("Sinal de menor!");
        else if (caractere == '>')
            Console.WriteLine("Sinal de maior!");
        else if (caractere == '=')
            Console.WriteLine("Sinal de igual!");
        else
            Console.WriteLine("Outro caractere!");

        Console.ReadKey();
    }
}