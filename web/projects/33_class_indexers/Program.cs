using System;

sealed class TemperaturaCasa { 
    private int[] temperaturas = new int[5] {18, 22, 25, 20, 24};

    public int this[int i] {
        get {
            return temperaturas[i];
        }
        set {
            if (value < 10) { 
                temperaturas[i] = 10;
            }
            else if (value > 35) { 
                temperaturas[i] = 35;
            } else {
                temperaturas[i] = value;
            }
        }
    }

    public TemperaturaCasa() {
    }
}

class Program {
    static void Main() {

        TemperaturaCasa casa = new TemperaturaCasa();

        casa[4] = 30; 

        Console.Clear();
        Console.WriteLine("=============================");
        Console.WriteLine("Temperatura do cômodo 4: {0}°C", casa[4]);
        Console.WriteLine("=============================");
    }
}
