using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Espatula
{

    public partial class WebForm1 : System.Web.UI.Page
    {

        StringBuilder datos = new StringBuilder();

        StringBuilder nombre = new StringBuilder();
        StringBuilder ingredientes = new StringBuilder();
        StringBuilder instrucciones = new StringBuilder();
        string imagen;
        int valor;

        protected void Page_Load(object sender, EventArgs e)
        {

            valor = Convert.ToInt32(Request.QueryString["id"]);
            nombre.Append("<h2> ");
            instrucciones.Append("<h3> Instrucciones: </h3> <p class=\"lead\"> ");
            ingredientes.Append("<h3> Ingredientes: </h3> <p class=\"lead\"> ");
            //myLabel.Text = " "+valor;

            if (!Page.IsPostBack)
            {

                DataTable dt = this.GetData();
                int i = 0;
                //Building the Data rows.
                foreach (DataRow row in dt.Rows)
                {

                    foreach (DataColumn column in dt.Columns)
                    {

                        switch (i)
                        {
                            case 0:
                                nombre.Append(row[column.ColumnName]);
                                break;
                            case 1:
                                instrucciones.Append(row[column.ColumnName]);
                                break;
                            case 2:
                                imagen = Convert.ToString(row[column.ColumnName]);
                                break;
                            default:
                                if (i == 3 || i==11 || i==19 || i==27 || i==35)
                                {
                                    ingredientes.Append(row[column.ColumnName] + "<br />");
                                }
                                break;

                        }

                            ++i;
                    }

                }

                //Table end.
                nombre.Append("</h2>");
                instrucciones.Append("</p>");
                instrucciones = instrucciones.Replace("-"," <br /> -");
                
                string imagenACargar = "<img src=\" "+imagen+" \" alt=\"empanadas\">";
                datos.Append(nombre);
                datos.Append(imagenACargar);
                datos.Append(ingredientes);
                datos.Append(instrucciones);
                //Append the HTML string to Placeholder.
                PlaceHolder1.Controls.Add(new Literal { Text = datos.ToString() });
            }
        }

        private DataTable GetData()
        {

            try
            {
                string constr = ConfigurationManager.ConnectionStrings["ci2454_eb04539ConnectionString"].ConnectionString;
                //string constr = @"Data Source=localhost; Database=espatula; User ID=root; Password=admin";
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT r.nombre,r.instrucciones,r.imagen,i.nombre,ri.cantidad,ri.unidadDeMedida,r.tips,r.calificacion "+
                                                               "FROM Recetas r,Ingredientes i,Rec_Ing ri "+
                                                               "WHERE r.id= "+valor+" AND r.id = ri.receta AND i.id = ri.ingrediente"))
                    {
                        using (MySqlDataAdapter sda = new MySqlDataAdapter())
                        {
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                return dt;
                            }
                        }
                    }
                }
            }
            catch (NullReferenceException e) { return null; }




        }


    }


}
