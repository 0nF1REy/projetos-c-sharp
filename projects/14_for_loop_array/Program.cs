using System;

class Program {
    static void Main() {

        int[] num = new int[10];

        Console.WriteLine(' ');
        Console.WriteLine("============================");

        for(int i = 0; i < num.Length; i++) { 
            num[i] = i;
        }

        for(int i = 0; i < 10; i++) { 
            Console.WriteLine("Valor de num na posição {0}: {1}", i, num[i]);
        }

        Console.WriteLine("============================");
        Console.WriteLine(' ');
    }
}


