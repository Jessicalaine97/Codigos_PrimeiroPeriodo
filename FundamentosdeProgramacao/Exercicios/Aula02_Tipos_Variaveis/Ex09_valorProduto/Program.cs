internal class Program
{
    private static void Main(string[] args)
    {
        double valorProduto=0, valorDesconto=0;

        Console.WriteLine("Qual o valor do produto (R$)?");
        valorProduto=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Qual o valor do desconto (R$)?");
        valorDesconto=Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("O valor do produto após a aplicação do desconto é de {0} reais.", valorProduto-valorDesconto);
        Console.ReadKey();
    }
}