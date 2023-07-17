internal class Program
{
    private static void Main(string[] args)
    {
        contatoTelefone contato1 = new contatoTelefone();

        Console.WriteLine("Digite os dados do Contato 1:");
        Console.Write("  Nome: ");
        contato1.nome = Console.ReadLine();
        Console.WriteLine("  Endereço: ");
        Console.Write("    Logradouro: ");
        contato1.logradouro = Console.ReadLine();
        Console.Write("    Número: ");
        contato1.numero = Convert.ToInt32(Console.ReadLine());
        Console.Write("    Complemento: ");
        contato1.complemento = Console.ReadLine();
        Console.Write("    Bairro: ");
        contato1.bairro = Console.ReadLine();
        Console.Write("    Cidade: ");
        contato1.cidade = Console.ReadLine();
        Console.Write("    UF: ");
        contato1.uf = Console.ReadLine();
        Console.Write("  Telefone: ");
        contato1.telefone = Convert.ToInt32(Console.ReadLine());
        Console.Write("  E-mail: ");
        contato1.email = Console.ReadLine();

        Console.WriteLine("\nImpressão dos dados de contato:");
        Console.WriteLine("Nome: {0}", contato1.nome);
        Console.WriteLine("Endereço: \n  Logradouro: {0}\n  Número: {1}\n  Complemento: {2}\n  Bairro: {3}\n  Cidade: {4}\n  UF: {5}", contato1.logradouro, contato1.numero, contato1.complemento, contato1.bairro, contato1.cidade, contato1.uf);
        Console.WriteLine("Telefone: {0}\nE-mail: {1}", contato1.telefone, contato1.email);

        Console.ReadKey();
    }
}