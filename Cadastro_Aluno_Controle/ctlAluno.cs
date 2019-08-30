using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using Cadastro_Aluno_Modelo;
using System.Data;

namespace Cadastro_Aluno_Controle
{
    public class ctlAluno
    {
        public bool Cadastrar(string nome, string rg, string cpf)
        {
            string query = "INSERT into tblAluno(nome, rg, cpf) VALUES('" +
            nome + "', '" + rg + "', '" + cpf + "' )";
            OleDbDataReader reader = null;
            OleDbConnection conn = null;

            try
            {
                conn = obterConexao();

                OleDbCommand cmd = new OleDbCommand(query, conn);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    return true;

                }
                fecharConexao(conn);


            }

            catch (Exception ex)
            {
                throw ex;

            }

            finally
            {

                if (conn != null)
                {
                    conn.Close();
                }

            }

            return true;
        }
        public OleDbConnection obterConexao()
        {
            OleDbConnection conn = null;

            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\bruno\CadastroAluno\aluno.mdb"; 

            conn = new OleDbConnection(connectionString);

            if (conn.State == ConnectionState.Closed)
            {

                conn.Open();
                
            }
            return conn;















        }
        public void fecharConexao(OleDbConnection conn)
        {

            if (conn.State == ConnectionState.Open)
            {

                conn.Close();
            }

        }
 }
    
   




}

    