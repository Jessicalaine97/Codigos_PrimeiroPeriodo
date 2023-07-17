internal class Program
{
    private static void Main(string[] args)
    {
        float num1, num2, soma, subtracao, multiplicacao, divisao;

        Console.WriteLine("Informe o primeiro valor desejado:");
        num1=Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Agora informe o segundo valor:");
        num2=Convert.ToSingle(Console.ReadLine());

        soma=num1+num2;
        subtracao=num1-num2;
        multiplicacao=num1*num2;
        divisao=num1/num2;

        Console.WriteLine("As quatro operações básicas para os números {0} e {1} resultaram nos seguintes valores: \n Soma: {2} \n Subtração: {3} \n Multiplicação: {4} \n Divisão: {5}", num1, num2, soma, subtracao, multiplicacao, divisao);
        Console.ReadKey();
    }
}