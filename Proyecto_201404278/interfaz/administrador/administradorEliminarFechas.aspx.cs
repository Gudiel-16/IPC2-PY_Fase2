using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto_201404278.base_de_datos;
using System.Windows.Forms;

namespace Proyecto_201404278.interfaz
{
    public partial class administradorEliminarFechas : System.Web.UI.Page
    {
        conexion_metodos bd = new conexion_metodos();
        protected void Page_Load(object sender, EventArgs e)
        {
            bd.mostrar_fechasRestringidas(GridView1);
            txtCodigoEliminar.Attributes.Add("autocomplete", "off");
        }

        protected void bttEliminar_Click(object sender, EventArgs e)
        {
            if (txtCodigoEliminar.Text=="")
            {
                MessageBox.Show("DEBE INGRESAR CODIGO PARA ELIMINAR");
            }
            else
            {
                if (bd.validacion_fechaRestrigida_codigo(txtCodigoEliminar.Text)>0)
                {
                    bd.eliminar_fechaRestringida(txtCodigoEliminar.Text);
                    MessageBox.Show("FECHA ELIMINADA CON EXITO");
                    Response.Redirect("/interfaz/administrador/administradorEliminarFechas.aspx");
                }
                else
                {
                    MessageBox.Show("CODIGO INVALIDO");
                }
            }
        }
    }
}