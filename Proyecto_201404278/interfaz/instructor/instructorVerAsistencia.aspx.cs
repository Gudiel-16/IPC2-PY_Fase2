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
    public partial class instructorVerAsistencia : System.Web.UI.Page
    {
        conexion_metodos bd = new conexion_metodos();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bttBuscarPorCurso_Click(object sender, EventArgs e)
        {
            if (txtBuscarPorCurso.Text == "")
            {
                MessageBox.Show("INGRESE CODIGO DE CURSO A BUSCAR");
            }
            else
            {
                if (bd.validacion_codigo_curso(txtBuscarPorCurso.Text) > 0)
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