internal class Program
{
    private static void Main(string[] args)
    {
        int opcao;

        Console.WriteLine("Formas de pagamento:\n1- À vista.\n2- Cheque para trinta dias.\n3- Em duas vezes.\n4- Em três vezes.\n5- Em quatro vezes.\n6- A partir de cinco vezes.");
        Console.WriteLine("Entre com sua opção:");
        opcao = Convert.ToInt32(Console.ReadLine());

        if (opcao == 1)
            Console.WriteLine("Desconto de 20%");
        else if (opcao == 2 || opcao == 3 || opcao == 4)
            Console.WriteLine("Mesmo preço a vista");
        else if (opcao == 5)
            Console.WriteLine("Juros de 3% ao mês");
        else if (opcao == 6)
            Console.WriteLine("Juros de 5% ao mês");
        else
            Console.WriteLine("Opção inválida!");

        Console.ReadKey();
    }
}