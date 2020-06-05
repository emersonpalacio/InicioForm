using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicioForm
{
    public class Conexion
    {
        public DataSet Con(string cmd)
        {
            SqlConnection Conexion = new SqlConnection("Data Source=.;Initial Catalog=Administracion;Integrated Security=True");
            Conexion.Open();//conexion

            DataSet DS = new DataSet(); // mitable 

            SqlDataAdapter DA = new SqlDataAdapter(cmd, Conexion);
            DA.Fill(DS);
            Conexion.Close();
            return DS;
        }
    }
}
