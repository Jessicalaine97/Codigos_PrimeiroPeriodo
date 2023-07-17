internal class Program
{
    private static void Main(string[] args)
    {
        double valorProduto, percentAcrescimo, valorFinal;

        Console.WriteLine("Digite o valor do produto (R$):");
        valorProduto=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o valor do percentual de acréscimo (%):");
        percentAcrescimo=Convert.ToDouble(Console.ReadLine());

        valorFinal=CalculoPercentAcrescimo (valorProduto, percentAcrescimo);

        Console.WriteLine("O valor do produto R${0:N2} com {1:N0}% de acréscimo é de: R$ {2:N2}", valorProduto, percentAcrescimo, valorFinal);
        Console.ReadKey();
    }
    //função não precisa do main
    static double CalculoPercentAcrescimo (double precoProduto, double percentAcrescimo)
    {
        double precoFinal;
        precoFinal=precoProduto*(1+percentAcrescimo/100);
        return precoFinal;
    }
}