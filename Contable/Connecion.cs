using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicioForm
{
    public class Connecion
    {
        public DataSet Data(string cmd)
        {
            SqlConnection con = new SqlConnection("Data Source =.;Initial Catalog = Administracion; Integrated Security = True");
            con.Open(); 
            DataSet DS = new DataSet();
            SqlDataAdapter DA = new SqlDataAdapter(cmd, con);
            DA.Fill(DS);
            con.Close();
            return DS;
        }
    }

}
