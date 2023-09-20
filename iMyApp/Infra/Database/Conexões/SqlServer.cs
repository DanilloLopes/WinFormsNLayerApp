using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Conexoes
{
    /// <summary>
    /// A <c>SqlServer</c> é uma class estática com a string de conexão com SqlServer
    /// </summary>
    internal class SqlServer
    {
        /// <summary>
        /// Metodo que <c>StrConexao()</c> retorna a string de conexão sql
        /// </summary>
        /// <returns>string: ConnectionString</returns>
        internal static string StrConexao()
        {
            return @"Data Source=.\SQLEXPRESS;Initial Catalog=iMyApp;User ID=sa;Password=sql2022; Trusted_Connection=False; TrustServerCertificate=True;";
        }

    }
}
