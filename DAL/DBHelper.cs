using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
namespace DAL
{
    public class DBHelper
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection("Data Source=DESKTOP-F550SAA\\SQLEXPRESS;Initial Catalog=MyDB;Integrated Security=True;Trust Server Certificate=True");
        }
    }
}
