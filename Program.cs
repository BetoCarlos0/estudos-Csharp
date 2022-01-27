using System;
namespace estudosCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> veic = new List<string>();

            veic.Add("carro");
            veic.Add("moto");
            veic.Add("barco");
            veic.Add("avião");

            veic.Remove("bike");

        }
    }
}

