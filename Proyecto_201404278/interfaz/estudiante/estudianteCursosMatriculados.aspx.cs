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
    public partial class estudianteCursosMatriculados : System.Web.UI.Page
    {
        conexion_metodos bd = new conexion_metodos();
        protected void Page_Load(object sender, EventArgs e)
        {

            txtcarnet.Attributes.Add("autocomplete", "off");
        }

        protected void bttbuscar_Click(object sender, EventArgs e)
        {
            if (txtcarnet.Text=="")
            {
                MessageBox.Show("DEBE INGRESAR NUMERO DE CARNET");
            }
            else
            {
                if (bd.validacion_carnetEstudiante(txtcarnet.Text)>0)
                {
                    bd.mostrar_cursosMatriculados(GridView1, txtcarnet.Text);
                }
                else
                {
                    MessageBox.Show("NUMERO DE CARNET INCORRECTO");
                }
            }
        }

    }
}