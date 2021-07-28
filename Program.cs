using System;

namespace teste1
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new Game
            (new Jogador1("José"), 
            new Jogador2());
            jogo.IniciarJogo();
        }
    }

    
}
