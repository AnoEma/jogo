using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ichajogo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button00(object sender, EventArgs e)
        {
            string jogador = Jogo.JogadorAtual();

            var botao = (Button)sender;
            botao.Text = jogador;

            int posicao = botao.Name.Last() - '0';
            posicao--;

            Jogo.RealizarJogada(posicao, jogador);
            string vencedor = Jogo.VerificarVencedor();

            if (vencedor != "")
            {
                MessageBox.Show(vencedor);

                if (vencedor == "X")
                {
                    var placar = int.Parse(button15.Text);
                    placar++;

                    button15.Text = placar.ToString();
                }
                else
                {
                    var placar = int.Parse(button16.Text);
                    placar++;

                    button16.Text = placar.ToString();
                }
            }

            button2.Text = Jogo.JogadorAtual();
            button18.Text = Jogo.JogadorProximo();
            botao.Enabled = false;


        }

        private void button18_Click(object sender, EventArgs e)
        {
            Jogo.Reiniciar();

            button2.Text = Jogo.JogadorAtual();
            button4.Text = Jogo.JogadorProximo();

            ReiniciarBotao(button18);
            ReiniciarBotao(button2);
            ReiniciarBotao(button3);
            ReiniciarBotao(button4);
            ReiniciarBotao(button5);
            ReiniciarBotao(button6);
            ReiniciarBotao(button7);
            ReiniciarBotao(button8);
            ReiniciarBotao(button9);
        }



        private void ReiniciarBotao(Button btn)
        {
            btn.Enabled = true;
            btn.Text = " - ";
        }
    }
}
