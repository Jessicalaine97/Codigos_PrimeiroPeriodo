internal class Program
{
    private static void Main(string[] args)
    {
        int idade;

        idade=LerIdade();

        Console.WriteLine("A idade é {0} ano(s).", idade);

        Console.ReadKey();
    }
    static int LerIdade()
    {
        int idade;

        Console.WriteLine("Digite a idade:");
        idade = Convert.ToInt32(Console.ReadLine());

        while (idade<0 || idade>130)
        {
        Console.WriteLine("Idade inválida!");  
        Console.WriteLine("Digite uma nova idade:");
        idade = Convert.ToInt32(Console.ReadLine());
        }
        return idade;
    }
}