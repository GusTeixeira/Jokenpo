using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JokenPo
{
    public partial class frmJokenpo : Form
    {
        public frmJokenpo()
        {
            InitializeComponent();
        }
       
        int Pedra = 1, Tesoura = 2, Papel = 3, escolha_jogador, Computador;

        private void btnPedra_Click(object sender, EventArgs e)
        {
            escolha_jogador = Pedra;
            pbxJogador.ImageLocation = "I:/2°Modulo/Desenvolvimento de Software 1/JokenPo/JokenPo/Resources/pedra_jogador.png";
            Random rnd = new Random();
            Computador = rnd.Next(1, 4);
            if(Computador == 1)
            {
                pbxComputador.ImageLocation = "I:/2°Modulo/Desenvolvimento de Software 1/JokenPo/JokenPo/Resources/pedra_jogador-ConvertImage.png";
            }
            if (Computador == 2)
            {
                pbxComputador.ImageLocation = "I:/2°Modulo/Desenvolvimento de Software 1/JokenPo/JokenPo/Resources/tesoura_jogador-ConvertImage.png";
            }
            if (Computador == 3)
            {
                pbxComputador.ImageLocation = "I:/2°Modulo/Desenvolvimento de Software 1/JokenPo/JokenPo/Resources/papel_jogador-ConvertImage.png";
            }
        }

        private void btnTesoura_Click(object sender, EventArgs e)
        {
            escolha_jogador = Tesoura;
            pbxJogador.ImageLocation = "I:/2°Modulo/Desenvolvimento de Software 1/JokenPo/JokenPo/Resources/tesoura_jogador.png";
            Random rnd = new Random();
            Computador = rnd.Next(1, 4);
            if (Computador == 1)
            {
                pbxComputador.ImageLocation = "I:/2°Modulo/Desenvolvimento de Software 1/JokenPo/JokenPo/Resources/pedra_jogador-ConvertImage.png";
            }
            if (Computador == 2)
            {
                pbxComputador.ImageLocation = "I:/2°Modulo/Desenvolvimento de Software 1/JokenPo/JokenPo/Resources/tesoura_jogador-ConvertImage.png";
            }
            if (Computador == 3)
            {
                pbxComputador.ImageLocation = "I:/2°Modulo/Desenvolvimento de Software 1/JokenPo/JokenPo/Resources/papel_jogador-ConvertImage.png";
            }
        }

        private void btnPapel_Click(object sender, EventArgs e)
        {
            escolha_jogador = Papel;
            pbxJogador.ImageLocation = "I:/2°Modulo/Desenvolvimento de Software 1/JokenPo/JokenPo/Resources/papel_jogador.png";
            Random rnd = new Random();
            Computador = rnd.Next(1, 4);
            if (Computador == 1)
            {
                pbxComputador.ImageLocation = "I:/2°Modulo/Desenvolvimento de Software 1/JokenPo/JokenPo/Resources/pedra_jogador-ConvertImage.png";
            }
            if (Computador == 2)
            {
                pbxComputador.ImageLocation = "I:/2°Modulo/Desenvolvimento de Software 1/JokenPo/JokenPo/Resources/tesoura_jogador-ConvertImage.png";
            }
            if (Computador == 3)
            {
                pbxComputador.ImageLocation = "I:/2°Modulo/Desenvolvimento de Software 1/JokenPo/JokenPo/Resources/papel_jogador-ConvertImage.png";
            }
        }
        
    }
}
