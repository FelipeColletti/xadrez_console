using System;
using tabuleiro;

namespace xadrez
{
    class PartidaDeXadrez
    {
        public Tabuleiro tab { get;private set; }
        private int turno;
        private Cor jogadorAtual;
        public bool terminada { get; private set;}

        public PartidaDeXadrez()
        {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branca;
            colocarPecas();
        }
        
        public void executaMovimento(Posicao origem , Posicao destino)
        {
            Peca p = tab.retirarPeca(origem);
            p.incrementarQtemovimentos();
            Peca pecaCapturada = tab.retirarPeca(destino);
            tab.colocarPeca(p, destino);
        }

        private void colocarPecas()
        {
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrex('c' ,1).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrex('c', 2).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrex('d', 2).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrex('e', 2).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrex('e', 1).toPosicao());
            tab.colocarPeca(new Rei(tab, Cor.Branca), new PosicaoXadrex('d', 1).toPosicao());

            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrex('c', 7).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrex('c', 8).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrex('d', 7).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrex('e', 7).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrex('e', 8).toPosicao());
            tab.colocarPeca(new Rei(tab, Cor.Preta), new PosicaoXadrex('d', 8).toPosicao());
        }
    }
}
