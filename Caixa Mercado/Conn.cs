using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Caixa_Mercado
{
    public class Conn
    {

        private static string Server = @"BIELBERNARD76BE\DB_SOUZA";
        private static string DataBase = "Produtos";
        private static string User = "sa";
        private static string password = "";
        public static string StrCon {

            get { return "Data Source=" + Server + "; Integrated Security= true; Initial Catalog=" + DataBase; }

            

        }

    }


    public class Conn_user 
    {
        private static string Server = @"BIELBERNARD76BE\DB_SOUZA";
        private static string DataBase = "LoginCaixa";
        private static string User = "sa";
        private static string password = "";
        
        public static string StrCon
        {

            get { return "Data Source=" + Server + "; Integrated Security= true; Initial Catalog=" + DataBase; }

        }
    }
}
