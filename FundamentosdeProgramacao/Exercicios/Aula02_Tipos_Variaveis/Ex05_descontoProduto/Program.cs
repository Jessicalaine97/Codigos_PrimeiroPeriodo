internal class Program
{
    private static void Main(string[] args)
    {
        double valorProduto, desconto;

        Console.WriteLine("Qual o preço do produto desejado (R$) ?");
        valorProduto=Convert.ToDouble(Console.ReadLine());

        desconto=valorProduto*0.75;

        Console.WriteLine("O valor do produto com desconto de 25% é de {0:N2} reais.", desconto);
        Console.ReadKey();
    }
}