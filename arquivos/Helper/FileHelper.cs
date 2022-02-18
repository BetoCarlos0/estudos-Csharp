using static System.Console;

namespace estudos_Csharp.arquivos.Helper
{
    public class FileHelper
    {
        public void ListDirectory(string path)
        {
            var direc = Directory.GetDirectories(path,"*",SearchOption.AllDirectories);

            foreach (var item in direc)
            {
                WriteLine(item);
            }
        }

        public void ListFiles(string path)
        {
            //"*", "*.txt", "*.cs", "*gram*"
            var files = Directory.GetFiles(path, "*gram*", SearchOption.AllDirectories);

            foreach (var item in files)
            {
                WriteLine(item);
            }
        }

        public void CriarDirec(string path)
        {
            var direc = Directory.CreateDirectory(path);

            if (direc.Exists)
            {
                WriteLine($"Diretório criado: {direc.FullName}");
                WriteLine($"Nome do diretório: {direc.Name}");
            }else{
                WriteLine("Diretório não existe");
            }
        }

        public void DeletDirec(string path)
        {
            if (Directory.Exists(path))
            {
                WriteLine($"Diretório {path} Deletado");
                Directory.Delete(path);
                
            }else{
                WriteLine("Diretório não existe");
            }
        }

        public void CreateFile(string path, string file)
        {
            File.WriteAllText(path, file);
        }

        public void CreateFilestream(string path, List<string> content)
        {
            using var stream = File.CreateText(path);

            foreach (var item in content)
            {
                stream.WriteLine(item);
            }
        }

        public void AddFilestream(string path, List<string> content)
        {
            using var stream = File.AppendText(path);
            
            foreach (var item in content)
            {
                stream.WriteLine(item);
            }
        }

        public void ReadFileStream(string path)
        {
            using var file = File.OpenText(path);

            var text = string.Empty;
            
            while ((text = file.ReadLine()) != null)
            {
                WriteLine(text);
            }
            //WriteLine(text.ToString());
        }
    }
}