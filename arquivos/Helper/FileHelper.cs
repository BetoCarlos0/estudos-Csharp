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
    }
}