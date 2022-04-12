namespace atvd_avaliativa
{
    partial class frmCadastro
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
            this.lblTituloUsu = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblSenha2 = new System.Windows.Forms.Label();
            this.lblSenha1 = new System.Windows.Forms.Label();
            this.txtSenha1 = new System.Windows.Forms.TextBox();
            this.lblFuncao = new System.Windows.Forms.Label();
            this.txtSenha2 = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.cmbFuncao = new System.Windows.Forms.ComboBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.grbCadastro = new System.Windows.Forms.GroupBox();
            this.MtxtDatadeNasc = new System.Windows.Forms.MaskedTextBox();
            this.lblDatadeNasc = new System.Windows.Forms.Label();
            this.pibImagem = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.grbCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloUsu
            // 
            this.lblTituloUsu.AutoSize = true;
            this.lblTituloUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloUsu.Location = new System.Drawing.Point(89, -96);
            this.lblTituloUsu.Name = "lblTituloUsu";
            this.lblTituloUsu.Size = new System.Drawing.Size(105, 25);
            this.lblTituloUsu.TabIndex = 20;
            this.lblTituloUsu.Text = "Usuários";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(636, -93);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 17;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(69, 38);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(120, 20);
            this.txtNome.TabIndex = 8;
            // 
            // lblSenha2
            // 
            this.lblSenha2.AutoSize = true;
            this.lblSenha2.Location = new System.Drawing.Point(334, 92);
            this.lblSenha2.Name = "lblSenha2";
            this.lblSenha2.Size = new System.Drawing.Size(90, 13);
            this.lblSenha2.TabIndex = 7;
            this.lblSenha2.Text = "Repetir senha:";
            // 
            // lblSenha1
            // 
            this.lblSenha1.AutoSize = true;
            this.lblSenha1.Location = new System.Drawing.Point(16, 92);
            this.lblSenha1.Name = "lblSenha1";
            this.lblSenha1.Size = new System.Drawing.Size(47, 13);
            this.lblSenha1.TabIndex = 6;
            this.lblSenha1.Text = "Senha:";
            // 
            // txtSenha1
            // 
            this.txtSenha1.Location = new System.Drawing.Point(69, 90);
            this.txtSenha1.Name = "txtSenha1";
            this.txtSenha1.PasswordChar = '•';
            this.txtSenha1.Size = new System.Drawing.Size(235, 20);
            this.txtSenha1.TabIndex = 10;
            // 
            // lblFuncao
            // 
            this.lblFuncao.AutoSize = true;
            this.lblFuncao.Location = new System.Drawing.Point(407, 41);
            this.lblFuncao.Name = "lblFuncao";
            this.lblFuncao.Size = new System.Drawing.Size(53, 13);
            this.lblFuncao.TabIndex = 5;
            this.lblFuncao.Text = "Função:";
            // 
            // txtSenha2
            // 
            this.txtSenha2.Location = new System.Drawing.Point(429, 90);
            this.txtSenha2.Name = "txtSenha2";
            this.txtSenha2.PasswordChar = '•';
            this.txtSenha2.Size = new System.Drawing.Size(169, 20);
            this.txtSenha2.TabIndex = 11;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(204, 41);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "E-mail:";
            // 
            // cmbFuncao
            // 
            this.cmbFuncao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuncao.FormattingEnabled = true;
            this.cmbFuncao.Items.AddRange(new object[] {
            "Atendente",
            "Estagiário",
            "Estoquista",
            "Recepcionista",
            "Supervisor",
            "Suporte Técnico"});
            this.cmbFuncao.Location = new System.Drawing.Point(465, 37);
            this.cmbFuncao.Name = "cmbFuncao";
            this.cmbFuncao.Size = new System.Drawing.Size(133, 21);
            this.cmbFuncao.Sorted = true;
            this.cmbFuncao.TabIndex = 12;
            this.cmbFuncao.SelectedIndexChanged += new System.EventHandler(this.cmbFuncao_SelectedIndexChanged);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(18, 41);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 13);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(256, 171);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(342, 31);
            this.btnCadastrar.TabIndex = 13;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(256, 38);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(138, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(6, 135);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(61, 13);
            this.lblTelefone.TabIndex = 14;
            this.lblTelefone.Text = "Telefone:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(71, 135);
            this.txtTelefone.Mask = "(99) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(147, 20);
            this.txtTelefone.TabIndex = 16;
            // 
            // grbCadastro
            // 
            this.grbCadastro.Controls.Add(this.btnSair);
            this.grbCadastro.Controls.Add(this.MtxtDatadeNasc);
            this.grbCadastro.Controls.Add(this.lblDatadeNasc);
            this.grbCadastro.Controls.Add(this.txtTelefone);
            this.grbCadastro.Controls.Add(this.lblTelefone);
            this.grbCadastro.Controls.Add(this.txtEmail);
            this.grbCadastro.Controls.Add(this.btnCadastrar);
            this.grbCadastro.Controls.Add(this.lblNome);
            this.grbCadastro.Controls.Add(this.cmbFuncao);
            this.grbCadastro.Controls.Add(this.lblEmail);
            this.grbCadastro.Controls.Add(this.txtSenha2);
            this.grbCadastro.Controls.Add(this.lblFuncao);
            this.grbCadastro.Controls.Add(this.txtSenha1);
            this.grbCadastro.Controls.Add(this.lblSenha1);
            this.grbCadastro.Controls.Add(this.lblSenha2);
            this.grbCadastro.Controls.Add(this.txtNome);
            this.grbCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCadastro.Location = new System.Drawing.Point(91, 392);
            this.grbCadastro.Name = "grbCadastro";
            this.grbCadastro.Size = new System.Drawing.Size(617, 240);
            this.grbCadastro.TabIndex = 18;
            this.grbCadastro.TabStop = false;
            this.grbCadastro.Text = "Cadastro";
            this.grbCadastro.Enter += new System.EventHandler(this.grbCadastro_Enter);
            // 
            // MtxtDatadeNasc
            // 
            this.MtxtDatadeNasc.Location = new System.Drawing.Point(394, 132);
            this.MtxtDatadeNasc.Mask = "00/00/0000";
            this.MtxtDatadeNasc.Name = "MtxtDatadeNasc";
            this.MtxtDatadeNasc.Size = new System.Drawing.Size(100, 20);
            this.MtxtDatadeNasc.TabIndex = 19;
            this.MtxtDatadeNasc.ValidatingType = typeof(System.DateTime);
            // 
            // lblDatadeNasc
            // 
            this.lblDatadeNasc.AutoSize = true;
            this.lblDatadeNasc.Location = new System.Drawing.Point(256, 135);
            this.lblDatadeNasc.Name = "lblDatadeNasc";
            this.lblDatadeNasc.Size = new System.Drawing.Size(132, 13);
            this.lblDatadeNasc.TabIndex = 17;
            this.lblDatadeNasc.Text = "Data De  Nascimento:";
            // 
            // pibImagem
            // 
            this.pibImagem.Image = global::atvd_avaliativa.Properties.Resources.Cadastro;
            this.pibImagem.Location = new System.Drawing.Point(91, 24);
            this.pibImagem.Name = "pibImagem";
            this.pibImagem.Size = new System.Drawing.Size(617, 362);
            this.pibImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibImagem.TabIndex = 21;
            this.pibImagem.TabStop = false;
            this.pibImagem.Click += new System.EventHandler(this.pibImagem_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(69, 171);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 31);
            this.btnSair.TabIndex = 20;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 644);
            this.Controls.Add(this.pibImagem);
            this.Controls.Add(this.lblTituloUsu);
            this.Controls.Add(this.grbCadastro);
            this.Controls.Add(this.btnAtualizar);
            this.Name = "frmCadastro";
            this.Text = "Cadastro";
            this.grbCadastro.ResumeLayout(false);
            this.grbCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTituloUsu;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblSenha2;
        private System.Windows.Forms.Label lblSenha1;
        private System.Windows.Forms.TextBox txtSenha1;
        private System.Windows.Forms.Label lblFuncao;
        private System.Windows.Forms.TextBox txtSenha2;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.ComboBox cmbFuncao;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.GroupBox grbCadastro;
        private System.Windows.Forms.PictureBox pibImagem;
        private System.Windows.Forms.MaskedTextBox MtxtDatadeNasc;
        private System.Windows.Forms.Label lblDatadeNasc;
        private System.Windows.Forms.Button btnSair;
    }
}

