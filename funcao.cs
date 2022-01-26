/*
using System;
namespace estudosCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            soma(4,8);
        }
        static void soma(int n1, int n2)
        {
            int result = n1 + n2;
            Console.WriteLine(result);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(soma(4,8)); 
        }
        static int soma(int n1, int n2)
        {
            int result = n1 + n2;
            
            return result;
        }

        //função passagem por referencia 'ref', altera o valor da variável
        static void Main(string[] args)
        {
            int n1 = 4;
            int n2 = 8;

            soma(ref n1, n2);
            Console.WriteLine(n1+ " e " +n2); 
        }
        static void soma(ref int n1, int n2)
        {
            n1 = 5;
            n2 = 9;
        }

        //função que retorna mais de um valor 'out'
        static void Main(string[] args)
        {
            int dividendo = 7;
            int divisor = 3;
            int quociente, resto;

            quociente = divide(dividendo, divisor, out resto);
            Console.WriteLine("{0}/{1} tem quociente {2} e resto {3}", dividendo, divisor, quociente, resto); 
        }
        static int divide(int dividendo, int divisor, out int resto)
        {
            resto = dividendo % divisor;
            return dividendo / divisor;
        }

        //função que aceita receber zero, um ou vários valores usando 'params'
        static void Main(string[] args)
        {
            int []b = {1,5,9,7};

            soma();
            soma(20);
            soma(b);
        }
        static void soma(params int[]n)
        {
            if(n.Length < 1)
            {
                Console.WriteLine("array vazio");
            }
            else if(n.Length == 1)
            {
                Console.WriteLine("array com um valor");
            }else
            {
                int result = 0;
                for (int i = 0; i < n.Length; i++)
                {
                    result += n[i];
                }
                Console.WriteLine("resultado {0}", result);
            }
        }

    }
}
*/