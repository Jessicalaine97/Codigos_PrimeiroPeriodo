internal class Program
{
    private static void Main(string[] args)
    {
        int idade;

        Console.WriteLine("Digite o valor inteiro da idade de uma pessoa:");
        idade = Convert.ToInt32(Console.ReadLine());

        if (idade<0)
             Console.WriteLine("Idade inválida!");
        else if (idade < 13)
            Console.WriteLine("Criança!");
            //poderia nao informar o primeiro parametro
        else if (idade >= 13 && idade < 20)
            Console.WriteLine("Adolescente!");
        else if (idade >= 20 && idade < 60)
            Console.WriteLine("Adulto!");
        else
            Console.WriteLine("Idoso!");

        Console.ReadKey();
    }
}