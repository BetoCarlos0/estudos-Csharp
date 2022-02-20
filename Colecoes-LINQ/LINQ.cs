/*
int[] num = new int[] {100, 1, 4, 0, 8, 15, 19};

//var pares = num.Where(x => x % 2 == 0).OrderBy(x => x).ToList();

var pares = from nuns in num
            where nuns % 2 == 0
            orderby nuns 
            select nuns; 

System.Console.WriteLine(string.Join(", ", pares));

============================================================


*/