/*
class Program
    {
        static void Main(string[] args)
        {
            Jogador j1 = new Jogador();

            Console.WriteLine(j1.energia);
        }
    }

    public class Jogador
    {
        public int energia = 100;
        public bool vivo = true;
    }
    //=========================================================
    static void Main(string[] args)
        {
            Calculos calc = new Calculos(4, 8);

            Console.WriteLine(calc.n1 + calc.n2);
            Console.WriteLine(calc.Soma(10, 30));
        }
    }

    public class Calculos
    {
        public int n1, n2;

        public Calculos(int n1, int n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }
        public int Soma(int n1, int n2){
            return n1 + n2;
        }
    //=====================================================
    class Program
    {
        static void Main(string[] args)
        {
            Jogador j = new Jogador("teste");

            Console.WriteLine(j.setEnergia(-30));
            Console.WriteLine(j.setEnergia(-30));
            Console.WriteLine(j.setEnergia(-30));
            Console.WriteLine(j.setEnergia(-30));
            Console.WriteLine(j.setEnergia(30));
        }

    }
    public class Jogador
    {
        private string nome;
        private int energia;

        public Jogador(string n)
        {
            this.nome = n;
            energia = 100;
        }

        public int setEnergia(int e)
        {
            energia += e;

            if((energia) > 100)
            {
                return energia = 100;
            }
            
            if(energia < 0)
            {
                return energia = 0;
            }

            return energia;
        }
    }
    //=================================================
    class Program
    {
        static void Main(string[] args)
        {
            Carro c = new Carro("santana", "verde");

            c.setLigar();

            Console.WriteLine(c.velMax);
            Console.WriteLine(c.ligado);
            Console.WriteLine(c.getRodas());
        }

    }
    public class Veiculo
    {
        private int rodas;
        public int velMax;
        public bool ligado;

        public Veiculo(int rodas)
        {
            this.rodas = rodas;
        }

        public int getRodas(){
            return rodas;
        }

        public void setLigar()
        {
            this.ligado = true;
        }
        public void setdesligar()
        {
            this.ligado = false;
        }
    }
    public class Carro : Veiculo
    {
        public string nome;
        public string cor;
        public Carro(string nome, string cor):base(4)
        {
            this.cor = cor;
            this.nome = nome;
            velMax = 120;
        }
    }

*/