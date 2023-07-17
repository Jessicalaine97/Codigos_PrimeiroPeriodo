internal class Program
{
    private static void Main(string[] args)
    {
        double num1, num2, valorFuncao;

        Console.WriteLine("Digite o primeiro valor real:");
        num1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor real:");
        num2=Convert.ToInt32(Console.ReadLine());

        valorFuncao=calculaFuncao (num1, num2);

        Console.WriteLine("O valor da função para os números reais {0} e {1} digitados é: {2:N2}", num1, num2, valorFuncao);
        Console.ReadKey();
    }
    static double calculaFuncao (double num1, double num2)
    {
        double calculo;
        calculo=Math.Sqrt(Math.Pow(num1,2) + Math.Pow(num2,2));
        return calculo;
    }
}