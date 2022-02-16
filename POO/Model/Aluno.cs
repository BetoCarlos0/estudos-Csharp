using static System.Console;

namespace estudos_Csharp.POO
{
    public class Aluno : Pessoa
    {
        public float Nota { get; set; }

        public Aluno(float nota, string nome, int idade) : base(nome, idade)
        {
            this.Nota = nota;
        }

        public override void Apresentar()
        {
            WriteLine($"Olá meu nome é {Nome} e minha nota é {Nota}");
        }
    }
}