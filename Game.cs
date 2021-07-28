namespace teste1
{
    public class Game{
        private readonly Jogador _jogador;

        public Game(Jogador jogador)
        {
            _jogador = jogador;
        }        public void IniciarJogo(){
            _jogador.corre();
            _jogador.chuta();
            _jogador.passe();
        }
    }
}