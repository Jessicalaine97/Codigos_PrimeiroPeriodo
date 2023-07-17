internal class Program
{
    //exercicio pede 6 mas vou fazer só pra 3 hihi
    private static void Main(string[] args)
    {
        Pessoas entrevistado1 = new Pessoas();
        Pessoas entrevistado2 = new Pessoas();
        Pessoas entrevistado3 = new Pessoas();
        double mediaSalario = 0, mediaIdade = 0;

        Console.WriteLine("Entre com os dados do entrevistado 1:");
        Console.Write("  Nome: ");
        entrevistado1.nome = Console.ReadLine();
        Console.Write("    Idade: ");
        entrevistado1.idade = Convert.ToInt32(Console.ReadLine());
        Console.Write("    Salário: ");
        entrevistado1.salario = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Entre com os dados do entrevistado 2:");
        Console.Write("  Nome: ");
        entrevistado2.nome = Console.ReadLine();
        Console.Write("    Idade: ");
        entrevistado2.idade = Convert.ToInt32(Console.ReadLine());
        Console.Write("    Salário: ");
        entrevistado2.salario = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Entre com os dados do entrevistado 3:");
        Console.Write("  Nome: ");
        entrevistado3.nome = Console.ReadLine();
        Console.Write("    Idade: ");
        entrevistado3.idade = Convert.ToInt32(Console.ReadLine());
        Console.Write("    Salário: ");
        entrevistado3.salario = Convert.ToDouble(Console.ReadLine());

        mediaSalario = (entrevistado1.salario + entrevistado2.salario + entrevistado3.salario) / 3;
        mediaIdade = (entrevistado1.idade + entrevistado2.idade + entrevistado3.idade) / 3;

        Console.WriteLine("Média dos 3 entrevistados: \n  Saário: R${0:N2} \n  Idade: {1:N2} anos", mediaSalario, mediaIdade);

        Console.ReadKey();
    }
}