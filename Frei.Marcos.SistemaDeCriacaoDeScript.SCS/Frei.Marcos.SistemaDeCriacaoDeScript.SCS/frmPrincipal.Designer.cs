namespace Frei.Marcos.SistemaDeCriacaoDeScript.SCS
{
    partial class frmPrincipal
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
            this.cbbOcupacao = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPartido = new System.Windows.Forms.TextBox();
            this.txtNCandidato = new System.Windows.Forms.TextBox();
            this.txtCandidato = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.img = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbOcupacao
            // 
            this.cbbOcupacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbOcupacao.Font = new System.Drawing.Font("Footlight MT Light", 18F);
            this.cbbOcupacao.FormattingEnabled = true;
            this.cbbOcupacao.Items.AddRange(new object[] {
            "Presidente",
            "Vice-Presidente",
            "Governador",
            "Vice-Governador",
            "Senador",
            "Suplente 1",
            "Suplente 2",
            "Deputado Estadual",
            "Deputado Federal"});
            this.cbbOcupacao.Location = new System.Drawing.Point(515, 77);
            this.cbbOcupacao.Name = "cbbOcupacao";
            this.cbbOcupacao.Size = new System.Drawing.Size(226, 33);
            this.cbbOcupacao.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.label3.Location = new System.Drawing.Point(136, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 33);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nº Partido:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.label5.Location = new System.Drawing.Point(107, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 33);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nº Candidato:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.label2.Location = new System.Drawing.Point(382, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 33);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ocupação:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Engravers MT", 28F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(13, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(725, 45);
            this.label4.TabIndex = 12;
            this.label4.Text = "Registrar Candidatura";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 33);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nome do Candidato:";
            // 
            // txtPartido
            // 
            this.txtPartido.Font = new System.Drawing.Font("Footlight MT Light", 18F);
            this.txtPartido.Location = new System.Drawing.Point(283, 116);
            this.txtPartido.MaxLength = 2;
            this.txtPartido.Name = "txtPartido";
            this.txtPartido.Size = new System.Drawing.Size(93, 33);
            this.txtPartido.TabIndex = 3;
            // 
            // txtNCandidato
            // 
            this.txtNCandidato.Font = new System.Drawing.Font("Footlight MT Light", 18F);
            this.txtNCandidato.Location = new System.Drawing.Point(282, 77);
            this.txtNCandidato.MaxLength = 5;
            this.txtNCandidato.Name = "txtNCandidato";
            this.txtNCandidato.Size = new System.Drawing.Size(94, 33);
            this.txtNCandidato.TabIndex = 1;
            // 
            // txtCandidato
            // 
            this.txtCandidato.Font = new System.Drawing.Font("Footlight MT Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCandidato.Location = new System.Drawing.Point(282, 38);
            this.txtCandidato.MaxLength = 50;
            this.txtCandidato.Name = "txtCandidato";
            this.txtCandidato.Size = new System.Drawing.Size(459, 33);
            this.txtCandidato.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(194)))), ((int)(((byte)(0)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtCandidato);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNCandidato);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPartido);
            this.panel1.Controls.Add(this.cbbOcupacao);
            this.panel1.Location = new System.Drawing.Point(21, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 171);
            this.panel1.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(272, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(292, 40);
            this.label6.TabIndex = 13;
            this.label6.Text = "Informações Gerais";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Frei.Marcos.SistemaDeCriacaoDeScript.SCS.Properties.Resources.Logo_TSE;
            this.pictureBox1.Location = new System.Drawing.Point(744, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRegistrar.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.btnRegistrar.Location = new System.Drawing.Point(358, 556);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(131, 47);
            this.btnRegistrar.TabIndex = 16;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(194)))), ((int)(((byte)(0)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.img);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(21, 357);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(807, 186);
            this.panel2.TabIndex = 19;
            // 
            // img
            // 
            this.img.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img.Location = new System.Drawing.Point(305, 17);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(192, 128);
            this.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img.TabIndex = 17;
            this.img.TabStop = false;
            this.img.Click += new System.EventHandler(this.img_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(285, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(224, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Carregue a foto do Candidato";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(254, 318);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(320, 40);
            this.label11.TabIndex = 13;
            this.label11.Text = "Imagem do Candidato";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(115)))), ((int)(((byte)(123)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(846, 615);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SCS - Sistema de Criação de Script";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbOcupacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPartido;
        private System.Windows.Forms.TextBox txtNCandidato;
        private System.Windows.Forms.TextBox txtCandidato;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox img;
    }
}

