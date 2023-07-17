internal class Program
{
    private static void Main(string[] args)
    {
        int codigo;

        Console.WriteLine("Digite o código de um produto para saber sua origem:");
        codigo = Convert.ToInt32(Console.ReadLine());

        if (codigo >= 1 && codigo <= 20)
            Console.WriteLine("Europa!");
        else if (codigo >= 21 && codigo <= 40)
            Console.WriteLine("Ásia!");
        else if (codigo >= 41 && codigo <= 60)
            Console.WriteLine("América!");
        else if (codigo >= 61 && codigo <= 80)
            Console.WriteLine("África!");
        else
            Console.WriteLine("Paraguai!");

        Console.ReadKey();
    }
}