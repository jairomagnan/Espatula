using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using MySql.Data.MySqlClient;

namespace Espatula.Ingredientes
{
    public partial class agregar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected int Guardar()
        {
            int ret = 0;

            string constr = @"Data Source=localhost; Database=espatula; User ID=root; Password=admin";
            
            MySqlConnection conection = new MySqlConnection(constr);

            try
            {
                conection.Open();
                string consulta = "INSERT INTO ingredientes (nombre, descripcion, imagen) VALUES ('" + txtNombre.Text + "' , '" + txtDesc.Text + "' , '" + txtImagen.Text + "')";


                MySqlCommand comando = new MySqlCommand(consulta, conection);
                comando.ExecuteNonQuery();
                conection.Close();
            }
            catch (Exception e)
            {
                ret = 1;
                lblImg.Text = e.Message;
            }

            

            return ret;

        }


        protected void btnImagen_Click(object sender, EventArgs e)
        {
            String url = txtImagen.Text;


            if(!url.Equals("")){
                imgDesc.ImageUrl = url;
            }

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Guardar()==1)
            {

            }
        }

    }
}