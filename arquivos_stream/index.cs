using System;
using System.Text;
using System.Globalization;
using static System.Console;
using CsvHelper.Configuration;
using estudos_Csharp.arquivos_stream.Model;
using CsvHelper;

namespace estudosCsharp.arquivos_stream
{
    class Index{
        static void Main(string[] args)
        {
            LerCsvDeli();

            /*
            using var sr = new StreamReader(fi.FullName);
            var csvConfig = new CsvConfiguration(System.Globalization.CultureInfo.InvariantCulture);
            using var csvReader = new CsvReader(sr, csvConfig);

            var registros = csvReader.GetRecords<dynamic>();

            foreach (var item in registros)
            {
                WriteLine($"nome: {item.Nome}");
                WriteLine($"email: {item.Email}");
                WriteLine($"telefone: {item.Telefone}");
                WriteLine($"nascimento: {item.Nascimento}");
                WriteLine("--------------------");
            }
            */
        }
        static void LerCsvDeli()
        {
            var path = Path.Combine(Environment.CurrentDirectory,"arquivos_stream", "Entrada", "usuario-delimitador.csv");
            var fi = new FileInfo(path);

            if(!fi.Exists)
                throw new FileNotFoundException($"o arquivo {path} não existe");

            using var sr = new StreamReader(fi.FullName);
            var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ";"
            };
            using var csvReader = new CsvReader(sr, csvConfig);

            var registros = csvReader.GetRecords<Usuario>().ToList();

            foreach (var item in registros)
            {
                WriteLine($"nome: {item.Nome}");
                WriteLine($"email: {item.Email}");
                WriteLine($"telefone: {item.Telefone}");
                WriteLine($"nascimento: {item.Nascimento}");
                WriteLine("--------------------");
            }
        }
        static void LerCsvClasse()
        {
            var path = Path.Combine(Environment.CurrentDirectory,"arquivos_stream", "Entrada", "usuario-exportacao.csv");
            var fi = new FileInfo(path);

            if(!fi.Exists)
                throw new FileNotFoundException($"o arquivo {path} não existe");

            using var sr = new StreamReader(fi.FullName);
            var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture);
            using var csvReader = new CsvReader(sr, csvConfig);

            var registros = csvReader.GetRecords<Usuario>().ToList();

            foreach (var item in registros)
            {
                WriteLine($"nome: {item.Nome}");
                WriteLine($"email: {item.Email}");
                WriteLine($"telefone: {item.Telefone}");
                WriteLine($"nascimento: {item.Nascimento}");
                WriteLine("--------------------");
            }
        }
    }
}
