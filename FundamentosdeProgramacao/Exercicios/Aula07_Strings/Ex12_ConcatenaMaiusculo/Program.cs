using System.Text;
internal class Program

{
    //Jeito de fazer antes:

    //   string ret = "";

    //   for (int i = 0; i < texto.Length; i++)
    //   {
    //       if (texto[i] >= 'a' && texto[i] <= 'z')
    //       {
    //           ret += Convert.ToChar(texto[i] - 32);
    //       }
    //       else
    //       {
    //           ret += texto[i] - 32;
    //       }
    //   }
    //    return ret;

    //Com o string Buider (usado quando tem que fazer sucessivas mudanças -> melhoria do processamento): 
    static string Maiusculo(string texto)
    {
        StringBuilder ret = new StringBuilder();

        for (int i = 0; i < texto.Length; i++)
        {
            if (texto[i] >= 'a' && texto[i] <= 'z')
            {
                ret.Append(Convert.ToChar(texto[i] - 32));
            }
            else
            {
                ret.Append(texto[i] - 32);
            }
        }
        return ret.ToString();
    }
    private static void Main(string[] args)
    {
        string texto = "jessica";

        Console.Write("\nImpressão da string convertida em maiúscula: {0}", Maiusculo(texto));

        Console.ReadKey();
    }
}
