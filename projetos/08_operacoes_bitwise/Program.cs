using System;

class Program {
    static void Main() {

        int num = 10; 
        int num2 = 10; 
        int res = 0;

        num = num << 1;
        num2 = num2 >> 1;
        res = num + num2;

        Console.WriteLine(num);
        Console.WriteLine("+");
        Console.WriteLine(num2);
        Console.WriteLine("=");
        Console.WriteLine(res);

    }
}