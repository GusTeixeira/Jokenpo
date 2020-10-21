using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace JokenPo
{
    public partial class frmJokenPo : Form
    {
        int Pedra = 1, Tesoura = 2, Papel = 3, escolha_jogador = 0, escolha_computador = 0,
        pontos_jogador = 0, pontos_empates = 0, pontos_computador = 0,
        contador_rounds = 1, limite_rounds = 0;

        String limite_usuario;

        public frmJokenPo()
        {
            InitializeComponent();

            limite_usuario = Interaction.InputBox("Informe a quantidade de rounds desejada.", "Quantidade de Rounds", "Digite apenas números");

            limite_rounds = Convert.ToInt32(limite_usuario);

            MessageBox.Show("Bom Jogo!", "Preparado?", MessageBoxButtons.OK, MessageBoxIcon.Information);

            lblRound.Text = "Round: " + Convert.ToString(contador_rounds) + " / " + Convert.ToString(limite_rounds);

        }

        private void btnPedra_Click(object sender, EventArgs e)
        {
            escolha_jogador = Pedra;
            pbxJogador.ImageLocation = "E:/Ensino Técnico - Informática/2º MÓDULO/DESENVOLVIMENTO DE SOFTWARE I/JokenPo/JokenPo/Imagens/pedra.png";
            Random rnd = new Random();
            escolha_computador = rnd.Next(1, 4);
            lblJogadaJogador.Text = "Pedra";
            if (escolha_computador == Pedra)
            {
                pbxComputador.ImageLocation = "E:/Ensino Técnico - Informática/2º MÓDULO/DESENVOLVIMENTO DE SOFTWARE I/JokenPo/JokenPo/Imagens/pedra_computador.png";
                lblJogadaComputador.Text = "Pedra";
                lblResultado1.Text = "Resultado: Empate";
                pontos_empates++;
            }
            if (escolha_computador == Tesoura)
            {
                pbxComputador.ImageLocation = "E:/Ensino Técnico - Informática/2º MÓDULO/DESENVOLVIMENTO DE SOFTWARE I/JokenPo/JokenPo/Imagens/tesoura_computador.png";
                lblJogadaComputador.Text = "Tesoura";
                lblResultado1.Text = "Resultado: Vitória";
                pontos_jogador++;
            }
            if (escolha_computador == Papel)
            {
                pbxComputador.ImageLocation = "E:/Ensino Técnico - Informática/2º MÓDULO/DESENVOLVIMENTO DE SOFTWARE I/JokenPo/JokenPo/Imagens/papel_computador.png";
                lblJogadaComputador.Text = "Papel";
                lblResultado1.Text = "Resultado: Derrota";
                pontos_computador++;
            }
            contador_rounds++;
            lblRound.Text = "Round: " + Convert.ToString(contador_rounds) + " / " + Convert.ToString(limite_rounds);
            lblVitorias.Text = Convert.ToString(pontos_jogador);
            lblEmpates.Text = Convert.ToString(pontos_empates);
            lblDerrotas.Text = Convert.ToString(pontos_computador);
            bonfim();
        }

        private void btnTesoura_Click(object sender, EventArgs e)
        {
            escolha_jogador = Tesoura;
            pbxJogador.ImageLocation = "E:/Ensino Técnico - Informática/2º MÓDULO/DESENVOLVIMENTO DE SOFTWARE I/JokenPo/JokenPo/Imagens/tesoura.png";
            Random rnd = new Random();
            escolha_computador = rnd.Next(1, 4);
            lblJogadaJogador.Text = "Tesoura";
            if (escolha_computador == Pedra)
            {
                pbxComputador.ImageLocation = "E:/Ensino Técnico - Informática/2º MÓDULO/DESENVOLVIMENTO DE SOFTWARE I/JokenPo/JokenPo/Imagens/pedra_computador.png";
                lblJogadaComputador.Text = "Pedra";
                lblResultado1.Text = "Resultado: Derrota";
                pontos_computador++;
            }
            if (escolha_computador == Tesoura)
            {
                pbxComputador.ImageLocation = "E:/Ensino Técnico - Informática/2º MÓDULO/DESENVOLVIMENTO DE SOFTWARE I/JokenPo/JokenPo/Imagens/tesoura_computador.png";
                lblJogadaComputador.Text = "Tesoura";
                lblResultado1.Text = "Resultado: Empate";
                pontos_empates++;
            }
            if (escolha_computador == Papel)
            {
                pbxComputador.ImageLocation = "E:/Ensino Técnico - Informática/2º MÓDULO/DESENVOLVIMENTO DE SOFTWARE I/JokenPo/JokenPo/Imagens/papel_computador.png";
                lblJogadaComputador.Text = "Papel";
                lblResultado1.Text = "Resultado: Vitória";
                pontos_jogador++;
            }
            contador_rounds++;
            lblRound.Text = "Round: " + Convert.ToString(contador_rounds) + " / " + Convert.ToString(limite_rounds);
            lblVitorias.Text = Convert.ToString(pontos_jogador);
            lblEmpates.Text = Convert.ToString(pontos_empates);
            lblDerrotas.Text = Convert.ToString(pontos_computador);
            bonfim();
        }

        private void btnPapel_Click(object sender, EventArgs e) {
            escolha_jogador = Papel;
            pbxJogador.ImageLocation = "E:/Ensino Técnico - Informática/2º MÓDULO/DESENVOLVIMENTO DE SOFTWARE I/JokenPo/JokenPo/Imagens/papel.png";
            Random rnd = new Random();
            escolha_computador = rnd.Next(1, 4);
            lblJogadaJogador.Text = "Papel";
            if (escolha_computador == Pedra) {
                pbxComputador.ImageLocation = "E:/Ensino Técnico - Informática/2º MÓDULO/DESENVOLVIMENTO DE SOFTWARE I/JokenPo/JokenPo/Imagens/pedra_computador.png";
                lblJogadaComputador.Text = "Pedra";
                lblResultado1.Text = "Resultado: Vitória";
                pontos_jogador++;
            }
            if (escolha_computador == Tesoura) {
                pbxComputador.ImageLocation = "E:/Ensino Técnico - Informática/2º MÓDULO/DESENVOLVIMENTO DE SOFTWARE I/JokenPo/JokenPo/Imagens/tesoura_computador.png";
                lblJogadaComputador.Text = "Tesoura";
                lblResultado1.Text = "Resultado: Derrota";
                pontos_computador++;
            }
            if (escolha_computador == Papel) {
                pbxComputador.ImageLocation = "E:/Ensino Técnico - Informática/2º MÓDULO/DESENVOLVIMENTO DE SOFTWARE I/JokenPo/JokenPo/Imagens/papel_computador.png";
                lblJogadaComputador.Text = "Papel";
                lblResultado1.Text = "Resultado: Empate";
                pontos_empates++;
            }
            contador_rounds++;
            lblRound.Text = "Round: " + Convert.ToString(contador_rounds) + " / " + Convert.ToString(limite_rounds);
            lblVitorias.Text = Convert.ToString(pontos_jogador);
            lblEmpates.Text = Convert.ToString(pontos_empates);
            lblDerrotas.Text = Convert.ToString(pontos_computador);
            bonfim();
        }

        public void bonfim() 
        {

            if (contador_rounds > limite_rounds) {

                if (pontos_jogador > pontos_computador) {
                    MessageBox.Show("Você venceu!", "Placar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (pontos_computador > pontos_jogador) {
                    MessageBox.Show("Você perdeu!", "Placar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (pontos_jogador == pontos_computador) {
                    MessageBox.Show("Você empatou!", "Placar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                DialogResult dialog = MessageBox.Show("Deseja continuar?", "Fim de jogo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialog == DialogResult.Yes) {

                    escolha_jogador = 0;
                    escolha_computador = 0;
                    pontos_jogador = 0;
                    pontos_empates = 0;
                    pontos_computador = 0;
                    contador_rounds = 0;
                    limite_rounds = 0;
                    pbxJogador.Image = null;
                    pbxComputador.Image = null;
                    lblRound.Text = "Round: " + Convert.ToString(contador_rounds) + " / " + Convert.ToString(limite_rounds);
                    lblVitorias.Text = Convert.ToString(pontos_jogador);
                    lblEmpates.Text = Convert.ToString(pontos_empates);
                    lblDerrotas.Text = Convert.ToString(pontos_computador);
                    lblResultado1.Text = "Resultado: ";
                    lblJogadaJogador.Text = "Jogada";
                    lblJogadaComputador.Text = "Jogada";

                    limite_usuario = Interaction.InputBox("Informe a quantidade de rounds desejada.", "Quantidade de Rounds", "Digite apenas números");

                    limite_rounds = Convert.ToInt32(limite_usuario);

                    MessageBox.Show("Bom Jogo!", "Preparado?", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (dialog == DialogResult.No) {
                    MessageBox.Show("Feito por: Gabriel Bonifácio e Gustavo Teixeira", "Obrigado por jogar!", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Application.Exit();
                }

            }

        }

    }
}