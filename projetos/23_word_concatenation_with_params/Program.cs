using System;

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine(Concatenar());  
        Console.WriteLine(Concatenar("C#", "é", "uma", "linguagem", "bacana"));
        Console.WriteLine(Concatenar("...", "...", "...", "...", "...", "..."));
        Console.WriteLine(Concatenar("C#", "é", "uma", "linguagem", "super", "bacana"));
        Console.WriteLine(Concatenar());  
    }

    static string Concatenar(params string[] palavras)
    {
        return string.Join(" ", palavras);
    }
}
