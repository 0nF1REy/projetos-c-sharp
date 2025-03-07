using System;

 class Program {
    static void Main() {

        int n1, n2, n3;

        double valorCompra = 5.50;
        double valorVenda;
        double lucro = 0.1;
        string produto = "Pastel";

        n1 = 10; n2 = 20; n3 = 30;

        valorVenda = valorCompra + (valorCompra * lucro);

        Console.Write("\n n1 = \t {0} \n n2 = \t\t {1} \n n3 = \t {2} \n\n", n1, n2, n3);
        Console.WriteLine("Produto........:{0,15}", produto);
        Console.WriteLine("Val.Compra.....:{0,15:c}", valorCompra);
        Console.WriteLine("Lucro..........:{0,15:p}", lucro);
        Console.WriteLine("Val.venda......:{0,15:c} \n", valorVenda);
    }
 }