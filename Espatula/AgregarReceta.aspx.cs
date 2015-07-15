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
                /*
                String connectionString = ConfigurationManager.ConnectionStrings["ci2454_eb04539ConnectionString"].ConnectionString;
                string QueryString = "select name from categorias";

                MySqlConnection myConnection = new MySqlConnection(connectionString);
                MySqlDataAdapter myCommand = new MySqlDataAdapter(QueryString, myConnection);
                DataSet ds = new DataSet();
                myCommand.Fill(ds, "Categorias");

                categorias.DataSource = ds;
                categorias.DataTextField = "au_fname";
                categorias.DataValueField = "au_fname";
                categorias.DataBind();*/

                try {
                    string constr = "Data Source=http://titanic.ecci.ucr.ac.cr; port=3306; Initial Catalog=ci2454_eb04539;User Id=eb04539;password=eb04539";// ConfigurationManager.ConnectionStrings["ci2454_eb04539ConnectionString"].ConnectionString;

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
    }
}