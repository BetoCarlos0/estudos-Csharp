using static System.Console;

namespace estudos_Csharp.POO
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string? Documento { get; set; }

        public Pessoa(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }
        
        public virtual void Apresentar()
        {
            WriteLine($"Olá meu nome é {Nome} e tenho {Idade} anos");
        }
    }
}