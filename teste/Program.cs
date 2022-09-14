int quantidadeEntradas = 3;
      
while (quantidadeEntradas > 0) {
    var numeroQuantidade = Int32.Parse(Console.ReadLine());
    
    if (numeroQuantidade >= 1 && numeroQuantidade <= 500) {
    string[] tartarugas = Console.ReadLine().Split(" ");
    var maiorVelocidade = Int32.Parse(tartarugas[0]);
        
// TODO: Crie as outras condições necessárias para a resolução do desafio:
    for (int i = 0; i < tartarugas.Length; i++) {
        var tartaruga = Int32.Parse(tartarugas[i]);
        
        if (tartaruga > maiorVelocidade) {
        maiorVelocidade = tartaruga;
        }
    }

    if(maiorVelocidade < 10) {
        Console.WriteLine(1);
    } else if (maiorVelocidade >= 10 && maiorVelocidade < 20) {
        Console.WriteLine(2);
    } else if (maiorVelocidade >= 20) {
        Console.WriteLine(3);
    }
    quantidadeEntradas--;
    } else {
    Console.WriteLine("Insira um número entre 1 e 500");
    }
}


//---------------------------------------------------------
// Dado um array nums de tamanho n, retorne o elemento majoritário, isto é, o elemento que aparece o maior número de vezes no seu array.

// Entrada
// A primeira linha da entrada deverá ser o número referente ao tamanho do seu array. As demais linhas nums serão os valores da sua array.

// Saída
// A saída deverá retornar o número que aparece o maior número de vezes na sua array, ou seja, o elemento majoritário.
/*
int[] num = new int[] {7,7,5};

Console.WriteLine(MajorityElement(num));

int MajorityElement(int[] nums)
{
    Dictionary<int, int> result = new Dictionary<int, int>();

    for (int i = 0; i < nums.Length; i++)
    {
        if (!result.ContainsKey(nums[i]))
            result.Add(nums[i], 1);
        else{
            result[result.Where(x => x.Key == nums[i]).Select(x => x.Key).First()] += 1;
        }
    }
    return result.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
}*/