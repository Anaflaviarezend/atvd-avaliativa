namespace atvd_avaliativa
{
    partial class frmProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUselogado = new System.Windows.Forms.Label();
            this.grbcadastro = new System.Windows.Forms.GroupBox();
            this.grbremover = new System.Windows.Forms.GroupBox();
            this.lblremover = new System.Windows.Forms.Label();
            this.btnremover = new System.Windows.Forms.Button();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.btnCadastra = new System.Windows.Forms.Button();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigodeBarra = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCodigodebarra = new System.Windows.Forms.Label();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.btnSair = new System.Windows.Forms.Button();
            this.grbcadastro.SuspendLayout();
            this.grbremover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUselogado
            // 
            this.lblUselogado.AutoSize = true;
            this.lblUselogado.Location = new System.Drawing.Point(54, 19);
            this.lblUselogado.Name = "lblUselogado";
            this.lblUselogado.Size = new System.Drawing.Size(19, 13);
            this.lblUselogado.TabIndex = 5;
            this.lblUselogado.Text = "....";
            // 
            // grbcadastro
            // 
            this.grbcadastro.Controls.Add(this.btnSair);
            this.grbcadastro.Controls.Add(this.grbremover);
            this.grbcadastro.Controls.Add(this.txtEstoque);
            this.grbcadastro.Controls.Add(this.lblEstoque);
            this.grbcadastro.Controls.Add(this.btnCadastra);
            this.grbcadastro.Controls.Add(this.txtPreco);
            this.grbcadastro.Controls.Add(this.txtNome);
            this.grbcadastro.Controls.Add(this.txtCodigodeBarra);
            this.grbcadastro.Controls.Add(this.lblPreco);
            this.grbcadastro.Controls.Add(this.lblNome);
            this.grbcadastro.Controls.Add(this.lblCodigodebarra);
            this.grbcadastro.Location = new System.Drawing.Point(36, 332);
            this.grbcadastro.Name = "grbcadastro";
            this.grbcadastro.Size = new System.Drawing.Size(729, 307);
            this.grbcadastro.TabIndex = 4;
            this.grbcadastro.TabStop = false;
            this.grbcadastro.Text = "Cadastro";
            // 
            // grbremover
            // 
            this.grbremover.Controls.Add(this.lblremover);
            this.grbremover.Controls.Add(this.btnremover);
            this.grbremover.ForeColor = System.Drawing.Color.Red;
            this.grbremover.Location = new System.Drawing.Point(414, 220);
            this.grbremover.Name = "grbremover";
            this.grbremover.Size = new System.Drawing.Size(309, 65);
            this.grbremover.TabIndex = 12;
            this.grbremover.TabStop = false;
            this.grbremover.Text = "REMOVER";
            // 
            // lblremover
            // 
            this.lblremover.AutoSize = true;
            this.lblremover.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblremover.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblremover.Location = new System.Drawing.Point(6, 34);
            this.lblremover.Name = "lblremover";
            this.lblremover.Size = new System.Drawing.Size(164, 13);
            this.lblremover.TabIndex = 1;
            this.lblremover.Text = "Selecionar um item para remover ";
            // 
            // btnremover
            // 
            this.btnremover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnremover.ForeColor = System.Drawing.Color.Black;
            this.btnremover.Location = new System.Drawing.Point(192, 19);
            this.btnremover.Name = "btnremover";
            this.btnremover.Size = new System.Drawing.Size(100, 38);
            this.btnremover.TabIndex = 0;
            this.btnremover.Text = "REMOVER";
            this.btnremover.UseVisualStyleBackColor = false;
            this.btnremover.Click += new System.EventHandler(this.btnremover_Click);
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(121, 136);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(100, 20);
            this.txtEstoque.TabIndex = 11;
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Location = new System.Drawing.Point(51, 139);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(46, 13);
            this.lblEstoque.TabIndex = 10;
            this.lblEstoque.Text = "Estoque";
            // 
            // btnCadastra
            // 
            this.btnCadastra.Location = new System.Drawing.Point(64, 189);
            this.btnCadastra.Name = "btnCadastra";
            this.btnCadastra.Size = new System.Drawing.Size(137, 31);
            this.btnCadastra.TabIndex = 9;
            this.btnCadastra.Text = "CADASTRAR";
            this.btnCadastra.UseVisualStyleBackColor = true;
            this.btnCadastra.Click += new System.EventHandler(this.btnCadastra_Click);
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(121, 106);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 20);
            this.txtPreco.TabIndex = 7;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(121, 74);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 6;
            // 
            // txtCodigodeBarra
            // 
            this.txtCodigodeBarra.Location = new System.Drawing.Point(121, 39);
            this.txtCodigodeBarra.Name = "txtCodigodeBarra";
            this.txtCodigodeBarra.Size = new System.Drawing.Size(100, 20);
            this.txtCodigodeBarra.TabIndex = 5;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(51, 109);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(35, 13);
            this.lblPreco.TabIndex = 2;
            this.lblPreco.Text = "Preço";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(51, 77);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblCodigodebarra
            // 
            this.lblCodigodebarra.AutoSize = true;
            this.lblCodigodebarra.Location = new System.Drawing.Point(30, 42);
            this.lblCodigodebarra.Name = "lblCodigodebarra";
            this.lblCodigodebarra.Size = new System.Drawing.Size(85, 13);
            this.lblCodigodebarra.TabIndex = 0;
            this.lblCodigodebarra.Text = "Codigo De Barra";
            // 
            // dgvProduto
            // 
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Location = new System.Drawing.Point(36, 38);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.Size = new System.Drawing.Size(729, 288);
            this.dgvProduto.TabIndex = 3;
            this.dgvProduto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduto_CellClick);
            this.dgvProduto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduto_CellContentClick);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(21, 261);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 659);
            this.Controls.Add(this.lblUselogado);
            this.Controls.Add(this.grbcadastro);
            this.Controls.Add(this.dgvProduto);
            this.Name = "frmProduto";
            this.Text = "Produto";
            this.grbcadastro.ResumeLayout(false);
            this.grbcadastro.PerformLayout();
            this.grbremover.ResumeLayout(false);
            this.grbremover.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUselogado;
        private System.Windows.Forms.GroupBox grbcadastro;
        private System.Windows.Forms.GroupBox grbremover;
        private System.Windows.Forms.Label lblremover;
        private System.Windows.Forms.Button btnremover;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.Button btnCadastra;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigodeBarra;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCodigodebarra;
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.Button btnSair;
    }
}