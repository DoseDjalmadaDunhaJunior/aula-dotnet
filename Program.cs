using System;

namespace teste1
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new Game(new Jogador("josé"));
            jogo.IniciarJogo();
        }
    }

    public class Jogador
    {
        public readonly string _Nome;

        public Jogador(string nome)
        {
            _Nome = nome;
        }
        public void chuta()
        {
            Console.Write($"{_Nome} esta chutando\n");
        }

                public void corre()
        {
                        Console.Write($"{_Nome} esta correndo\n");
        }
                public void passe()
        {
                        Console.Write($"{_Nome} esta passando\n");
        }
    }
}
