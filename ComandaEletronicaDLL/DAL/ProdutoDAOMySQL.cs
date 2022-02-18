using ComandaEletronicaDLL.BLL;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace ComandaEletronicaDLL.DAL
{
    class ProdutoDAOMySQL : IProdutoDAO
    {
        private ConexaoMySQL conexao;

        public ProdutoDAOMySQL()
        {
            conexao = new ConexaoMySQL();
        }

        public bool Inserir(Produto p)
        {

            String sql = "INSERT INTO PRODUTO (CODIGO, DESCRICAO, PRECO) " +
                "VALUES (" + p.Codigo + ", '" + p.Descricao + "', " + p.Preco.ToString().Replace(",", ".") + ")";
            try
            {
                conexao.ExecutarSemConsulta(sql);
                return true;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Erro de Conexao MySQL: " + e);
            }
            return false;
        }

        public bool Atualizar(Produto p)
        {
            String sql = "UPDATE PRODUTO SET " +
                    "DESCRICAO = '" + p.Descricao + "', " +
                    "PRECO = " + p.Preco.ToString().Replace(",", ".") +
                    " WHERE CODIGO = " + p.Codigo;
            try
            {
                conexao.ExecutarSemConsulta(sql);
                return true;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Erro de Conexao MySQL: " + e);
            }
            return false;
        }

        public bool Excluir(int codigo)
        {
            String sql = "DELETE FROM PRODUTO WHERE CODIGO = " + codigo;
            try
            {
                conexao.ExecutarSemConsulta(sql);
                return true;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Erro de Conexao MySQL: " + e);
            }
            return false;
        }

        public DataSet Listar()
        {
            // criar uma instancia de DataSet
            DataSet produtos = new DataSet();
            // cria um DataTable para ser adicionado ao DataSet
            DataTable tb = new DataTable("Produto");
            tb.Columns.Add("Codigo", typeof(Int32));
            tb.Columns.Add("Descricao", typeof(string));
            tb.Columns.Add("Preco", typeof(Double));
            produtos.Tables.Add(tb);

            // consulta o banco de dados, o retorno é um objeto  MySqlDataReader
            string consulta = "SELECT CODIGO, DESCRICAO, PRECO FROM PRODUTO ORDER BY DESCRICAO";
            MySqlDataReader reader = conexao.ExecutarConsulta(consulta);
            // pecorre o objeto DataReader lendo linha a linha
            while (reader.Read())
            {
                // obtém os dados da linha atual
                DataRow linha = produtos.Tables[0].NewRow();
                linha["Codigo"] = Convert.ToInt32(reader["codigo"]);
                linha["Descricao"] = reader["descricao"].ToString();
                linha["Preco"] = Convert.ToDouble(reader["preco"]);
                // adiciona a nova linha a tabela
                produtos.Tables[0].Rows.Add(linha);
            }
            conexao.FecharConexao();
            return produtos;
        }
    }
}