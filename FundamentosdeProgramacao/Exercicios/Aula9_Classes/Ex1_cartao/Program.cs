internal class Program
{
    private static void Main(string[] args)
    {
        CartaoCredito cartao1= new CartaoCredito();
        CartaoCredito cartao2= new CartaoCredito();

        cartao1.cpf=12345678969;
        cartao1.nome="Maria da Silva";
        cartao1.codSeguranca=254;

        cartao2.cpf=78954658745;
        cartao2.nome="João da Silva";
        cartao2.codSeguranca=983;

        Console.WriteLine("Cartão 1:");
        Console.WriteLine("  CPF: {0}\n  Nome: {1}\n  Código de Segurança: {2}", cartao1.cpf, cartao1.nome, cartao1.codSeguranca);

        Console.WriteLine("\nCartão 2:");
        Console.WriteLine("  CPF: {0}\n  Nome: {1}\n  Código de Segurança: {2}", cartao2.cpf, cartao2.nome, cartao2.codSeguranca);
    }
}