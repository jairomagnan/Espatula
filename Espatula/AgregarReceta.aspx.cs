using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Text;

namespace Espatula {
    public partial class WebForm1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

            if (!IsPostBack) {
                

                try {
                    string constr = "Data Source=localhost; port=3306; Initial Catalog=ci2454_eb04539;User Id=eb04539;password=eb04539";// ConfigurationManager.ConnectionStrings["ci2454_eb04539ConnectionString"].ConnectionString;

                    using (MySqlConnection con = new MySqlConnection(constr)) {
                        using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM Categorias")) {
                            using (MySqlDataAdapter sda = new MySqlDataAdapter()) {
                                cmd.Connection = con;
                                sda.SelectCommand = cmd;
                                using (DataSet ds = new DataSet()) {
                                    sda.Fill(ds);

                                    categorias.DataSource = ds;
                                    categorias.DataTextField = "nombre";
                                    categorias.DataValueField = "nombre";
                                    categorias.DataBind();
                                }
                                
                            }
                        }
                    }
                } catch (NullReferenceException ex) {  }
            }
           }

        protected void submitMethod(object sender, EventArgs e) {

            try {
                string constr = "Data Source=localhost; port=3306; Initial Catalog=ci2454_eb04539;User Id=eb04539;password=eb04539";// ConfigurationManager.ConnectionStrings["ci2454_eb04539ConnectionString"].ConnectionString;
            
                    MySqlConnection con = new MySqlConnection(constr);

                    con.Open();

                    string[] cantidad = Request.Form.GetValues("cantidad");
                    string[] medida = Request.Form.GetValues("medida");
                    string[] ingrediente = Request.Form.GetValues("ingrediente");

                    

                    MySqlCommand cmd = new MySqlCommand("INSERT INTO recetas (nombre, instrucciones, creador, imagen, tips, categoria) " + "VALUES('"+ nombreReceta.Value + "','"+ instrucciones.Value + "','"+ "1" + "','" + imagen.Value + "','"+ tips.Value +"','"+ categorias.Value + "')", con);
    
                    
                    cmd.ExecuteReader();

                    con.Close();

                    
                   

                    con.Open();

                    MySqlCommand cmd2 = new MySqlCommand("SELECT * FROM recetas Where imagen='"+imagen.Value+"'", con);
                    cmd2.Connection = con;

                    String idReceta = Convert.ToString(cmd2.ExecuteScalar());
                    System.Diagnostics.Debug.WriteLine(idReceta);

                    con.Close();

                    con.Open();

                    for (int i = 0; i < ingrediente.Length; ++i) {

                        MySqlCommand cmd3 = new MySqlCommand("INSERT INTO ingredientes (nombre) " + "VALUES('" + ingrediente[i] + "')", con);
                        cmd3.Connection = con;

                        cmd3.ExecuteReader();
                    }
                    con.Close();

                //    con.Open();

               //     for (int i = 0; i < ingrediente.Length;++i) {
                        
               //         MySqlCommand cmd3 = new MySqlCommand("INSERT INTO rec_ing (receta, ingrediente, cantidad, unidadDeMedida) " + "VALUES('" + idReceta + "','" + ingrediente[i] + "','" + cantidad[i] + "','" + medida[i] + "')", con);


               //         cmd3.ExecuteReader();
              //     }

              //      con.Close();
                
            } catch (NullReferenceException ex) {
                System.Diagnostics.Debug.WriteLine("ERROR");
            }

            
        }
    }
}