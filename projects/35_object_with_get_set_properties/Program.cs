using System;

namespace object_with_get_set_properties
{
    internal class Pessoa
    {
        private int id;
        private int idade;
        private string nome;
        private string celular;

        public int Id { get { return id; } set { id = value; } }
        public int Idade { get { return idade; } set { idade = value; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public string Celular { get { return celular; } set { celular = value; } }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p;
            p = new Pessoa();

            p.Id = 1;
            p.Nome = "Alan Ryan da Silva Domingues";
            p.Idade = 20;
            p.Celular = "15 99620-9364";

            string idMensagem = "ID: ";
            string nomeMensagem = "Estudante: ";
            string idadeMensagem = "Idade: ";
            string celularMensagem = "Telefone: ";

            Console.Clear();
            Console.WriteLine("==========================================================");
            Console.WriteLine(idMensagem + p.Id + "  \n" + nomeMensagem + p.Nome + " \n" + idadeMensagem + p.Idade + " \n" + celularMensagem + p.Celular);
            Console.WriteLine("==========================================================\n");
        }
    }
}