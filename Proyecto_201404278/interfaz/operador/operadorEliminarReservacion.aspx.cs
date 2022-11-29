using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Proyecto_201404278.base_de_datos;

namespace Proyecto_201404278.interfaz
{
    public partial class operadorEliminarReservacion : System.Web.UI.Page
    {
        conexion_metodos bd = new conexion_metodos();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void bttbuscar_Click(object sender, EventArgs e)
        {
            if (txtCodigobuscar.Text=="")
            {
                MessageBox.Show("DEBE INGRESAR CODIGO A BUSCAR");
            }
            else
            {
                if (bd.validacion_reservacion_codigo(txtCodigobuscar.Text)>0)
                {
                    bd.llenar_TextBox_Reserva(txtCodigobuscar.Text, txtCarnet, txtActividad, txtSalon, txtFechainicio, txtFechafinal,txtHoraInicio,txtHoraFinal, txtcodigoQr);
                }
                else
                {
                    MessageBox.Show("LA RESERVACION NO EXISTE");
                }
            }
        }

        protected void btteliminar_Click(object sender, EventArgs e)
        {

            if (txtCodigobuscar.Text == "")
            {
                MessageBox.Show("DEBE INGRESAR CODIGO A BUSCAR PARA ELIMINAR RESERVACION");
            }
            else
            {
                if (bd.validacion_reservacion_codigo(txtCodigobuscar.Text) > 0)
                {
                    bd.eliminar_reservacion(txtCodigobuscar.Text);
                    MessageBox.Show("RESERVACION ELIMINADA CON EXITO");
                    Response.Redirect("/interfaz/operador/operadorEliminarReservacion.aspx");
                }
                else
                {
                    MessageBox.Show("LA RESERVACION NO EXISTE");
                }
            }

        }
    }
}