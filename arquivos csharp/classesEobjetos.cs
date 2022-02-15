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
    //======================================================
    class Program
    {
        static void Main(string[] args)
        {
            Carro c = new Carro("santana", "verde", 4);

            c.setLigar();

            Console.WriteLine(c.velMax);
            Console.WriteLine(c.getLigado());
            Console.WriteLine(c.getRodas());
        }

    }
    public class Veiculo
    {
        private int rodas;
        public int velMax;
        protected bool ligado;

        public Veiculo(int rodas)
        {
            this.rodas = rodas;
        }

        public int getRodas(){
            return rodas;
        }

        public bool getLigado()
        {
            return ligado;
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
        public Carro(string nome, string cor, int roda):base(roda)
        {
            this.cor = cor;
            this.nome = nome;
            velMax = 120;
            ligado = true;
        }
    }
    //====================================================
    //sobrescrita de métodos com virtual e override
    class Program
    {
        static void Main(string[] args)
        {
            Carro c = new Carro();

            c.info();
        }

    }
     public class Veiculo
    {
        virtual public void info()
        {
            Console.WriteLine("info base");
        }
    }
    public class Carro : Veiculo
    {
        override public void info()
        {
            Console.WriteLine("info derivada");
        }
    }
    //===================================================
    class Program
    {
        static void Main(string[] args)
        {
            Carro c = new Carro(120, true);

            c.nameVei("carrinho");
        }

    }
    abstract class Veiculo
    {
        protected bool ligado;
        protected int velMax;
        protected string nome;
        public Veiculo()
        {
            ligado = false;
            velMax = 0;
            nome = "";
        }

        abstract public void nameVei(string nome);

    }
    class Carro : Veiculo
    {
        public Carro(int velMax, bool ligado){
            this.velMax = velMax;
            this.ligado = ligado;
        }

        override public void nameVei(string nome)
        {
            this.nome = nome;
        }
    }
    //=====================================================
    class Program
    {
        static void Main(string[] args)
        {
            Carro c = new Carro();

            Console.WriteLine("velocidade {0}", c.vm);

            c.vm = 200;
            Console.WriteLine("velocidade {0}", c.vm);
        }
    }
    
    class Carro
    {
        private int velMax;
        public int vm
        {
            get{
                return velMax;
            }
            set{
                if(value < 0)
                {
                    velMax = 0;
                }
                else if(value > 300)
                {
                    velMax = 300;
                }
                else{
                    velMax = value;
                }
            }
        }
        public Carro(){
            velMax = 120;
            vm = 120;
        }
    }
    //=====================================================
    class Program
    {
        static void Main(string[] args)
        {
            Carro c = new Carro();

            Console.WriteLine("velocidade {0}", c[3]);

            c[3] = 200;
            Console.WriteLine("velocidade {0}", c[0]);
        }
    }
    
    class Carro
    {
        private int[] velMax = {80,120,160,240,300};
        public int this[int i]
        {
            get{
                return velMax[i];
            }
            set{
                if(value < 0)
                {
                    velMax[i] = 0;
                }
                else if(value > 300)
                {
                    velMax[i] = 300;
                }
                else{
                    velMax[i] = value;
                }
            }
        }
    }
    //=====================================================
    class Program
    {
        static void Main(string[] args)
        {
            Carro c = new Carro();

            Console.WriteLine("velocidade {0}");

            Console.WriteLine("velocidade {0}");
        }
    }

    public interface Veiculo
    {
        void ligar();
        void desligar();
        void info();
    }

    class Carro : Veiculo
    {
        private bool ligado;
        public void ligar()
        {
            ligado = true;
        }
        public void desligar()
        {
            ligado = false;
        }
        public void info()
        {

        }
        public Carro()
        {

        }
    }
    //=======================================
    class Program
    {
        static void Main(string[] args)
        {
            Galinha g = new Galinha("benedita");

            g.botar();
            g.botar();
        }
    }
    class Galinha
    {
        private string nomeGalinha;
        private int numOvo;
        public Galinha(string nomeGalinha)
        {
            this.nomeGalinha = nomeGalinha;
            numOvo = 0;
        }

        public Ovo botar()
        {
            numOvo ++;
            return new Ovo(numOvo, nomeGalinha);
        }
    }
    class Ovo
    {
        private int numOvo;
        private string minhaGalinha;
        public Ovo(int numOvo, string galinha)
        {
            this.numOvo = numOvo;
            this.minhaGalinha = galinha;
            Console.WriteLine("{0} ovo(s) criado(s) - {1}", this.numOvo, this.minhaGalinha);
        }
    }
    //==============================================
    delegate int Op(int n1, int n2);
    class Program
    {
        static void Main(string[] args)
        {
            int res;
            Op g = new Op(Mat.soma);

            res = g(10,50);
        }
    }
    class Mat
    {
        public static int soma(int n1, int n2)
        {
            return n1+n2;
        }

        public static int dobro(int n1)
        {
            return n1 * 2;
        }
    }
    //==============================================
    
*/