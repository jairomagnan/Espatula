using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Espatula.Recetas {
    public partial class ver : System.Web.UI.Page {
        private string constr = "Data Source=localhost; port=3306; Initial Catalog=ci2454_eb04539;User Id=eb04539;password=eb04539";

        protected void Page_Load(object sender, EventArgs e) {

            if (!IsPostBack) {

                List<String[]> resultado = Obtener();

                Mostrar(resultado);
            }



        }

        protected List<String[]> Obtener() {
            List<String[]> lista = new List<String[]>();
            String[] entrada = new String[4];

            MySqlConnection conection = new MySqlConnection(constr);
            MySqlDataReader reader = null;

            try {
                conection.Open();
                string consulta = "SELECT * FROM recetas";


                MySqlCommand comando = new MySqlCommand(consulta, conection);
                reader = comando.ExecuteReader();


                while (reader.Read()) {
                    entrada = new String[4];

                    entrada[0] = reader.GetString(0);

                    try {
                        entrada[1] = reader.GetString(1);

                    } catch (Exception ex) {
                        entrada[1] = "";
                    }

                    try {
                        entrada[2] = reader.GetString(7);

                    } catch (Exception ex) {

                        entrada[2] = "";

                    }

                    try {

                        entrada[3] = reader.GetString(6);

                    } catch (Exception ex) {
                        entrada[3] = "";
                    }

                    try {
                        entrada[4] = reader.GetString(4);
                    } catch (Exception ex) {
                        entrada[4] = "";
                    }

                    lista.Add(entrada);

                }



                conection.Close();

            } catch (Exception e) {

            }

            return lista;

        }


        protected List<String[]> Obtener(String cons) {
            List<String[]> lista = new List<String[]>();
            String[] entrada = new String[4];



            MySqlConnection conection = new MySqlConnection(constr);
            MySqlDataReader reader = null;

            try {
                conection.Open();
                string consulta = "SELECT * FROM recetas WHERE nombre LIKE '" + cons + "%' ";


                MySqlCommand comando = new MySqlCommand(consulta, conection);
                reader = comando.ExecuteReader();

                while (reader.Read()) {
                    entrada = new String[4];

                    entrada[0] = reader.GetString(0);

                    try {
                        entrada[1] = reader.GetString(1);

                    } catch (Exception ex) {
                        entrada[1] = "";
                    }

                    try {
                        entrada[2] = reader.GetString(7);

                    } catch (Exception ex) {

                        entrada[2] = "";

                    }

                    try {

                        entrada[3] = reader.GetString(6);

                    } catch (Exception ex) {
                        entrada[3] = "";
                    }

                    try {
                        entrada[4] = reader.GetString(4);
                    } catch (Exception ex) {
                        entrada[4] = "";
                    }

                    lista.Add(entrada);

                }



                conection.Close();

            } catch (Exception e) {

            }

            return lista;

        }



        protected void Mostrar(List<String[]> lista) {

            for (int i = 0; i < lista.Count; i++) {
                TableRow fila = new TableRow();
                fila.Attributes.Add("style", "border-style:solid;");
                tblBuscar.Rows.Add(fila);

                TableCell celda = new TableCell();
                HyperLink link = new HyperLink();
                link.Text = lista[i][1];


                link.NavigateUrl = "";


                celda.Controls.Add(link);

                fila.Cells.Add(celda);

                for (int j = 2; j < lista[i].Length - 1; j++) {
                    celda = new TableCell();

                    celda.Text = lista[i][j];

                    fila.Cells.Add(celda);


                }


                celda = new TableCell();
                Image img = new Image();
                img.ImageUrl = lista[i][5];
                img.Height = 100;
                img.Width = 100;

                celda.Controls.Add(img);
                fila.Cells.Add(celda);

            }

        }

        protected void btnBuscar_Click(Object sender, EventArgs e) {
            Mostrar(Obtener(txBuscar.Text));
        }

        protected void btnLetra_Click(object sender, EventArgs e) {
            Button boton = (Button)sender;
            Mostrar(Obtener(boton.Text));
        }
    }
}