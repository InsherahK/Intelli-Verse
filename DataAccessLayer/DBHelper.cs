using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DataAccessLayer
{
    public class DBHelper
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-M6J3M4A\\SQLEXPRESS;Initial Catalog=project;Integrated Security=True");
            return con;
        }
    }
}







