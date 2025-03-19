using System;

class Calc {
    // ==============================
    //  Fatorial: 5! = 5*4*3*2*1 = 120
    // ==============================
    public int fat(int n) {
        int res;
        if (n <= 1) {
            res = 1;
        } else {
            res = n * fat(n - 1);
        }
        return res;
    }
}

class Program {
    static void Main() {
        Calc calc = new Calc();
        
        var res = calc.fat(5);
        
        Console.Clear();
        Console.WriteLine("===");
        Console.WriteLine(res); 
        Console.WriteLine("===");
    }
}
