using System;
using System.Threading;

namespace Calc1 {
    class Area {
    public static float Quad(float bas, float alt) {
        if(bas == 0 || alt == 0) {
            throw new Exception("Base ou altura não podem ser igual a 0");
        }
        return bas * alt;
    }
    }
}

namespace Calc2 {
    class Area {
    public static float Triangulo(float bas, float alt) {
        if (bas == 0 || alt == 0) {
            throw new Exception("Base ou altura não podem ser iguais a 0 para o triângulo.");
        }
        return (bas * alt) / 2;
    }
    }
}

class Program {
    static void Main() {

    float area = 0;

    Console.Clear();
    Console.WriteLine("=========");

    try {
       area = Calc1.Area.Quad(10F,5F);
       Console.WriteLine("Área do quad: {0}", area);

    } catch(Exception e) { // catch (DivideByZeroException e) 
        Console.WriteLine("Erro: {0}", e.Message);
        Console.WriteLine("-------");
        Console.WriteLine("Ex: {0}", e);
        Console.WriteLine("-------");
        Console.WriteLine("Ex: {0}", e.GetType());

    } finally {
        Console.WriteLine("= - = - = - = -");
        Console.WriteLine("Fim do processo!");
    }

    Console.WriteLine("=========");
    Console.WriteLine("Limpando a tela em 3... 2... 1... ✨");
    Thread.Sleep(3000);
    Console.Clear();
    }
}