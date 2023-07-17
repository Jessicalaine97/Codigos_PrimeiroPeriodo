internal class Program
{
    const int TAM=2;
    static void LePassagem(Passagem[] vet_passagem)
    {
      for (int i = 0; i < vet_passagem.Length; i++)
        {
            vet_passagem[i]=new Passagem();

            Console.WriteLine("Passagem {0}/{1}:", i+1, vet_passagem.Length);

            Console.Write("    Número: ");
            vet_passagem[i].numero = Convert.ToInt32(Console.ReadLine());
            Console.Write("    Poltrona: ");
            vet_passagem[i].poltrona=Convert.ToInt32(Console.ReadLine());
            Console.Write("    Origem: ");
            vet_passagem[i].origem=Console.ReadLine();
            Console.Write("    Destino: ");
            vet_passagem[i].destino=Console.ReadLine();
        }  
    }

    private static void Main(string[] args)
    {
        Passagem[] vet_passagem = new Passagem[TAM];

        LePassagem(vet_passagem);

        Console.WriteLine("\nImpressão dos dados informados:");

        for (int i = 0; i < vet_passagem.Length; i++)
        {
            Console.WriteLine("Passagem {0}/{1}:", i + 1, vet_passagem.Length);

            Console.WriteLine("  Número: {0}", vet_passagem[i].numero);
            Console.WriteLine("  Poltrona: {0}", vet_passagem[i].poltrona);
            Console.WriteLine("  Origem: {0}", vet_passagem[i].origem);
            Console.WriteLine("  Destino: {0}", vet_passagem[i].destino);
        }

        Console.ReadKey();
    }
}