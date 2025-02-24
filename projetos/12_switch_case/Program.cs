using System;

class Program {
    static void Main() {

        // Declaração de variáveis
        int tempo = 0;
        char escolha;
        string msg_final = "Fim do programa!";

        inicio:

        Console.Clear();

        Console.WriteLine("Belo Horizonte/MG a Vitória/ES");
        Console.WriteLine("Escolha o transporte:[a]Avião | [c]Carro | [o]Ônibus ");

        escolha = char.Parse(Console.ReadLine());

        switch(escolha) {
            case 'a':
            case 'A':
                tempo = 50;
                break;
            case 'c':
            case 'C':
                tempo = 480;
                break;
            case 'o':
            case 'O':
                tempo = 660;
                break;
            default:
                tempo = -1;
                break;
        }

        if (tempo < 0) {
            Console.WriteLine("Transporte indisponível!");
        } else {
            Console.WriteLine("Para o transporte escolhido o tempo é: {0} minutos",tempo);
        }

        Console.Write("Calcular outro transporte?[S/n]");
        escolha = char.Parse(Console.ReadLine());
        if (escolha == 's' || escolha == 'S') {
            goto inicio;
        } else {
            Console.Clear();
            Console.WriteLine(msg_final);
        }
    }
}