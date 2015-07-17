using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Espatula.Ingredientes
{
    public partial class ver : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MySqlDataReader resultado = Obtener();

            while (resultado.Read())
            {
                TableRow fila = new TableRow();
                
            }

        }

        protected MySqlDataReader Obtener()
        {

            string constr = @"Data Source=localhost; Database=espatula; User ID=root; Password=admin";

            MySqlConnection conection = new MySqlConnection(constr);
            MySqlDataReader reader = null;

            try
            {
                conection.Open();
                string consulta = "SELECT * FROM recetas";


                MySqlCommand comando = new MySqlCommand(consulta, conection);
                reader = comando.ExecuteReader();
                conection.Close();

            }
            catch (Exception e)
            {
                
            }



            return reader;

        }
    }
}