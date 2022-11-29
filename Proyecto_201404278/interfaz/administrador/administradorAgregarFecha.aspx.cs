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
    public partial class administradorAgregarFecha : System.Web.UI.Page
    {
        conexion_metodos bd = new conexion_metodos();
        protected void Page_Load(object sender, EventArgs e)
        {
            txtDescripcion.Attributes.Add("autocomplete", "off");
            txtDesde.Attributes.Add("autocomplete", "off");
            txtHasta.Attributes.Add("autocomplete", "off");
            txtQuienregistra.Attributes.Add("autocomplete", "off");
        }
        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            txtDesde.Text = Calendar1.SelectedDate.Date.ToString("yyyy-MM-dd");
        }

        protected void Calendar2_SelectionChanged(object sender, EventArgs e)
        {
            txtHasta.Text = Calendar2.SelectedDate.Date.ToString("yyyy-MM-dd");
        }

        protected void bttagregarFecha_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text=="" || txtDesde.Text=="" || txtHasta.Text=="" || txtQuienregistra.Text=="")
            {
                MessageBox.Show("HAY CAMPOS VACIOS");   
            }
            else
            {
                if (bd.validacion_carnetAdmin_operador(txtQuienregistra.Text)>0)
                {
                    bd.insertar_fecha_restringida(txtDesde.Text, txtHasta.Text, txtDescripcion.Text, txtQuienregistra.Text);
                    MessageBox.Show("FECHA RESTRINGIDA AGREGADA CON EXITO!");
                    Response.Redirect("/interfaz/administrador/administradorAgregarFecha.aspx");
                }
                else
                {
                    MessageBox.Show("NO EXISTE CARNET DE QUIEN LO REGISTRA");
                }
            }
        }

    }
}