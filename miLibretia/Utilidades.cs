using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miLibretia
{
    public class Utilidades
    {

        public static DataSet ejecutar(string cmd)
        {
            SqlConnection con = new SqlConnection( " Data Source=DESKTOP-KKLB025\SQLEXPRESS;Initial Catalog=EXPI_PID;Persist Security Info=True;User ID=sa;Password=A1b2c3d4e5f67#");
            con.Open();

            DataSet ds = new DataSet();
            SqlDataAdapter dp = new SqlDataAdapter(cmd , con);
            dp.Fill(ds);

            con.Close();

            return ds;

        }
    }
}
