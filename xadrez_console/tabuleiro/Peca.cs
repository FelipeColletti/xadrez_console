
namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao { get; set; }

        public Cor cor { get;protected set; }

        public int qteMovimentos { get;protected set; }

        public Tabuleiro tab { get;protected set; }

        public Peca(Tabuleiro tab,Cor cor)
        {
            this.posicao = null;
            this.cor = cor;
            this.qteMovimentos = 0;
            this.tab = tab;
        }

        public void incrementarQtemovimentos()
        {
            qteMovimentos++;
        }

        public bool existeMovimentosPossiveis()
        {
            bool[,] mat = movimentosPosiveis();
            
            for (int i = 0; i < tab.linhas; i++)
            {
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (mat[i,j] == true)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool podemoverPara(Posicao pos)
        {
            return movimentosPosiveis()[pos.linha,pos.coluna];
        }

        public abstract bool[,] movimentosPosiveis();

    }
}
