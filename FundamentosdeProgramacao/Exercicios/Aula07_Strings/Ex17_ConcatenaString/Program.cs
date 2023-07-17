using System;
internal class Program
{
    private static void Main(string[] args)
    {
        string s1 = "Fundamentos", s2 = "de", s3 = "Programação", s4;

        s4 = s1 + " " + s2 + " " + s3;

        Console.Write("{0}", s4);

        Console.ReadKey();
    }
}
