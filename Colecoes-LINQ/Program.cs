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

            var endereco = new List<Endereco>()
            {
                new Endereco{Id = 1, IsActive = false, Estado = "ceará", Cidade = "fortaleza", Rua = "rua do campo", Numero = 306, Cep = "60510461", IdPessoa = dados.Single(i => i.Nome == "Carlos").Codigo},
                new Endereco{Id = 2, IsActive = true, Estado = "ceará", Cidade = "icarai", Rua = "rua x", Numero = 56, Cep = "60530541", IdPessoa = dados.Single(i => i.Nome == "Carlos").Codigo},
                new Endereco{Id = 3, IsActive = true, Estado = "ceará", Cidade = "Eusébio", Rua = "rua do mundo", Numero = 1025, Cep = "60510456", IdPessoa = dados.Single(i => i.Nome == "Paulo").Codigo},
            };

            var result = endereco.Where(x => x.IdPessoa == 60).ToList();

            result.ForEach(x => Console.WriteLine(x.ToString()));

            endereco.ForEach(x => Console.WriteLine(x.Pessoas?.Nome));

        }
    }
    public class Pessoa
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public DateTime Timestamp { get; set; }
        public IEnumerable<Endereco>? Enderecos { get; set; }

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
    public class Endereco
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public string? Estado { get; set; }
        public string? Cidade { get; set; }
        public string? Rua { get; set; }
        public int Numero { get; set; }
        public string? Cep { get; set; }
        public int IdPessoa { get; set; }
        public Pessoa? Pessoas { get; set; }
        
        public override string ToString()
        {
            return $"Id: {Id}, ativado: {IsActive}, Estado: {Estado}, Cidade: {Cidade}, Rua: {Rua}, Número {Numero}, Cep: {Cep}, Id Pessoa: {IdPessoa}";
        }
    }

}
/*
System.Console.WriteLine("Pessoas nascidas até 1999 por ordem alfabética");
var pessoas = dados.Where(x => x.Nascimento.Year >= 1999)
                    .OrderBy(x => x.Nome).ToList();

pessoas.ForEach(p => Console.WriteLine(p.ToString()));

System.Console.WriteLine("3 ultimas pessoas cadastradas");

var dataCadastro = dados.OrderBy(x => x.Timestamp.Date)
                        .TakeLast(3).ToList();

dataCadastro.ForEach(p => Console.WriteLine(p.ToString()));
*/