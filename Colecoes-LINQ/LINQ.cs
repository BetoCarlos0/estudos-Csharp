int[] num = new int[] {100, 1, 4, 0, 8, 15, 19};

//var pares = num.Where(x => x % 2 == 0).OrderBy(x => x).ToList();

var pares = from nuns in num
            where nuns % 2 == 0
            orderby nuns 
            select nuns; 

System.Console.WriteLine(string.Join(", ", pares));

//============================================================

System.Console.WriteLine("Pessoas nascidas até 1999 por ordem alfabética");
var pessoas = dados.Where(x => x.Nascimento.Year >= 1999)
                    .OrderBy(x => x.Nome).ToList();

pessoas.ForEach(p => Console.WriteLine(p.ToString()));

System.Console.WriteLine("3 ultimas pessoas cadastradas");

var dataCadastro = dados.OrderBy(x => x.Timestamp.Date)
                        .TakeLast(3).ToList();

dataCadastro.ForEach(p => Console.WriteLine(p.ToString()));


var dados = new List<Pessoa>()
{
    new Pessoa{Codigo = 20, Nome = "Paulo", Nascimento = new DateTime(1987, 3, 7),Timestamp = new DateTime(2019, 12, 20)},
    new Pessoa{Codigo = 60,Nome = "Carlos",Nascimento = new DateTime(1997, 2, 28),Timestamp = new DateTime(2019, 12, 10)},
    new Pessoa{Codigo = 1,Nome = "Pedro",Nascimento = new DateTime(2001, 6, 2),Timestamp = new DateTime(2021, 6, 20)},
    new Pessoa{Codigo = 1008,Nome = "Lucas",Nascimento = new DateTime(2002, 10, 23),Timestamp = new DateTime(2017, 8, 9)},
    new Pessoa{Codigo = 65,Nome = "Ana",Nascimento = new DateTime(1947, 11, 17),Timestamp = new DateTime(2016, 3, 5)},
    new Pessoa{Codigo = 500,Nome = "Luciano",Nascimento = new DateTime(1947, 11, 17),Timestamp = new DateTime(2018, 5, 12)},
};

var endereco = new Endereco[]
{
    new Endereco{Id = 1, IsActive = false, Estado = "ceará", Cidade = "fortaleza", Rua = "rua do campo", Numero = 306, Cep = "60510461", IdPessoa = dados.Single(i => i.Nome == "Carlos").Codigo},
    new Endereco{Id = 2, IsActive = true, Estado = "ceará", Cidade = "icarai", Rua = "rua x", Numero = 56, Cep = "60530541", IdPessoa = dados.Single(i => i.Nome == "Carlos").Codigo},
    new Endereco{Id = 3, IsActive = true, Estado = "ceará", Cidade = "Eusébio", Rua = "rua do mundo", Numero = 1025, Cep = "60510456", IdPessoa = dados.Single(i => i.Nome == "Paulo").Codigo},
};

string consul = "Lu";
var result2 = from dado in dados
                where dado.Nome.ToLower().Substring(0, consul.Length) == consul.ToLower()
                select dado;

var result = from dado in dados
                orderby dado.Nome
                select new {dado.Codigo, dado.Nome};

var result = from enderecos in endereco
            group enderecos by enderecos.IsActive into enderecosgroup
            select enderecosgroup;

var result = from dado in dados
                join ende in endereco
                on dado.Codigo equals ende.IdPessoa
                select new { Pessoa = dado, Endereco = ende };

var result = dados.FirstOrDefault(x => x.Codigo == 20);
var result = dados.Where(x => x.Timestamp.Date >= new DateTime(2019, 5, 13)).OrderBy(x => x.Codigo);
var result = dados.Select(x => new {x.Nome, x.Nascimento}).OrderBy(x => x.Nome);
var result = dados.SelectMany(x => x.Enderecos);

var result = dados.Take(3);
var result2 = dados.Skip(3);
var result = dados.Sum(x => x.Codigo);
var result = dados.Count();
var result = dados.Count(x => x.Timestamp.Date >= new DateTime(2019,10,20));
System.Console.WriteLine(result);
foreach (var item in result)
{
    System.Console.WriteLine($"Codigo: {item.Codigo}, nome: {item.Nome}");
}

public class Pessoa
{
    public int Codigo { get; set; }
    public string? Nome { get; set; }
    public DateTime Nascimento { get; set; }
    public DateTime Timestamp { get; set; }
    public List<Endereco>? Enderecos { get; set; }
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
}

//=================================================================
