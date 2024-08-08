using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_de_xadrez.tabuleiro
{
    internal class Tabuleiro
    {
        public int Linha { get; set; }
        public int Colunas { get; set; }
        public Peca[,] Pecas { get; set; }

        public Tabuleiro(int linha, int colunas, Peca[,] pecas)
        {
            Linha = linha;
            Colunas = colunas;
            Pecas = new Peca[Linha, Colunas];
        }
    }
}
