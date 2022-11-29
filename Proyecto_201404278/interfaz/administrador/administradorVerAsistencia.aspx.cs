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
    public partial class administradorVerAsistencia : System.Web.UI.Page
    {

        conexion_metodos bd = new conexion_metodos();
        protected void Page_Load(object sender, EventArgs e)
        {
            bd.mostrar_asistenciaGeneral(GridView1);
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            txtBuscarPorFecha.Text = Calendar1.SelectedDate.Date.ToString("yyyy-MM-dd");
        }

        protected void Calendar2_SelectionChanged(object sender, EventArgs e)
        {
            txtFecha.Text = Calendar2.SelectedDate.Date.ToString("yyyy-MM-dd");
        }

        protected void bttBuscarPorFecha_Click(object sender, EventArgs e)
        {
            if (txtBuscarPorFecha.Text=="")
            {
                MessageBox.Show("SELECCIONE LA FECHA A BUSCAR");
            }
            else
            {
                bd.mostrar_asistenciaGeneral_porFecha(GridView1, txtBuscarPorFecha.Text);
            }
        }

        protected void bttBuscarPorCurso_Click(object sender, EventArgs e)
        {
            if (txtBuscarPorCurso.Text == "")
            {
                MessageBox.Show("INGRESE CODIGO DE CURSO A BUSCAR");
            }
            else
            {
                if (bd.validacion_codigo_curso(txtBuscarPorCurso.Text)>0)
                {
                    MessageBox.Show("CODIGO DE CURSO INCORRECTO");
                }
                else
                {
                    bd.mostrar_asistenciaGeneral_porCurso(GridView1, txtBuscarPorCurso.Text);
                }
                
            }
        }

        protected void bttBuscarPorfechaycurso_Click(object sender, EventArgs e)
        {
            if (txtBuscarPorCurso.Text == "")
            {
                MessageBox.Show("INGRESE CODIGO DE CURSO A BUSCAR");
            }
            else
            {
                if (bd.validacion_codigo_curso(txtCodigoCurso.Text) > 0)
                {
                    MessageBox.Show("CODIGO DE CURSO INCORRECTO");
                }
                else
                {
                    bd.mostrar_asistenciaGeneral_porFechaYCurso(GridView1, txtFecha.Text, txtCodigoCurso.Text);
                }
                
            }
        }
    }
}