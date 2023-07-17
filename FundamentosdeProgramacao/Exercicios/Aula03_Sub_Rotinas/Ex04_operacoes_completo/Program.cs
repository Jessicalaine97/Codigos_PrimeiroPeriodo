internal class Program
{
    private static void Main(string[] args)
    {
       int num1, num2, soma, diferenca, produto, quociente, resto;
       
        Console.WriteLine("Digite o primeiro número inteiro desejado:");
        num1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo número inteiro desejado:");
        num2=Convert.ToInt32(Console.ReadLine());

        soma=SomaInteiros(num1, num2);
        diferenca=DiferencaInteiros(num1, num2);
        produto=ProdutoInteiros(num1, num2);
        quociente=DivisaoInteiros(num1, num2);
        resto=RestoInteiros(num1, num2);

        Console.WriteLine("O valor das operações com os inteiros {0} e {1} são: \nSoma: {2} \nDiferença: {3} \nProduto: {4} \nQuociente: {5} \nResto: {6}",num1, num2, soma, diferenca, produto, quociente, resto);
        Console.ReadKey();
    }
    static int SomaInteiros (int num1, int num2)
    {
        int soma;
        soma = num1 + num2;
        return soma;
    }
    static int DiferencaInteiros (int num1, int num2)
    {
        int diferenca;
        diferenca = num1 - num2;
        return diferenca;
    }
    static int ProdutoInteiros (int num1, int num2)
    {
        int produto;
        produto = num1 * num2;
        return produto;
    }
    static int DivisaoInteiros (int num1, int num2)
    {
        int divisao;
        divisao = num1 / num2;
        return divisao;
    }
    static int RestoInteiros (int num1, int num2)
    {
        int resto;
        resto = num1 % num2;
        return resto;
    }
}