using System.Text;
internal class Program
{
    static bool primeiraEVogal(string s1)
    {
        if (s1[0] == 'a' | s1[0] == 'e' | s1[0] == 'i' | s1[0] == 'o' | s1[0] == 'u' | s1[0] == 'A' | s1[0] == 'E' | s1[0] == 'I' | s1[0] == 'O' | s1[0] == 'U')
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static void converteMaiuscula(string s1)
    {
        for (int i = 0; i < s1.Length; i++)
        {
            if (s1[i] >= 'a' && s1[i] <= 'z')
            {
                Console.Write("{0}", Convert.ToChar(s1[i] - 'a' + 'A'));
            }
            else
            {
                Console.Write("{0}", s1[i]);
            }
        }
    }
    
    static void converteMinuscula(string s1)
    {
        for (int i = 0; i < s1.Length; i++)
        {
            if (s1[i] >= 'A' && s1[i] <= 'Z')
            {
                Console.Write("{0}", Convert.ToChar(s1[i] - 'A' + 'a'));
            }
            else
            {
                Console.Write("{0}", s1[i]);
            }
        }
    }
    private static void Main(string[] args)
    {
        string s1;

        Console.Write("Digite a string desejada: ");
        s1 = Console.ReadLine();

        if (primeiraEVogal(s1) == true)
        {
            converteMaiuscula(s1);
        }
        else 
        {
            converteMinuscula(s1);
        }
    
        Console.ReadKey();
    }
}