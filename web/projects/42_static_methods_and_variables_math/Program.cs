﻿using System;

class Mat {
    public static double pi = 3.14;
    public static int dobro(int n) {
        return n*2;
    }
}

class Program {
    static void Main() {

        double vpi = Mat.pi;
        int num = 10;

        Console.Clear();
        Console.WriteLine("=====");
        Console.WriteLine(vpi);
        Console.WriteLine(Mat.dobro(num));
        Console.WriteLine("=====");
    }
}