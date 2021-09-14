using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaApi
{
    public class ConnectionStrings
    {
        public static string Conexao
        {
            get
            {
                return @"Data Source=.\VINICIUSMSSQL;Initial Catalog=ControleAgenda;Integrated Security=True;User ID=sa;Password=vinicius@290993;";
            }
        }
    }
}
