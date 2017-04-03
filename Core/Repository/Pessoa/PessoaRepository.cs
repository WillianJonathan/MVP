using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Model;
using Core.Model.Pessoa;
using System.Data;
using System.Data.SqlClient;

namespace Core.Repository.Pessoa
{
    public class PessoaRepository : IPessoaRepository
    {

        public void Add(Model.Pessoa.Pessoa item)
        {
            SqlConnection connection = new SqlConnection();

            try
            {
                connection = new SqlConnection(@"Server=(localdb)\MSSQLLocalDb;Initial Catalog=TESTE;Integrated Security=true;");
                string cmdText = "";

                if (item.Id > 0)
                {
                    cmdText = " UPDATE PESSOA SET" +
                              "   Codigo = @Codigo," +
                              "   NomeRazaoSocial = @NomeRazaoSocial" +
                              " WHERE Id = @Id";
                }
                else
                {
                    cmdText = " INSERT INTO PESSOA (" +
                                 "   Codigo," +
                                 "   NomeRazaoSocial) " +
                                 " VALUES (" +
                                 "   @Codigo," +
                                 "   @NomeRazaoSocial)";
                }

                SqlCommand cmd = new SqlCommand(cmdText, connection);

                if (item.Id > 0)
                    cmd.Parameters.AddWithValue("@Id", item.Id);
                cmd.Parameters.AddWithValue("@Codigo", item.Codigo);
                cmd.Parameters.AddWithValue("@NomeRazaoSocial", item.NomeRazaoSocial);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                string erro = "";

                do
                {
                    erro += ex.Message;
                    ex = ex.InnerException;
                } while (ex.InnerException != null);

                throw new Exception(DateTime.Now.ToString() + " - Erro ao tentar adicionar uma pessoa. \n Detalhes: " + erro);
            }
            finally
            {

                if (connection != null && connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }

        public Model.Pessoa.Pessoa Get(int Id)
        {
            if (Id <= 0)
                throw new ArgumentException("Valor de Id inválido");

            Model.Pessoa.Pessoa pessoa = new Model.Pessoa.Pessoa();
            SqlConnection connection = new SqlConnection();

            try
            {
                connection = new SqlConnection(@"Server=(localdb)\MSSQLLocalDb;Initial Catalog=TESTE;Integrated Security=true;");
                string cmdText = " SELECT" +
                                 "   Codigo," +
                                 "   NomeRazaoSocial " +
                                 " FROM PESSOA " +
                                 " WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(cmdText, connection);

                cmd.Parameters.AddWithValue("@Id", Id);

                DataTable dt = new DataTable();

                connection.Open();
                dt.Load(cmd.ExecuteReader());
                connection.Close();

                if (dt.Rows.Count > 0)
                {
                    pessoa.Id = Id;
                    pessoa.Codigo = dt.Rows[0][0].ToString();
                    pessoa.NomeRazaoSocial = dt.Rows[0][1].ToString();
                }

                return pessoa;
            }
            catch (Exception ex)
            {
                string erro = "";

                do
                {
                    erro += ex.Message;
                    ex = ex.InnerException;
                } while (ex.InnerException != null);

                throw new Exception(DateTime.Now.ToString() + " - Erro ao tentar retornar uma pessoa. \n Detalhes: " + erro);
            }
            finally
            {

                if (connection != null && connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }

            }
        }

        public List<Model.Pessoa.Pessoa> GetAll()
        {
            List<Model.Pessoa.Pessoa> pessoas = new List<Model.Pessoa.Pessoa>();
            SqlConnection connection = new SqlConnection();

            try
            {
                connection = new SqlConnection(@"Server=(localdb)\MSSQLLocalDb;Initial Catalog=TESTE;Integrated Security=true;");
                string cmdText = " SELECT" +
                                 "   Id," +
                                 "   Codigo," +
                                 "   NomeRazaoSocial " +
                                 " FROM PESSOA ";

                SqlCommand cmd = new SqlCommand(cmdText, connection);

                DataTable dt = new DataTable();

                connection.Open();
                dt.Load(cmd.ExecuteReader());
                connection.Close();

                foreach (DataRow row in dt.Rows)
                {
                    Model.Pessoa.Pessoa pessoa = new Model.Pessoa.Pessoa()
                    {
                        Id = Convert.ToInt32(row.ItemArray[0]),
                        Codigo = row.ItemArray[1].ToString(),
                        NomeRazaoSocial = row.ItemArray[2].ToString()
                    };

                    pessoas.Add(pessoa);
                }

                return pessoas;
            }
            catch (Exception ex)
            {
                string erro = "";

                do
                {
                    erro += ex.Message;
                    ex = ex.InnerException;
                } while (ex.InnerException != null);

                throw new Exception(DateTime.Now.ToString() + " - Erro ao tentar retornar uma lista de pessoas. \n Detalhes: " + erro);
            }
            finally
            {

                if (connection != null && connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }

            }
        }

        public void Remove(Model.Pessoa.Pessoa item)
        {
            SqlConnection connection = new SqlConnection();

            try
            {
                connection = new SqlConnection(@"Server=(localdb)\MSSQLLocalDb;Initial Catalog=TESTE;Integrated Security=true;");
                string cmdText = " DELETE" +
                                 " FROM PESSOA " +
                                 " WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(cmdText, connection);

                cmd.Parameters.AddWithValue("@Id", item.Id);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                string erro = "";

                do
                {
                    erro += ex.Message;
                    ex = ex.InnerException;
                } while (ex.InnerException != null);

                throw new Exception(DateTime.Now.ToString() + " - Erro ao tentar deletar uma pessoa. \n Detalhes: " + erro);
            }
            finally
            {

                if (connection != null && connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }

            }
        }
    }
}
