internal class Program
{
    private static void Main(string[] args)
    {
        double precoProduto, desconto, valorFinal;

        Console.WriteLine("Digite o preço do produto (R$):");
        precoProduto=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o valor do desconto do produto (%) (Somente números):");
        desconto=Convert.ToDouble(Console.ReadLine());

        valorFinal=CalculoDesconto(precoProduto, desconto);

        Console.WriteLine("O valor do produto custando R${0:N2} com {1:N2}% de desconto sairá por: R${2:N2}.", precoProduto, desconto, valorFinal);
        Console.ReadKey();
    }
    //função é só essa parte final, não precisa do main
    static double CalculoDesconto (double precoProduto, double desconto)
    {
        double precoFinal;
        precoFinal=precoProduto*(1-desconto/100);
        return precoFinal;
    }
}