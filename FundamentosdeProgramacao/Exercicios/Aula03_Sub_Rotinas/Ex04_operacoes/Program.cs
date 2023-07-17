internal class Program
{
    private static void Main(string[] args)
    {
    
    }
    static void OperacoesInteiros (int num1, int num2)
    {
        double soma, diferenca, produto;
        double quociente, resto;

        soma = num1 + num2;
        diferenca = num1 - num2;
        produto = num1 * num2;
        quociente = num1 / num2;
        resto = num1 % num2;

        Console.WriteLine("O valor das operações com os inteiros {0} e {1} são: /nSoma: {3} /nDiferenca: {4} /nProduto: {5} /nQuociente: {6} /nResto: {7}",num1, num2, soma, diferenca, produto, quociente, resto);
    }
}