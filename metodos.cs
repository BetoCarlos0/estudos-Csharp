/*
Random random = new Random();
int[] n1 = new int[100];
int[] n2 = new int[100];
int[] n3 = new int[100];
//int[] nun = new int[4]{55,77,99};
//int[] num = {55,77,99};

for(int i = 0; i < n1.Length; i++)
{
    n1[i] = random.Next(100);
    Console.WriteLine(n1[i]);
}

int pos = Array.BinarySearch(n1, 8);

if(pos < 0)
{
    Console.WriteLine("não encontrado");
}else
{
    Console.WriteLine("encontrado "+ pos +", array "+ n1[pos]);
}

//copia array
Array.Copy(n1,n2, n1.Length);

//copia array para n3 na posição 0
n1.CopyTo(n3, 0);

//ultimo indice do array '0' e primeiro índice do array
Console.WriteLine(n1.GetUpperBound(0));
    Console.WriteLine(n1.GetLowerBound(0));

Console.WriteLine("valor da posição 95 é "+n1.GetValue(95));

Console.WriteLine("indice do primeiro valor 20 é "+ Array.IndexOf(n1, 20));

Console.WriteLine("indice do ultimo valor 20 é "+ Array.LastIndexOf(n1, 20));

//inverte o array
Array.Reverse(n2);

for (int i = 0; i < n1.Length; i++)
{
    // seta valores de 0 em todas as posições
    n3.SetValue(0,i);
}

// ordena valores em orde crescente
// para ordenar em ordem decrescente use sorte e reverse
Array.Sort(n1);
Array.Reverse(n1);
foreach (int item in n1)
{
    Console.WriteLine(item);
//================================================
static void Main(string[] args)
{
    int n1, n2, result;
    n1 = n2 = result = 0;
    try
    {
        result = n1 / n2;
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
//===========================================
static void Main(string[] args)
{
    Dictionary<int, string> veic = new Dictionary<int, string>();

    veic.Add(10, "carro");
    veic.Add(20, "moto");
    veic.Add(30, "barco");
    veic.Add(40, "avião");

    veic.Remove(20);

    Console.WriteLine(veic[30]);
    veic[30] = "bike";
    Console.WriteLine(veic[30]);

    Console.WriteLine("tamanho {0}", veic.Count);

    if (veic.ContainsKey(10))
    {
        Console.WriteLine("achou");
    }
    if (veic.ContainsValue("avião"))
    {
        Console.WriteLine("achou");
    }

    foreach (var item in veic)
    {
        Console.WriteLine("{0} - {1}",item.Key, item.Value);
    }
}
class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> veic = new LinkedList<string>();

            veic.AddFirst("carro");
            veic.AddFirst("moto");
            veic.AddFirst("barco");
            veic.AddFirst("avião");

            veic.AddLast("bike");

        }
    }
    
}*/