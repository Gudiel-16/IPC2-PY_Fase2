using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto_201404278.base_de_datos;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_201404278.interfaz
{
    public partial class instructor_descargarQR : System.Web.UI.Page
    {
        conexion_metodos bd = new conexion_metodos();
        protected void Page_Load(object sender, EventArgs e)
        {
            txtcodigoReserva.Attributes.Add("autocomplete", "off");
        }

        protected void bttCargarQr_Click(object sender, EventArgs e)
        {
            if (txtcodigoReserva.Text=="")
            {
                MessageBox.Show("DEBE INGRESAR CODIGO PARA BUSCAR");
            }
            else
            {
                if (bd.validacion_codigo_reserva(txtcodigoReserva.Text)>0)
                {
                    bd.cargarQR(txtcodigoReserva.Text, Repeater1);
                }
                else
                {
                    MessageBox.Show("CODIGO DE RESERVA INCORRECTO");
                }
                
            }
            
            
        }

        protected void bttdescargaQr_Click(object sender, EventArgs e)
        {

            if (txtcodigoReserva.Text == "")
            {
                MessageBox.Show("DEBE INGRESAR CODIGO PARA BUSCAR");
            }
            else
            {
                if (bd.validacion_codigo_reserva(txtcodigoReserva.Text) > 0)
                {
                    byte[] bytes;
                    //string fileName;
                    String mycon = "Data Source=GUDIEL-PC\\SQLEXPRESS;Initial Catalog=Plataforma_CienciasSistemas_USAC;Integrated Security=True";
                    SqlConnection con = new SqlConnection(mycon);
                    con.Open();
                    string query = "select * from codigo_QR where codigo_qr='" + txtcodigoReserva.Text + "'";
                    SqlCommand cmd = new SqlCommand(query);
                    cmd.Connection = con;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    sdr.Read();
                    bytes = (byte[])sdr["imagen"];

                    con.Close();
                    Response.Clear();
                    Response.Buffer = true;
                    Response.Charset = "";
                    Response.Cache.SetCacheability(HttpCacheability.NoCache);
                    Response.AppendHeader("Content-Disposition", "attachment; filename=" + "aa" + ".jpg");
                    Response.BinaryWrite(bytes);
                    Response.Flush();
                    Response.End(); 
                }
                else
                {
                    MessageBox.Show("CODIGO DE RESERVA INCORRECTO");
                }

            }
            
        }

    }
}