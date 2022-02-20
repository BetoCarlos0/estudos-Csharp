using System;

namespace estudos_Csharp.Colecoes_LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var dados = new List<Pessoa>
            {
                new Pessoa(20, "Paulo", new DateTime(1987, 3, 7), new DateTime(2019, 12, 20)),
                new Pessoa(60, "Carlos", new DateTime(1997, 2, 28), new DateTime(2019, 12, 10)),
                new Pessoa(1, "Pedro", new DateTime(2001, 6, 2), new DateTime(2021, 6, 20)),
                new Pessoa(1008, "Lucas", new DateTime(2002, 10, 23), new DateTime(2017, 8, 9)),
                new Pessoa(65, "Ana", new DateTime(1947, 11, 17), new DateTime(2016, 3, 5)),
            };

            System.Console.WriteLine("Pessoas nascidas até 1999 por ordem alfabética");
            var pessoas = dados.Where(x => x.Nascimento.Year >= 1999)
                                .OrderBy(x => x.Nome).ToList();
            
            pessoas.ForEach(p => Console.WriteLine(p.ToString()));

            System.Console.WriteLine("3 ultimas pessoas cadastradas");

            var dataCadastro = dados.OrderByDescending(x => x.Timestamp.Date)
                                    .Take(3).ToList();

            dataCadastro.ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
    public class Pessoa
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public DateTime Timestamp { get; set; }

        public Pessoa(int codigo, string nome, DateTime nascimento, DateTime timestamp)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Nascimento = nascimento;
            this.Timestamp = timestamp;
        }

        public override string ToString()
        {
            return $"Código: {Codigo}, Nome: {Nome}, Nascimento: {Nascimento.ToShortDateString()}, Data Cadastro: {Timestamp.ToShortDateString()}";
        }
        
    }
}