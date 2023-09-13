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
            var stringConexao = SqlServer.StrConexao();

            var sqlConnection = new SqlConnection(stringConexao);

            sqlConnection.Open();

            var sql = @"INSERT INTO [dbo].[Cargo]
           ([Nome]
           ,[Status]
           ,[CriadoEm]
           ,[CriadoPor]
           ,[AlteradoEm]
           ,[AlteradoPor])
            0VALUES
           (@nome,
            @status,
            @criadoEm,
            @criadoPor,
            @alteradoEm,
            @alteradoPor)";

            var cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@nome", cargo.Nome);
            cmd.Parameters.AddWithValue("@status", cargo.Status);
            cmd.Parameters.AddWithValue("@criadoEm", cargo.CriadoEm);
            cmd.Parameters.AddWithValue("@criadoPor", cargo.CriadoPor);
            cmd.Parameters.AddWithValue("@alteradoEm", cargo.AlteradoEm);
            cmd.Parameters.AddWithValue("@alteradoPor", cargo.AlteradoPor);

            

            sqlConnection.Close();

            return true;
        }
        
        public bool Atualizar(Cargo cargo)
        {
            return true;
        }

        public bool Deletar(int cargoId)
        {
            return false;
        }

        public DataTable ObterTodos(int cargoId)
        {
            DataTable dt = new DataTable();
            return dt;
        }
    }
}
