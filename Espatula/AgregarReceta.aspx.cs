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
                        using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM Categorias"), cmd2 = new MySqlCommand("SELECT * FROM ingredientes")) {
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
                                cmd2.Connection = con;
                                sda.SelectCommand = cmd2;
                                using (DataSet ds2 = new DataSet()) {
                                    sda.Fill(ds2);

                                    ingredientes.DataSource = ds2;
                                    ingredientes.DataTextField = "nombre";
                                    ingredientes.DataValueField = "nombre";
                                    ingredientes.DataBind();
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
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO recetas (nombre, instrucciones, creador, imagen, tips, categoria) " + "VALUES('"+ nombreReceta.Value + "','"+ instrucciones.Value + "','"+ "1" + "','" + imagen.Value + "','"+ tips.Value +"','"+ categorias.Value + "')", con);
    
                    
                    cmd.ExecuteReader();

                    con.Close();
                            
                
            } catch (NullReferenceException ex) {
                System.Diagnostics.Debug.WriteLine("ERROR");
            }
        }
    }
}