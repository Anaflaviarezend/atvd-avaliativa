using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace atvd_avaliativa.db
{

    public static class UsuarioDAO
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
            cmd.CommandText = "SELECT idUsuario AS ID, Nome, Email, Telefone, Funcao FROM Usuarios";
            // Executar e obter os dados da consulta em um obj SQLiteDA:
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd.CommandText, objBanco.conexao);
            // Preencher uma "tabela" com os dados retornados do BD:
            da.Fill(tabela);
            // Desconectar:
            objBanco.Desconectar();
            // Devolver a tabela preenchida para quem chamar este método:
            return tabela;
        }
        public static DataTable buscarPorEmail(string email)
        {
            //Buscar por Email:
            Banco objBanco = new Banco();
            DataTable tabela = new DataTable();
            objBanco.Conectar();
            var cmd = objBanco.conexao.CreateCommand();
            cmd.CommandText = "SELECT Nome, Email, Telefone, Funcao FROM Usuario WHERE Email = @email";
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd.CommandText, objBanco.conexao);
            da.SelectCommand.Parameters.AddWithValue("@email", email);
            da.Fill(tabela);
            objBanco.Desconectar();
            return tabela;
        }

        public static void Cadastro(Model.Usuario u)
        {
            //  Efetuando cadastro no banco de dados:
            Banco objBanco = new Banco();
            objBanco.Conectar();
            var cmd = objBanco.conexao.CreateCommand();
            cmd.CommandText = "INSERT INTO Usuario (Email, Nome, Telefone, Funcao, Senha, DataDeNasc) VALUES (@email, @nome, @telefone, @funcao, @senha, @DataDeNasc)";
            // Substituir os @ por valores:
            cmd.Parameters.AddWithValue("@email", u.Email);
            cmd.Parameters.AddWithValue("@nome", u.Nome);
            cmd.Parameters.AddWithValue("@telefone", u.Telefone);
            cmd.Parameters.AddWithValue("@funcao", u.Funcao);
            cmd.Parameters.AddWithValue("@senha", u.Senha);
            cmd.Parameters.AddWithValue("@DataDeNasc", u.DataDeNasc);

            // Executar:
            cmd.ExecuteNonQuery();
            // Desconectar:
            objBanco.Desconectar();
        }


        public static bool login(Model.Usuario u)
        {
            // Fazendo o login:
            // Instanciar o classe de conexão com o bd:
            Banco objBanco = new Banco();
            // Criar a "tabela" que será preenchida com os dados do BD:
            DataTable tabela = new DataTable();
            // Conectar com o banco:
            objBanco.Conectar();
            // Criar um objeto do tipo SQLiteCommand:
            var cmd = objBanco.conexao.CreateCommand();
            // Qual comando SQL será executado:
            cmd.CommandText = "SELECT Email, Senha FROM Usuario WHERE Email = @email";
            //cmd.Parameters.AddWithValue("@email", u.Email);
            // Executar e obter os dados da consulta em um obj SQLiteDA:
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd.CommandText, objBanco.conexao);
            da.SelectCommand.Parameters.AddWithValue("@email", u.Email);
            // Preencher uma "tabela" com os dados retornados do BD:
            da.Fill(tabela);
            // Desconectar:
            objBanco.Desconectar();

            // Tratamento de erro:
            // verificar se foram retornados registros do banco:
            if (tabela.Rows.Count > 0)
            {
                // Armazenar em variáveis o usuário e senha vindos do BD:
                var email = tabela.Rows[0]["Email"].ToString();
                var senha = tabela.Rows[0]["Senha"].ToString();
                // Verificar se a senha e usuarios do banco coincidem com os informados
                // pelo usuário.
                if (u.Email == email && u.Senha == senha)
                {
                    return true;
                }
                else
                {
                    // Devolver false caso senha || usuario incorretos:
                    return false;
                }
            }
            else
            {
                return false;
            }

        }
    }
} 




