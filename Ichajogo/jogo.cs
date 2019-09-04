using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ichajogo
{

    public static class Jogo
    {
        public static int Round = 0;

        public static void Reiniciar()
        {
            Tabuleiro = new int[9];
            Round = 0;
        }

        public static int[] Tabuleiro = new int[9];

        public static string JogadorAtual()
        {
            return Round % 2 == 0 ? "O" : "X";
        }

        public static string JogadorProximo()
        {
            return Round % 2 != 0 ? "O" : "X";
        }

        public static void RealizarJogada(int casa, string figuraStr)
        {
            int figura = figuraStr == "O" ? 1 : 2;

            if (Tabuleiro[casa] == 0)
            {
                Tabuleiro[casa] = figura;
            }

            Round++;
        }

        public static string VerificarVencedor()
        {
            int[][] posibilidades = new[]
            {
                new [] { 0,1,2 },
                new [] { 3,4,5 },
                new [] { 6,7,8 },

                new [] { 0,3,6 },
                new [] { 1,4,7 },
                new [] { 2,5,8 },

                new [] { 0,4,8 },
                new [] { 2,4,6 },
            };

            foreach (var p in posibilidades)
            {
                if (Tabuleiro[p[0]] != 0 && Tabuleiro[p[0]] == Tabuleiro[p[1]] && Tabuleiro[p[0]] == Tabuleiro[p[2]])
                {
                    return Tabuleiro[p[0]] == 1 ? "O" : "X";
                }
            }

            return "";
        }

    }
}
