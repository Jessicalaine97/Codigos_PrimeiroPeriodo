internal class Program
{
    private static void Main(string[] args)
    {
        double altura;
        char sexo;

        Console.WriteLine("Digite a altura (m):");
        altura = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o sexo (F ou M):");
        sexo = Convert.ToChar(Console.ReadLine());

        if (sexo == 'M' || sexo == 'm')
            Console.WriteLine("O peso ideal do sexo masculino é {0:N2}Kg.", (72.7 * altura) - 58);
        else if (sexo == 'F' || sexo == 'f')
            Console.WriteLine("O peso ideal do sexo feminino é {0:N2}Kg.", (62.1 * altura) - 44.7);
        else
            Console.WriteLine("Operação inválida.");

        Console.ReadKey();
    }
}