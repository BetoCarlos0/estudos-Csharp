using CsvHelper.Configuration.Attributes;

namespace estudos_Csharp.arquivos_stream.Model
{
    public class Usuario
    {
        [Name("nome")]
        public string? Nome { get; set; }
        [Name("email")]
        public string? Email { get; set; }
        [Name("telefone")]
        public int Telefone { get; set; }
        [Name("nascimento")]
        [Format("dd/MM/yyyy")]
        public DateOnly Nascimento { get; set; }
    }
}