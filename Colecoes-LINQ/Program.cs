using System;

namespace estudos_Csharp.Colecoes_LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            string nome = GetNome<string>("beto");
            System.Console.WriteLine(nome);
        }
        public static T GetNome<T>(T nome)
        {
            return nome;
        }
    }
}