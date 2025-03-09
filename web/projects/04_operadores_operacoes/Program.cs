using System;

class Program {
   static void Main() {

        int res = (10 + 5) * 2;

        // & = AND / E
        // | = OR / OU

        bool res2 = (5 > 3) | (10 < 5);

        bool res3 = (5 > 3) & (10 < 5);

        int num = 10;

        num++; // Isso é a mesma coisa que: |||| num +=1 |||| num = num + 1

        Console.WriteLine(res);
        Console.WriteLine(res2);
        Console.WriteLine(res3);
        Console.WriteLine(num);
   }
}