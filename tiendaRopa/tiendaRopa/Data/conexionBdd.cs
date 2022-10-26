using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace tiendaRopa.Data
{
    class conexionBdd
    {
        public SqlConnection conexion()
        {
            SqlConnection cx = new SqlConnection("SERVER=LAPTOP-BMEUKCRG; DATABASE=BDTIENDA; integrated security=true");
            cx.Open();
            return cx;
        }

    }
}
