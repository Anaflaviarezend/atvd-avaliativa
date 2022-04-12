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
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grbCadastro_Enter(object sender, EventArgs e)
        {

        }

        private void pibImagem_Click(object sender, EventArgs e)
        {

        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Verificação se todos os campos estão preenchidos e Verificação de Senhas:

            if (txtNome.Text == "" || txtEmail.Text == "" || txtSenha1.Text == "" || cmbFuncao.Text == "" || txtTelefone.Text == "" || MtxtDatadeNasc.Text == "" )
            {
                MessageBox.Show("Preencha todos os Campos.");

            }
            else
            {
                

                if (txtSenha1.Text != txtSenha2.Text)
                {
                    MessageBox.Show("As senhas não conferem!");
                    txtSenha1.BackColor = Color.Red;
                    txtSenha2.BackColor = Color.Red;
                }
                else
                {
                    var novoUsuario = new Model.Usuario();
                    novoUsuario.Nome = txtNome.Text;
                    novoUsuario.Email = txtEmail.Text;
                    novoUsuario.Senha = EasyEncryption.SHA.ComputeSHA256Hash(txtSenha1.Text);
                    novoUsuario.Funcao = cmbFuncao.Text;
                    novoUsuario.Telefone = txtTelefone.Text;
                    novoUsuario.DataDeNasc = MtxtDatadeNasc.Text;

                    db.UsuarioDAO.Cadastro(novoUsuario);
                    MessageBox.Show("Usuário cadastrado com sucesso!");
                    // Resetar os campos:
                    txtNome.Text = "";
                    txtEmail.Text = "";
                    txtSenha1.Text = "";
                    txtSenha2.Text = "";
                    cmbFuncao.SelectedIndex = -1;
                    txtTelefone.Text = "";
                    MtxtDatadeNasc.Text = "";
                    // retornar as cores originais dos campos de senha:
                    txtSenha1.BackColor = Color.White;
                    txtSenha2.BackColor = Color.White;
                    this.Close();
                }
            }
           

           
        }

        private void cmbFuncao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}





