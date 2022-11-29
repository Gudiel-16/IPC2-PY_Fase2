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
    public partial class operadorEliminarSalon : System.Web.UI.Page
    {
        conexion_metodos bd = new conexion_metodos();
        protected void Page_Load(object sender, EventArgs e)
        {
            //para que los texbox no tengan historial
            txtCodigobuscar.Attributes.Add("autocomplete", "off");
            txtDeBaja.Attributes.Add("autocomplete", "off");
            txtEdificio.Attributes.Add("autocomplete", "off");
            txtEstado.Attributes.Add("autocomplete", "off");
            txtNivel.Attributes.Add("autocomplete", "off");
            txtNumeroSalon.Attributes.Add("autocomplete", "off");
        }

       
        protected void bttbuscar_Click(object sender, EventArgs e)
        {

            if (txtCodigobuscar.Text == "")
            {
                MessageBox.Show("DEBE INGRESAR CODIGO");
            }
            else
            {
                if (bd.validacion_salon_codigo(Convert.ToInt32(txtCodigobuscar.Text)) > 0)
                {
                    bd.llenar_TextBox_salon(Convert.ToInt32(txtCodigobuscar.Text), txtEdificio, txtNivel, txtNumeroSalon, txtDeBaja, txtEstado);
                    txtEdificio.Enabled = false;
                    txtNivel.Enabled = false;
                    txtNumeroSalon.Enabled = false;
                    txtDeBaja.Enabled = false;
                    txtEstado.Enabled = false;
                }
                else
                {
                    MessageBox.Show("EL SALON NO EXISTE");
                }
            }

        }

        protected void btteliminar_Click(object sender, EventArgs e)
        {

            if (txtCodigobuscar.Text == "")
            {
                MessageBox.Show("DEBE INGRESAR CODIGO");
            }
            else
            {
                if (bd.validacion_salon_codigo(Convert.ToInt32(txtCodigobuscar.Text)) > 0)
                {
                    bd.eliminar_salon(Convert.ToInt32(txtCodigobuscar.Text));
                    MessageBox.Show("SALON ELIMINADO CON EXITO!");
                    Response.Redirect("/interfaz/operador/operadorEliminarSalon.aspx");
                }
                else
                {
                    MessageBox.Show("EL SALON NO EXISTE");
                }
            }

        }
    }
}