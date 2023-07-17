internal class Program
{
    private static void Main(string[] args)
    {
        double nota1, nota2, notaFinal;
        Console.WriteLine("Digite a primeira nota obtida:");
        nota1=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite a segunda nota obtida:");
        nota2=Convert.ToDouble(Console.ReadLine());

        notaFinal=CalculaNota (nota1, nota2);

        Console.WriteLine("A nota mínima que o aluno precisa tirar na P3 para que seja aprovado é de {0} ponto(s).", notaFinal);
        Console.ReadKey();
    }
    static double CalculaNota (double nota1, double nota2)
    {
        double nota3;
        nota3=(20-nota1-nota2)/2;
        return nota3;
    }
}