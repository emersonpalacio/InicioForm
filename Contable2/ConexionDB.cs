using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contable2
{
    public class ConexionDB
    {

        public DataSet conexion(string data)
        {
            SqlConnection con = new SqlConnection("Data Source =.;Initial Catalog = Administracion; Integrated Security = True");
            con.Open();

            DataSet DS = new DataSet();
            SqlDataAdapter DA = new SqlDataAdapter(data, con);
            DA.Fill(DS);
            con.Close();
            return DS;
        }
    }
}
