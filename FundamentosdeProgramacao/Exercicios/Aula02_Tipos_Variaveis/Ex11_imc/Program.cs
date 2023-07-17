internal class Program
{
    private static void Main(string[] args)
    {
        float massa, altura, imc;

        Console.WriteLine("Qual o valor do seu peso (Kg)?");
        massa=Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Qual a medida da sua altura (m)?");
        altura=Convert.ToSingle(Console.ReadLine());

        imc=massa/(altura*altura);
        Console.WriteLine("O seu valor de IMC é igual a {0}.", imc);
        Console.ReadKey();
    }
}