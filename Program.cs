using System;
namespace estudosCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c = new Carro("santana", "verde");

            c.setLigar();

            Console.WriteLine(c.velMax);
            //Console.WriteLine(c.ligado);
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
}

