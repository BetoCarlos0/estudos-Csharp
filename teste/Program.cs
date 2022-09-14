// Dado um array nums de tamanho n, retorne o elemento majoritário, isto é, o elemento que aparece o maior número de vezes no seu array.

// Entrada
// A primeira linha da entrada deverá ser o número referente ao tamanho do seu array. As demais linhas nums serão os valores da sua array.

// Saída
// A saída deverá retornar o número que aparece o maior número de vezes na sua array, ou seja, o elemento majoritário.
        
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
}