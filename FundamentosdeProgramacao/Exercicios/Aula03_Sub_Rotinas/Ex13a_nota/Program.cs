internal class Program
{
    private static void Main(string[] args)
    {
       
    }
    static void CalculaNota (double nota1, double nota2)
    {
        double nota3;
        nota3=(20-nota1-nota2)/2;
        Console.WriteLine("O aluno precisa tirar uma nota maior ou igual a {0} pontos para obter a média.", nota3);
    }
}