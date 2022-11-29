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
    public partial class administradorVerCursos : System.Web.UI.Page
    {
        conexion_metodos bd = new conexion_metodos();
        protected void Page_Load(object sender, EventArgs e)
        {
            bd.mostrar_Cursos2(GridView1);
            txtCarnetMatricular.Attributes.Add("autocomplete", "off");
            txtCodigoCursoMatricular.Attributes.Add("autocomplete", "off");
            txtcodigoDescargarPresentacion.Attributes.Add("autocomplete", "off");
            txtnombreCursoBuscar.Attributes.Add("autocomplete", "off");
        }

        protected void bttDescargarPresentacion_Click(object sender, EventArgs e)
        {

            if (txtcodigoDescargarPresentacion.Text == "")
            {
                MessageBox.Show("DEBE INGRESAR CODIGO DE CURSO PARA DESCARGAR");
            }
            else
            {
                if (bd.validacion_codigo_curso(txtcodigoDescargarPresentacion.Text) > 0)
                {
                    byte[] bytes;
                    //string fileName;
                    String mycon = "Data Source=GUDIEL-PC\\SQLEXPRESS;Initial Catalog=Plataforma_CienciasSistemas_USAC;Integrated Security=True";
                    SqlConnection con = new SqlConnection(mycon);
                    con.Open();
                    string query = "select * from curso where codigo_curso='" + txtcodigoDescargarPresentacion.Text + "'";
                    SqlCommand cmd = new SqlCommand(query);
                    cmd.Connection = con;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    sdr.Read();
                    bytes = (byte[])sdr["presentacion_pdf"];

                    con.Close();
                    Response.Clear();
                    Response.Buffer = true;
                    Response.Charset = "";
                    Response.Cache.SetCacheability(HttpCacheability.NoCache);
                    Response.AppendHeader("Content-Disposition", "attachment; filename=" + txtcodigoDescargarPresentacion.Text + ".pdf");
                    Response.BinaryWrite(bytes);
                    Response.Flush();
                    Response.End();
                }
                else
                {
                    MessageBox.Show("CODIGO DE CURSO INVALIDO");
                }
            }

        }

        protected void bttBuscarCurso_Click(object sender, EventArgs e)
        {
            if (txtnombreCursoBuscar.Text == "")
            {
                MessageBox.Show("DEBE INGRESAR CODIGO DE CURSO A BUSCAR");
            }
            else
            {
                if (bd.validacion_codigo_curso(txtnombreCursoBuscar.Text) > 0)
                {
                    bd.mostrar_Cursos(GridView1, txtnombreCursoBuscar.Text);
                }
                else
                {
                    MessageBox.Show("CODIGO DE CURSO INVALIDO");
                }
            }

        }

        protected void bttMatricularse_Click(object sender, EventArgs e)
        {
            if (txtCodigoCursoMatricular.Text == "" || txtCarnetMatricular.Text == "")
            {
                MessageBox.Show("HAY CAMPOS VACIOS");
            }
            else
            {
                if (bd.validacion_codigo_curso(txtCodigoCursoMatricular.Text) > 0)//validar codigo curso
                {
                    if (bd.validacion_carnetEstudiante(txtCarnetMatricular.Text) > 0)//validar carnet estudiante
                    {
                        if (bd.validacion_curso_cantidad(txtCodigoCursoMatricular.Text) <= 25)//validar cantidad de estudiantes
                        {
                            if (bd.validacion_siyaesta_matriculado_encurso(txtCarnetMatricular.Text, txtCodigoCursoMatricular.Text) > 0)
                            {
                                MessageBox.Show("YA ESTA MATRICULADO EN ESTE CURSO");
                            }
                            else
                            {
                                bd.insertar_matriculacion(txtCarnetMatricular.Text, txtCodigoCursoMatricular.Text);
                                MessageBox.Show("MATRICULADO CON EXITO");
                                Response.Redirect("/interfaz/estudiante/estudianteVerPresentaciones.aspx");
                            }

                        }
                        else
                        {
                            MessageBox.Show("YA NO HAY CUPO EN ESTE CURSO");
                        }

                    }
                    else
                    {
                        MessageBox.Show("CARNET INVALIDO");
                    }
                }
                else
                {
                    MessageBox.Show("CODIGO DE CURSO INVALIDO");
                }
            }
        }
    }
}