using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atvd_avaliativa.db
{
    public class ProdutoDAO
    {
        public static DataTable listarTudo()
        {
            // Instanciar o classe de conexão com o bd:
            Banco objBanco = new Banco();
            // Criar a "tabela" que será preenchida com os dados do BD:
            DataTable tabela = new DataTable();
            // Conectar com o banco:
            objBanco.Conectar();
            // Criar um objeto do tipo SQLiteCommand:
            var cmd = objBanco.conexao.CreateCommand();
            // Qual comando SQL será executado:
            cmd.CommandText = "SELECT p.CodigodeBarra, p.Nome, p.Preco, p.Estoque, u.Nome  FROM Produto  AS p INNER JOIN Usuario AS u ON  p.Responsavelcadastro = u.Email";      
            // Executar e obter os dados da consulta em um obj SQLiteDA:
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd.CommandText, objBanco.conexao);
            // Preencher uma "tabela" com os dados retornados do BD:
            da.Fill(tabela);
            // Desconectar:
            objBanco.Desconectar();
            // Devolver a tabela preenchida para quem chamar este método:
            return tabela;
        }
        public static void Remover(string CodigodeBarra)
        {
            Banco objBanco = new Banco();
            objBanco.Conectar();
            var cmd = objBanco.conexao.CreateCommand();
            cmd.CommandText = "DELETE FROM Produto WHERE CodigodeBarra = @CodigodeBarra";
            // Substituir os @ por valores:
            cmd.Parameters.AddWithValue("CodigodeBarra", CodigodeBarra);
            // Executar:
            cmd.ExecuteNonQuery();
            // Desconectar:
            objBanco.Desconectar();
        }
        public static void Cadastro(Model.Produto Produto, string email)
        {
            // Obter as infos da pessoa que está cadastrando:
            //var usuarios = db.UsuarioDAO.buscarPorEmail(email);
            //var ResponsavelCadastro = usuarios.Rows[0]["Email"].ToString();

            // Comandinhos para efetuar o cadastro:
            Banco objBanco = new Banco();
            objBanco.Conectar();
            var cmd = objBanco.conexao.CreateCommand();
            cmd.CommandText = "INSERT INTO Produto (CodigodeBarra, Nome, Preco, Estoque, Responsavelcadastro) VALUES (@CodigodeBarra, @Nome, @Preco, @Estoque, @ResponsavelCadastro)";
            // Substituir os @ por valores:
            cmd.Parameters.AddWithValue("@CodigodeBarra", Produto.CodigodeBarra);
            cmd.Parameters.AddWithValue("@Nome", Produto.Nome);
            cmd.Parameters.AddWithValue("@Preco", Produto.Preco);
            cmd.Parameters.AddWithValue("@Estoque", Produto.Estoque);
            cmd.Parameters.AddWithValue("@ResponsavelCadastro",email);
            // Executar:
            cmd.ExecuteNonQuery();
            // Desconectar:
            objBanco.Desconectar();
        }
    }
}
