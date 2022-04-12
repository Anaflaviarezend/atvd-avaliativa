using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atvd_avaliativa
{
    
    public partial class frmProduto : Form
    {
        string idCodigodeBarra, emailUserLogado;
        string Nome;
        public frmProduto(string Email)
        {
            // Verificando qual usuário está logado:
            InitializeComponent();
            dgvProduto.DataSource = db.ProdutoDAO.listarTudo();
            this.emailUserLogado = Email;
            lblUselogado.Text = "Você está logado como " + emailUserLogado;
        }

        private void btnCadastra_Click(object sender, EventArgs e)
        {
            // Verificando se todos os campos estão preenchidos e cadastrando produto:
            if(txtCodigodeBarra.Text == "" || txtNome.Text == "" || txtEstoque.Text == "" || txtPreco.Text == "")
            {
                MessageBox.Show("Preencha todos os Campos.");
            }
            else
            {
                var Produto = new Model.Produto();
                Produto.CodigodeBarra = txtCodigodeBarra.Text;
                Produto.Nome = txtNome.Text;
                Produto.Preco = double.Parse(txtPreco.Text);
                Produto.Estoque = int.Parse(txtEstoque.Text);

                // Executar o método de cadastro:
                db.ProdutoDAO.Cadastro(Produto, emailUserLogado);
                // Atualizar o DGV:
                dgvProduto.DataSource = db.ProdutoDAO.listarTudo();
                // Limpar os campos:
                txtCodigodeBarra.Clear();
                txtNome.Clear();
                txtPreco.Clear();
                txtEstoque.Clear();

                // Mostrar mensagem de sucesso!
                MessageBox.Show("Produto cadastrado com sucesso!");
            }
           
        }
        public void btnremover_Click(object sender, EventArgs e)
        {
            // Removendo Produto:

            if (Nome!= null && idCodigodeBarra != null)
            {
                var r = MessageBox.Show("Tem certeza que deseja remover " +Nome + "?", "AVISO!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (r == DialogResult.Yes)
                {
                    // Remover:
                    db.ProdutoDAO.Remover(idCodigodeBarra);
                    // Atualizar o dgv:
                    dgvProduto.DataSource = db.ProdutoDAO.listarTudo();
                    MessageBox.Show("Item removido com sucesso!", "SUCESSO");
                    // Retornar itens do form ao conteúdo original:
                    lblremover.Text = "Selecione um item para remover.";
                    Nome= null;
                    idCodigodeBarra = null;

                }
                else
                {
                    MessageBox.Show("Opa! O Produto não foi removido!");
                }
            }
            else
            {
                MessageBox.Show("Selecione um Produto antes de clicar em REMOVER!");
            }
        }

        private void dgvProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Selecionando Produto:

            // obter o número da linha da célula selecionada:
            var numLinha =dgvProduto.CurrentCell.RowIndex;
            // Armazenar a linha em uma variavel:
            var linha = dgvProduto.Rows[numLinha];
            // Mudar o lblSelecionado para as infos do item selecionado:
            // codigodebarra - nome: "1245454 - produto"
            idCodigodeBarra = linha.Cells[0].Value.ToString();
            Nome = linha.Cells[1].Value.ToString();
            lblremover.Text = idCodigodeBarra + " - " + Nome;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            // Sair:

            this.Close();   
        }

        private void dgvProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
 }


