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

                using (MySqlConnection con = new MySqlConnection(constr)) {
                    using (MySqlCommand cmd = new MySqlCommand("INSERT INTO recetas (nombre, instrucciones, imagen, tips, categoria)" + 
                        "VALUES('"+ nombreReceta.Value + "','"+ instrucciones.Value + "','"+ instrucciones.Value + "','"+ imagen.Value + "','"+ tips.Value +"','"+ categorias.Value + "'" )) {

                            cmd.Connection = con;
                            cmd.ExecuteReader();
                    }
                }
            } catch (NullReferenceException ex) { }
        }
    }
}