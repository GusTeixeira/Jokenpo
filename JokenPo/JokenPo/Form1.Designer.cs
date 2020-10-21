namespace JokenPo
{
    partial class frmJokenpo
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJokenpo));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbxPlacar = new System.Windows.Forms.GroupBox();
            this.lblPerfumaria5 = new System.Windows.Forms.Label();
            this.lblPerfumaria6 = new System.Windows.Forms.Label();
            this.lblPerfumaria3 = new System.Windows.Forms.Label();
            this.lblDerrota = new System.Windows.Forms.Label();
            this.lblVitorias = new System.Windows.Forms.Label();
            this.lblEmpate = new System.Windows.Forms.Label();
            this.btnPedra = new System.Windows.Forms.Button();
            this.btnPapel = new System.Windows.Forms.Button();
            this.btnTesoura = new System.Windows.Forms.Button();
            this.gbxGame = new System.Windows.Forms.GroupBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblResultado1 = new System.Windows.Forms.Label();
            this.lblPerfumaria9 = new System.Windows.Forms.Label();
            this.pbxComputador = new System.Windows.Forms.PictureBox();
            this.pbxJogador = new System.Windows.Forms.PictureBox();
            this.pbxBandeira = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.gbxPlacar.SuspendLayout();
            this.gbxGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxComputador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJogador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBandeira)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Mistral", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Red;
            this.lblTitulo.Location = new System.Drawing.Point(3, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(798, 153);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Jokenpo";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.gbxPlacar);
            this.panel1.Controls.Add(this.pbxBandeira);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 153);
            this.panel1.TabIndex = 1;
            // 
            // gbxPlacar
            // 
            this.gbxPlacar.AutoSize = true;
            this.gbxPlacar.Controls.Add(this.lblPerfumaria5);
            this.gbxPlacar.Controls.Add(this.lblPerfumaria6);
            this.gbxPlacar.Controls.Add(this.lblPerfumaria3);
            this.gbxPlacar.Controls.Add(this.lblDerrota);
            this.gbxPlacar.Controls.Add(this.lblVitorias);
            this.gbxPlacar.Controls.Add(this.lblEmpate);
            this.gbxPlacar.Font = new System.Drawing.Font("Mistral", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPlacar.ForeColor = System.Drawing.Color.Red;
            this.gbxPlacar.Location = new System.Drawing.Point(636, 12);
            this.gbxPlacar.Name = "gbxPlacar";
            this.gbxPlacar.Size = new System.Drawing.Size(142, 127);
            this.gbxPlacar.TabIndex = 5;
            this.gbxPlacar.TabStop = false;
            this.gbxPlacar.Text = "PLACAR";
            // 
            // lblPerfumaria5
            // 
            this.lblPerfumaria5.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfumaria5.Location = new System.Drawing.Point(6, 41);
            this.lblPerfumaria5.Name = "lblPerfumaria5";
            this.lblPerfumaria5.Size = new System.Drawing.Size(99, 32);
            this.lblPerfumaria5.TabIndex = 6;
            this.lblPerfumaria5.Text = "Empates";
            this.lblPerfumaria5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPerfumaria6
            // 
            this.lblPerfumaria6.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfumaria6.Location = new System.Drawing.Point(7, 73);
            this.lblPerfumaria6.Name = "lblPerfumaria6";
            this.lblPerfumaria6.Size = new System.Drawing.Size(99, 32);
            this.lblPerfumaria6.TabIndex = 5;
            this.lblPerfumaria6.Text = "Derrotas";
            this.lblPerfumaria6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPerfumaria3
            // 
            this.lblPerfumaria3.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfumaria3.Location = new System.Drawing.Point(6, 12);
            this.lblPerfumaria3.Name = "lblPerfumaria3";
            this.lblPerfumaria3.Size = new System.Drawing.Size(99, 29);
            this.lblPerfumaria3.TabIndex = 0;
            this.lblPerfumaria3.Text = "Vitórias";
            this.lblPerfumaria3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDerrota
            // 
            this.lblDerrota.AutoSize = true;
            this.lblDerrota.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDerrota.Location = new System.Drawing.Point(107, 73);
            this.lblDerrota.Name = "lblDerrota";
            this.lblDerrota.Size = new System.Drawing.Size(28, 33);
            this.lblDerrota.TabIndex = 3;
            this.lblDerrota.Text = "0";
            // 
            // lblVitorias
            // 
            this.lblVitorias.AutoSize = true;
            this.lblVitorias.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVitorias.Location = new System.Drawing.Point(108, 12);
            this.lblVitorias.Name = "lblVitorias";
            this.lblVitorias.Size = new System.Drawing.Size(28, 33);
            this.lblVitorias.TabIndex = 4;
            this.lblVitorias.Text = "0";
            // 
            // lblEmpate
            // 
            this.lblEmpate.AutoSize = true;
            this.lblEmpate.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpate.Location = new System.Drawing.Point(107, 40);
            this.lblEmpate.Name = "lblEmpate";
            this.lblEmpate.Size = new System.Drawing.Size(28, 33);
            this.lblEmpate.TabIndex = 2;
            this.lblEmpate.Text = "0";
            // 
            // btnPedra
            // 
            this.btnPedra.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnPedra.Font = new System.Drawing.Font("Mistral", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedra.ForeColor = System.Drawing.Color.Red;
            this.btnPedra.Location = new System.Drawing.Point(18, 533);
            this.btnPedra.Name = "btnPedra";
            this.btnPedra.Size = new System.Drawing.Size(156, 61);
            this.btnPedra.TabIndex = 2;
            this.btnPedra.Text = "Pedra";
            this.btnPedra.UseVisualStyleBackColor = false;
            this.btnPedra.Click += new System.EventHandler(this.btnPedra_Click);
            // 
            // btnPapel
            // 
            this.btnPapel.BackColor = System.Drawing.Color.White;
            this.btnPapel.Font = new System.Drawing.Font("Mistral", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPapel.ForeColor = System.Drawing.Color.Red;
            this.btnPapel.Location = new System.Drawing.Point(632, 533);
            this.btnPapel.Name = "btnPapel";
            this.btnPapel.Size = new System.Drawing.Size(156, 61);
            this.btnPapel.TabIndex = 3;
            this.btnPapel.Text = "Papel";
            this.btnPapel.UseVisualStyleBackColor = false;
            this.btnPapel.Click += new System.EventHandler(this.btnPapel_Click);
            // 
            // btnTesoura
            // 
            this.btnTesoura.BackColor = System.Drawing.Color.DarkRed;
            this.btnTesoura.Font = new System.Drawing.Font("Mistral", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTesoura.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTesoura.Location = new System.Drawing.Point(323, 533);
            this.btnTesoura.Name = "btnTesoura";
            this.btnTesoura.Size = new System.Drawing.Size(156, 61);
            this.btnTesoura.TabIndex = 4;
            this.btnTesoura.Text = "Tesoura";
            this.btnTesoura.UseVisualStyleBackColor = false;
            this.btnTesoura.Click += new System.EventHandler(this.btnTesoura_Click);
            // 
            // gbxGame
            // 
            this.gbxGame.Controls.Add(this.pbxComputador);
            this.gbxGame.Controls.Add(this.pbxJogador);
            this.gbxGame.Controls.Add(this.lblResultado);
            this.gbxGame.Controls.Add(this.lblResultado1);
            this.gbxGame.Controls.Add(this.lblPerfumaria9);
            this.gbxGame.Font = new System.Drawing.Font("Mistral", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxGame.ForeColor = System.Drawing.Color.Red;
            this.gbxGame.Location = new System.Drawing.Point(18, 159);
            this.gbxGame.Name = "gbxGame";
            this.gbxGame.Size = new System.Drawing.Size(770, 360);
            this.gbxGame.TabIndex = 6;
            this.gbxGame.TabStop = false;
            this.gbxGame.Text = "JOGO";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(382, 281);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 57);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblResultado1
            // 
            this.lblResultado1.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado1.Location = new System.Drawing.Point(6, 275);
            this.lblResultado1.Name = "lblResultado1";
            this.lblResultado1.Size = new System.Drawing.Size(758, 82);
            this.lblResultado1.TabIndex = 5;
            this.lblResultado1.Text = "Resultado: ";
            this.lblResultado1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPerfumaria9
            // 
            this.lblPerfumaria9.BackColor = System.Drawing.Color.Navy;
            this.lblPerfumaria9.Font = new System.Drawing.Font("Mistral", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfumaria9.Location = new System.Drawing.Point(6, 37);
            this.lblPerfumaria9.Name = "lblPerfumaria9";
            this.lblPerfumaria9.Size = new System.Drawing.Size(758, 83);
            this.lblPerfumaria9.TabIndex = 3;
            this.lblPerfumaria9.Text = "    Jogador    X   Computador";
            this.lblPerfumaria9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxComputador
            // 
            this.pbxComputador.InitialImage = null;
            this.pbxComputador.Location = new System.Drawing.Point(446, 123);
            this.pbxComputador.Name = "pbxComputador";
            this.pbxComputador.Size = new System.Drawing.Size(203, 124);
            this.pbxComputador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxComputador.TabIndex = 10;
            this.pbxComputador.TabStop = false;
            // 
            // pbxJogador
            // 
            this.pbxJogador.ImageLocation = "";
            this.pbxJogador.InitialImage = null;
            this.pbxJogador.Location = new System.Drawing.Point(116, 123);
            this.pbxJogador.Name = "pbxJogador";
            this.pbxJogador.Size = new System.Drawing.Size(203, 124);
            this.pbxJogador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxJogador.TabIndex = 9;
            this.pbxJogador.TabStop = false;
            // 
            // pbxBandeira
            // 
            this.pbxBandeira.Image = global::JokenPo.Properties.Resources.bandeira_japao_media;
            this.pbxBandeira.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbxBandeira.InitialImage")));
            this.pbxBandeira.Location = new System.Drawing.Point(22, 24);
            this.pbxBandeira.Name = "pbxBandeira";
            this.pbxBandeira.Size = new System.Drawing.Size(177, 115);
            this.pbxBandeira.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxBandeira.TabIndex = 1;
            this.pbxBandeira.TabStop = false;
            // 
            // frmJokenpo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(800, 606);
            this.Controls.Add(this.gbxGame);
            this.Controls.Add(this.btnTesoura);
            this.Controls.Add(this.btnPapel);
            this.Controls.Add(this.btnPedra);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmJokenpo";
            this.Text = "JokenPo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbxPlacar.ResumeLayout(false);
            this.gbxPlacar.PerformLayout();
            this.gbxGame.ResumeLayout(false);
            this.gbxGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxComputador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJogador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBandeira)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbxBandeira;
        private System.Windows.Forms.Button btnPedra;
        private System.Windows.Forms.Button btnPapel;
        private System.Windows.Forms.Button btnTesoura;
        private System.Windows.Forms.GroupBox gbxGame;
        private System.Windows.Forms.GroupBox gbxPlacar;
        private System.Windows.Forms.Label lblPerfumaria3;
        private System.Windows.Forms.Label lblVitorias;
        private System.Windows.Forms.Label lblEmpate;
        private System.Windows.Forms.Label lblDerrota;
        private System.Windows.Forms.Label lblPerfumaria5;
        private System.Windows.Forms.Label lblPerfumaria6;
        public System.Windows.Forms.PictureBox pbxJogador;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblResultado1;
        private System.Windows.Forms.Label lblPerfumaria9;
        public System.Windows.Forms.PictureBox pbxComputador;
    }
}

