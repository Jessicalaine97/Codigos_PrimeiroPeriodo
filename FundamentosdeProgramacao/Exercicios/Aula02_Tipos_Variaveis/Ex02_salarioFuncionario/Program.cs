internal class Program
{
    private static void Main(string[] args)
    {
        float salarioMinimo, salarioFuncionario, divisao;
        
        Console.WriteLine("Qual o valor do salário mínimo atualmente (R$)?");
        salarioMinimo = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Qual o valor do seu salário atualmente (R$)?");
        salarioFuncionario = Convert.ToSingle(Console.ReadLine());

        divisao=salarioFuncionario/salarioMinimo;

        Console.WriteLine("Você recebe o equivalente a {0} salário(s) mínimos(s) atualmente.", divisao);
        Console.ReadKey();
    }
}