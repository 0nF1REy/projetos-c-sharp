﻿using System;

class Calc {
    public int soma(params int[] n) {
        int s = 0;
        for (int i = 0; i < n.Length; i++) {
            s += n[i];
        }
        return s;
    }

    public double soma(params double[] n) {
        double s = 0;
        for (int i = 0; i < n.Length; i++) {
            s += n[i]; 
        }
        return s;
    }
}

class Program {
    static void Main() {
        Calc calc = new Calc();
        
        var res = calc.soma(10.2, 5.4, 3.1, 7.2, 8.1);
        
        Console.Clear();
        Console.WriteLine("=="); 
        Console.WriteLine(res); 
        Console.WriteLine("=="); 
    }
}
