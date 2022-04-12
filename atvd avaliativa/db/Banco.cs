using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atvd_avaliativa.db
{
    internal class Banco
    {
        public SQLiteConnection conexao;
        // Construtor:
        public Banco()
        {
            // Caminho do arquivo:
            var caminho = "banco.sqlite3";
            // String de conexão:
            conexao = new SQLiteConnection("Data Source= " + caminho);
        }
        // Método para conectar
        public void Conectar()
        {
            // Verificar se já não está conectado:
            if (conexao.State != ConnectionState.Open)
            {
                // Conectar
                conexao.Open();
            }
        }
        public void Desconectar()
        {
            // Verificar se já não está desconectado:
            if (conexao.State != ConnectionState.Closed)
            {
                // Desconectar:
                conexao.Close();
            }

        }
    }
}


