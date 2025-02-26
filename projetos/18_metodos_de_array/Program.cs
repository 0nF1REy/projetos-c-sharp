using System;

class Program
{
    static void Main()
    {
        int[] vetor1 = new int[5], vetor2 = new int[5], vetor3 = new int[5];

        // Preenche vetor1 com números aleatórios de 0 a 49
        Random random = new Random();
        for (int i = 0; i < vetor1.Length; i++)
            vetor1[i] = random.Next(50); 

        // Exibe vetor1
        Console.WriteLine("Vetor1:");
        Array.ForEach(vetor1, Console.WriteLine);

        // Copia vetor1 para vetor2
        Array.Copy(vetor1, vetor2, vetor1.Length);
        Console.WriteLine("\nVetor2 após Copy:");
        Array.ForEach(vetor2, Console.WriteLine);

        // Copia vetor1 para vetor3
        vetor1.CopyTo(vetor3, 0);
        Console.WriteLine("\nVetor3 após CopyTo:");
        Array.ForEach(vetor3, Console.WriteLine);

        // Inverte vetor1
        Array.Reverse(vetor1);
        Console.WriteLine("\nVetor1 após Reverse:");
        Array.ForEach(vetor1, Console.WriteLine);

        // Ordena vetor1 
        Array.Sort(vetor1);
        Console.WriteLine("\nVetor1 Ordenado:");
        Array.ForEach(vetor1, Console.WriteLine);

        // Busca um número no vetor ordenado
        int numeroBuscado = vetor1[random.Next(vetor1.Length)]; // Pegando um número aleatório do vetor para buscar
        int indiceEncontrado = Array.BinarySearch(vetor1, numeroBuscado);

        if (indiceEncontrado >= 0)
            Console.WriteLine($"\nNúmero {numeroBuscado} encontrado no índice {indiceEncontrado}.");
        else
            Console.WriteLine($"\nNúmero {numeroBuscado} não encontrado. Posição sugerida: {~indiceEncontrado}");
    }
}
