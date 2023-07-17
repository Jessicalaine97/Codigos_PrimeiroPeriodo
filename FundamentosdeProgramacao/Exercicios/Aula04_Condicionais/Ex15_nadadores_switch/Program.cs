internal class Program
{
    private static void Main(string[] args)
    {
        int idade;

        Console.WriteLine("Digite a idade do nadador:");
        idade = Convert.ToInt32(Console.ReadLine());

        switch (idade)
        {
            case 5: case 6: case 7:
                Console.WriteLine("Infantil A.");
                break;
            case 8: case 9: case 10:
                Console.WriteLine("Infantil B.");
                break;
            case 11: case 12: case 13:
                Console.WriteLine("Juvenil A.");
                break;
            case 14: case 15: case 16: case 17:
                Console.WriteLine("Infantil B.");
                break;
            case 18: case <=30: 
                Console.WriteLine("Adulto.");
                break;
            case >30:
                Console.WriteLine("Sênior");
                break;
            default:
                Console.WriteLine("Resposta inválida!");
                break;
        }
          Console.ReadKey();
    }
}