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

namespace Espatula {

    public partial class WebForm1 : System.Web.UI.Page {

        StringBuilder table = new StringBuilder();

        protected void Page_Load(object sender, EventArgs e)
        {
            
            /*if (!Page.IsPostBack)
            {

                DataTable dt = this.GetData();

                //Building an HTML string.
                StringBuilder html = new StringBuilder();

                //Table start.
                html.Append("<table border = '1'>");

                //Building the Header row.
                html.Append("<tr>");
                foreach (DataColumn column in dt.Columns)
                {
                    html.Append("<th>");
                    html.Append(column.ColumnName);
                    html.Append("</th>");
                }
                html.Append("</tr>");

                //Building the Data rows.
                foreach (DataRow row in dt.Rows)
                {
                    html.Append("<tr>");
                    foreach (DataColumn column in dt.Columns)
                    {
                        html.Append("<td>");
                        html.Append(row[column.ColumnName]);
                        html.Append("</td>");
                    }
                    html.Append("</tr>");
                }

                //Table end.
                html.Append("</table>");

                //Append the HTML string to Placeholder.
                PlaceHolder1.Controls.Add(new Literal { Text = html.ToString() });
            }*/
        }

        /*private DataTable GetData()
        {

            Data.MySqlClient.MySqlConnection msqlConnection = null;
            msqlConnection = new MySql.Data.MySqlClient.MySqlConnection(“server=localhost;user id=UserName;Password=UserPassword;database=DatabaseName;persist security info=False”);
                //define the command reference
            MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand();
                //define the connection used by the command object
            msqlCommand.Connection = this.msqlConnection;
                //define the command text
            msqlCommand.CommandText = "SELECT * FROM TestTable;";
            try
            {
                //open the connection
                this.msqlConnection.Open();
                //use a DataReader to process each record
                MySql.Data.MySqlClient.MySqlDataReader msqlReader = msqlCommand.ExecuteReader();
                while (msqlReader.Read())
                {
                    //do something with each record
                }
            }
            catch (Exception er)
            {
                //do something with the exception
            }
            finally
            {
                //always close the connection
                this.msqlConnection.Close();
            }






            try
            {
                //string constr = ConfigurationManager.ConnectionStrings["titanic.ecci.ucr.ac.cr"].ConnectionString;
                string a = "server=titanic.ecci.ucr.ac.cr;user id=eb04539;Password=eb04539;database=ci2454_eb04539;persist security info=False" ;

                using (SqlConnection con = new SqlConnection(a))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Ingredientes"))
                    {
                        using (SqlDataAdapter sda = new SqlDataAdapter())
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




        }*/

        protected void getId(object sender, EventArgs e){
            //Obtiene el id
        }

    }


}
