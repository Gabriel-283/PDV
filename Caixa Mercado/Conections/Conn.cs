using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Caixa_Mercado
{
    public class DataBaseProductsConection
    {

        private static string server = @"BIELBERNARD76BE\DB_SOUZA";
        private static string dataBase = "products";
        private static string user = "sa";
        private static string password = "";
        public static string stringConection {

            get { return "Data Source=" + server + "; Integrated Security= true; Initial Catalog=" + dataBase; }

            

        }

    }


    public class DataBaseUserConection
    {
        private static string server = @"BIELBERNARD76BE\DB_SOUZA";
        private static string dataBase = "LoginCaixa";
        private static string user = "sa";
        private static string password = "";
        
        public static string stringConection
        {

            get { return "Data Source=" + server + "; Integrated Security= true; Initial Catalog=" + dataBase; }

        }
    }
}
