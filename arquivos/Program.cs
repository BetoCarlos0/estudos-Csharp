using estudos_Csharp.arquivos.Helper;

namespace estudos_Csharp.arquivos
{
    public class Program
    {
        static void Main(string[] args)
        {
            var path = Path.Combine(Environment.CurrentDirectory);

            //var paths = new FileHelper();
            //paths.ListDirectory(path);

            var paths = new FileHelper();
            paths.ListFiles(path);
        }
    }
}