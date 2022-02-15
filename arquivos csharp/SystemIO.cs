/*
    LerCsvDeli();

            
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
            //uso de mapping no arquivo Usuariomap.cs
            //csvReader.Context.RegisterClassMap<UsuarioMap>();
            var registros = csvReader.GetRecords<Usuario>().ToList();

            foreach (var item in registros)
            {
                WriteLine($"nome: {item.Nome}");
                WriteLine($"email: {item.Email}");
                WriteLine($"telefone: {item.Telefone}");
                WriteLine($"nascimento: {item.Nascimento}");
                WriteLine($"altura: {item.Altura}");
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
============================================================================
static void CriarCsv()
        {
            var path = Path.Combine(Environment.CurrentDirectory,"arquivos_stream","Saida", "usuarios.csv");

            var pessoas = new List<Pessoa>(){
                new Pessoa()
                {
                    Nome = "José da Silva",
                    Email = "js@gmail.com",
                    Telefone = 123456,
                    Nascimento = new DateOnly(year: 1970, month: 2, day: 14)
                },
                new Pessoa(){
                    Nome = "Pedro Paiva",
                    Email = "pp@gmail.com",
                    Telefone = 456789,
                    Nascimento = new DateOnly(year: 2002, month: 4, day: 20)
                },
                new Pessoa()
                {
                    Nome = "Maria Antonia",
                    Email = "ma@gmail.com",
                    Telefone = 123456,
                    Nascimento = new DateOnly(year: 1982, month: 12, day: 4)
                },
                new Pessoa()
                {
                    Nome = "Carla Moraes",
                    Email = "cms@gmail.com",
                    Telefone = 9987411,
                    Nascimento = new DateOnly(year: 2000, month: 7, day: 20)
                }
            };

            var di = new DirectoryInfo(path);
            if (!di.Exists)
            {
                di.Create();
                path = Path.Combine(path, "usuarios.csv");
            }
            using var sw = new StreamWriter(path);
            sw.WriteLine("nome,email,telefone,nascimento");
            foreach (var pessoa in pessoas)
            {
                var linha = $"{pessoa.Nome},{pessoa.Email},{pessoa.Telefone},{pessoa.Nascimento}";
                sw.WriteLine(linha);
            }

        }
        static void LerCsv()
        {
            var path = Path.Combine(Environment.CurrentDirectory,"arquivos_stream","Entrada", "usuario-exportacao.csv");

            using var sr = new StreamReader(path);
            var cabecalho = sr.ReadLine()?.Split(',');

            while (true)
            {
                var registro = sr.ReadLine()?.Split(',');

                if (registro == null)
                {
                    break;
                }

                for (int i = 0; i < registro.Length; i++)
                {
                    WriteLine($"{cabecalho?[i]} : {registro[i]}");
                }
                WriteLine("------------------");
            }
        }
        class Pessoa
        {
            public string? Nome { get; set; }
            public string? Email { get; set; }
            public int Telefone { get; set; }
            public DateOnly Nascimento { get; set; }
        }
===========================================================
var sb = new StringBuilder();
            string texto = "textReader é a classe base abstrata de streamReader, que lê caracteres de stream e strings, respectivamente.\n\n Crie uma instância de textReader para abrir um arquivo de texto para ler um intervalo especificado de caracteres ou para criar um leitor baseado em um fluxo existente\n\n Você também pode usar uma instância de textReader para ler texto de um armazenamento de suporte personalizado usando as mesmas APIs que você usaria para uma string ou um fluxo";

            string linha, paragrafo = null;
            var sr= new StringReader(texto);

            while (true)
            {
                linha = sr.ReadLine();
                if(linha != null)
                {
                    paragrafo += linha + " ";
                }else{
                    paragrafo += '\n';
                    break;
                }
            }
            WriteLine($"texto modificado {paragrafo}");

            int caracterLido = 0;
            char caracterConvertido;

            var sw = new StringWriter();
            sr = new StringReader(paragrafo);
            while (true)
            {
                caracterLido = sr.Read();
                if(caracterLido == -1)
                {
                    break;
                }

                caracterConvertido = Convert.ToChar(caracterLido);

                if(caracterConvertido == '.')
                {
                    sw.Write("\n\n");

                    sr.Read();
                    sr.Read();
                }else{
                    sw.Write(caracterLido);
                }
            }
===================================================================
var path = @"D:\betoc\Documents\Visual Studio Projetos\GitHub\estudos-Csharp\arquivos_sream\globo";

    using var fsw = new FileSystemWatcher(path);
    fsw.Created += OnCreated;
    fsw.Deleted += OnDeleted;
    fsw.Renamed += OnRenamed;

    fsw.EnableRaisingEvents = true;
    fsw.IncludeSubdirectories = true;

    WriteLine($"monitorando eventos na pasta arquivos\\globo");
    ReadLine();
}

static void OnRenamed(object sender, RenamedEventArgs e)
{
    WriteLine($"foi renomeado o arquivo de {e.OldName} para {e.Name}");
}

static void OnDeleted(object sender, FileSystemEventArgs e)
{
    WriteLine($"foi deletado o arquivo {e.Name}");
}

static void OnCreated(object sender, FileSystemEventArgs e)
{
    WriteLine($"foi criando o arquivo {e.Name}");
}
=====================================================================
var path = @"D:\betoc\Documents\Visual Studio Projetos\GitHub\estudos-Csharp\arquivos_sream\globo";

    //LerDir(path);
    LerArq(path);
}
static void LerArq(string path)
{
    var arquivos = Directory.GetFiles(path,"*", SearchOption.AllDirectories);

    foreach (var item in arquivos)
    {
        var fileInfo = new FileInfo(item);
        WriteLine($"[name]: {fileInfo.Name}");
        WriteLine($"[tamanho]: {fileInfo.Length}");
        WriteLine($"[ultimo acesso]: {fileInfo.LastAccessTime}");
        WriteLine($"[pasta]: {fileInfo.DirectoryName}");
    }
}
static void LerDir(string path)
{
    var dir = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
    foreach (var item in dir)
    {
        var dirInfo = new DirectoryInfo(item);
        WriteLine($"[name]: {dirInfo.Name}");
        WriteLine($"[raiz]: {dirInfo.Root}");

        if(dirInfo.Parent != null){
        WriteLine($"[pai]: {dirInfo.Parent.Name}");
        }else{
            WriteLine("diretório não existe");
        }
        WriteLine("-----------------------");
    }
}
====================================================================
CriraDirec();

    var dir = Path.Combine(@"D:\betoc\Documents\Visual Studio Projetos\GitHub\estudos-Csharp\arquivos_sream\globo\America do sul\Brasil","Brasil.txt");
    var origin = Path.Combine(Environment.CurrentDirectory, "Brasil.txt");
    CriaArq(Environment.CurrentDirectory, "Brasil.txt");

    MoveArq(origin, dir);
}
static void MoveArq(string Origin, string Desti)
{
    if(Origin == null || Desti == null)
    {
        WriteLine("Destino e Origem não passados");
    }
    else{
        File.Move(Origin, Desti);
    }
}
static void CriaArq(string dir, string name)
{
    var path = Path.Combine(dir, name);
    if(!File.Exists(path))
    {
        using var file = File.CreateText(path);

        file.WriteLine("população: 213 milhoes");
        file.WriteLine("Data: 14/02/2022");
    }else{
        WriteLine("Diretório não encontrado");
    }

}
static void CriraDirec()
{
    var path = Path.Combine(Environment.CurrentDirectory,"arquivos_sream", "globo");

    if (!Directory.Exists(path))
    {
        var dirGlobo = Directory.CreateDirectory(path);
        var dirAmericaNorte = dirGlobo.CreateSubdirectory("America do norte");
        var dirAmericaSul = dirGlobo.CreateSubdirectory("America do sul");

        var  dirUSA = dirAmericaNorte.CreateSubdirectory("USA");
        dirAmericaNorte.CreateSubdirectory("Mexico");
        dirAmericaNorte.CreateSubdirectory("Canada");

        dirAmericaSul.CreateSubdirectory("Brasil");
        dirAmericaSul.CreateSubdirectory("Argentina");
        dirAmericaSul.CreateSubdirectory("Paraguai");
    }
}
=================================================================
var path = Environment.CurrentDirectory + "teste.txt";
var path = Path.Combine(Environment.CurrentDirectory,"teste.txt");

//usa o flush altomaticamente 
using var sw = File.CreateText(path);

sw.WriteLine("linha 1");
sw.WriteLine("linha 2");
sw.WriteLine("linha 3");

WriteLine("Nome do arquivo");
        string fileName = ReadLine();
        
        fileName = LimpaNome(fileName);

        Path.GetInvalidFileNameChars();
        var path = Path.Combine(@"D:\betoc\Documents\Visual Studio Projetos\GitHub\estudos-Csharp\arquivos_sream", $"{fileName}.txt");

        CriaArquivo(path);

        static string LimpaNome(string fileName)
        {
            foreach (var item in Path.GetInvalidFileNameChars())
            {
                fileName = fileName.Replace(item, '-');
            }
            return fileName;
        }
        static void CriaArquivo(string file)
        {
            try
            {
                var sw = File.CreateText(file);
                sw.WriteLine("linha 1");
                sw.WriteLine("linha 2");
                sw.WriteLine("linha 3");
                sw.Flush();
            }
            catch
            {
                
                WriteLine("nome de arquivo inválido");
            }
            
        }
*/