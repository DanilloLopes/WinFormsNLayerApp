using Database.Conexoes;
using Microsoft.Data.SqlClient;
using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Database.Repositorios
{
    public class CargoRepository
    {
        public bool Inserir(Cargo cargo)
        {
            try
            {
                var sql = @"INSERT INTO [dbo].[Cargo]
               ([Nome]
               ,[Status]
               ,[CriadoEm]
               ,[CriadoPor]
               ,[AlteradoEm]
               ,[AlteradoPor])
            VALUES
               (@nome,
                @status,
                @criadoEm,
                @criadoPor,
                @alteradoEm,
                @alteradoPor)";

                using (var connection = new SqlConnection(SqlServer.StrConexao()))
                {
                    connection.Open();
                    var cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@nome", cargo.Nome);
                    cmd.Parameters.AddWithValue("@status", cargo.Status);
                    cmd.Parameters.AddWithValue("@criadoEm", cargo.CriadoEm);
                    cmd.Parameters.AddWithValue("@criadoPor", cargo.CriadoPor);
                    cmd.Parameters.AddWithValue("@alteradoEm", cargo.AlteradoEm);
                    cmd.Parameters.AddWithValue("@alteradoPor", cargo.AlteradoPor);
                    var reposta = cmd.ExecuteNonQuery();
                    connection.Close();
                    return reposta == 1;

                }
            }
            catch(Exception ex) 
            {
                throw ex;
            }
        }
        
        public bool Atualizar(Cargo cargo, int id)
        {
            try
            {
                var sql = @"UPDATE [dbo].[Cargo]
                           SET [Nome] = @nome
                              ,[Status] = @status
                              ,[AlteradoEm] = @alteradoEm
                              ,[AlteradoPor] = @alteradoPor
                         WHERE Id = @id";

                using (var connection = new SqlConnection(SqlServer.StrConexao()))
                {
                    connection.Open();
                    var cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@nome", cargo.Nome);
                    cmd.Parameters.AddWithValue("@status", cargo.Status);
                    cmd.Parameters.AddWithValue("@alteradoEm", cargo.AlteradoEm);
                    cmd.Parameters.AddWithValue("@alteradoPor", cargo.AlteradoPor);
                    cmd.Parameters.AddWithValue("@id", id);

                    var reposta = cmd.ExecuteNonQuery();
                    connection.Close();
                    return reposta == 1;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Deletar(int cargoId)
        {
            try
            {
                var sql = @"DELETE FROM [dbo].[Cargo]
                          WHERE Id = @Id";

                using (var connection = new SqlConnection(SqlServer.StrConexao()))
                {
                    connection.Open();
                    var cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@Id", cargoId);

                    var resposta = cmd.ExecuteNonQuery();
                    connection.Close();
                    return resposta == 1;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ObterTodos()
        {
            var sql = @"SELECT [Id]
                      ,[Nome]
                      ,[Status]
                      ,[AlteradoEm]
                  FROM [dbo].[Cargo]";

            SqlDataAdapter dataAdapter = null;
            var dataTable = new DataTable();
            try
            {
                using (var connection = new SqlConnection(SqlServer.StrConexao()))
                {
                    connection.Open();
                    var cmd = connection.CreateCommand();
                    
                    cmd.CommandText = sql;
                    
                    dataAdapter = new SqlDataAdapter(sql, connection);
                    dataAdapter.Fill(dataTable);
                    connection.Close();
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<string> Complemento(string cargo)
        {
            var sql = @"SELECT [Nome] FROM [dbo].[Cargo]";

            try
            {
                using (var connection = new SqlConnection(SqlServer.StrConexao()))
                {
                    connection.Open();
                    SqlCommand com = new SqlCommand(sql, connection);

                    SqlDataReader reader = com.ExecuteReader();

                    var lista = new List<string>();

                    while (reader.Read())
                    {
                        lista.Add(reader.GetString(0).Trim());
                    }

                    return lista;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
