using CsvHelper.Configuration.Attributes;

namespace estudos_Csharp.arquivos_stream.Model
{
    public class Usuario
    {
        //csv sem cabeçario, usar [Index(0)]
        [Name("nome")]
        public string? Nome { get; set; }

        //csv sem cabeçario, usar [Index(1)]
        [Name("email")]
        public string? Email { get; set; }

        [Name("telefone")]
        public int Telefone { get; set; }

        [Name("nascimento")]
        [Format("dd/MM/yyyy")]
        public DateOnly Nascimento { get; set; }

        [Name("altura")]
        [CultureInfo("pt-BR")]
        public string? Altura { get; set; }
    }
}
/*
// mapping lógica fora da model
using System.Globalization;
using CsvHelper.Configuration;
public class LivroMap : ClassMap<Livro>
{
    public LivroMap()
    {
        Map(x=> x.Titulo)
            .Validate(field=> field.ToString()?.Length < 10)
            .Name("titulo");
        Map(x=> x.Preco)
            .Name("preço")
            .TypeConverterOption
            .CultureInfo(CultureInfo.GetCultureInfo("pt-BR"));
        Map(x=> x.Autor).Name("autor");
        Map(x=> x.Lancamento)
            .Name("lançamento")
            .TypeConverterOption
            .Format(new [] {"dd/MM/yyyy"});
    
    }

}
*/