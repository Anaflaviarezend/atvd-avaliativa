using atvd_avaliativa.Model;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            // Cadastrar um Usuário:

            // Instanciar usuario:
            var u = new Model.Usuario();
            // Receber os valores do form:
            u.Email = txtEmail.Text;
            u.Senha = EasyEncryption.SHA.ComputeSHA256Hash(txtSenha.Text);
            // Será necessário implementar o método .logar
            if (db.UsuarioDAO.login(u))
            {
                // Instanciar um objeto da janela Principal:
                var frmPrincipal = new frmProduto(u.Email);
                // ocultar a janela atual:
                this.Hide();

                // Mostrar a janela principal:
                frmPrincipal.ShowDialog();

                // Mostrar novamente a janela de login:
                this.Show();
            }
            else
            {
                MessageBox.Show("Usuario ou senhas inválidos.");
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var frmCadastro = new frmCadastro();
            frmCadastro.ShowDialog();
        }
    }
}
