using System;

class Program {
    static void Main() {

        int[] num = new int[10];
        int i = num.Length - 1;

        Console.WriteLine(' ');
        Console.WriteLine("============================");

        while(i > 0) {
            num[i] = 0;
            Console.WriteLine(num[i]);
            i--;
        }
        
        Console.WriteLine("Fim do loop!");

        Console.WriteLine("============================");
        Console.WriteLine(' ');
    }
}