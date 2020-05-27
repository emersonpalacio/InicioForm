using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiConection
{
    public class Conex
    {
        public static System.Data.DataSet Conections(string cmd)
        {

            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(" Data Source=.;Initial Catalog=Administracion;Integrated Security=True");
            con.Open();

            System.Data.DataSet DS = new System.Data.DataSet();
            System.Data.SqlClient.SqlDataAdapter DP = new System.Data.SqlClient.SqlDataAdapter(cmd, con);
            DP.Fill(DS);

            con.Close();

            return DS;
        }

    }
}
