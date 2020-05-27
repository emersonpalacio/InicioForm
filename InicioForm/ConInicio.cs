using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicioForm
{
    public class ConInicio
    {


        public DataSet Conections(string cmd)
        {

            SqlConnection con = new SqlConnection(" Data Source=.;Initial Catalog=Administracion;Integrated Security=True");
            con.Open();

            DataSet DS = new DataSet();
            SqlDataAdapter DP = new SqlDataAdapter(cmd, con);
            DP.Fill(DS);

            con.Close();

            return DS;
        }
    }

}
