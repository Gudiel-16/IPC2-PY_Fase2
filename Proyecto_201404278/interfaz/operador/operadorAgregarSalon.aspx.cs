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
    public partial class operadorAgregarSalon : System.Web.UI.Page
    {
        conexion_metodos bd = new conexion_metodos();
        protected void Page_Load(object sender, EventArgs e)
        {
            txtEdificio.Attributes.Add("autocomplete", "off");
            txtNivel.Attributes.Add("autocomplete", "off");
            txtNumeroSalon.Attributes.Add("autocomplete", "off");
        }

        protected void bttAgregar_Click(object sender, EventArgs e)
        {
            if (txtEdificio.Text==""||txtNivel.Text==""||txtNumeroSalon.Text=="")
            {
                
            }
            else
            {
                bd.insertar_salon(txtEdificio.Text, txtNivel.Text, txtNumeroSalon.Text, rolDeBaja.Value.ToString(), rolEstado.Value.ToString());
                MessageBox.Show("SALON AGREGADO CON EXITO!");
                Response.Redirect("/interfaz/operador/operadorAgregarSalon.aspx");
            }
        }

    }
}