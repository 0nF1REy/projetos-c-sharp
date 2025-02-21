using System;

class Program {

    enum DiasSemana{Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado};

    static void Main() {

        DiasSemana ds = DiasSemana.Domingo;
        DiasSemana ds2 = (DiasSemana)3;
        DiasSemana ds3 = (DiasSemana)0;

        int ds4 = (int) DiasSemana.Sexta;

        Console.WriteLine(ds);
        Console.WriteLine(ds2);
        Console.WriteLine(ds3);
        Console.WriteLine(ds4);
        
    }
}