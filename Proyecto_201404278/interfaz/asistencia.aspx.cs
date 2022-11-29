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
    public partial class asistencia1 : System.Web.UI.Page
    {
        conexion_metodos bd = new conexion_metodos();
        protected void Page_Load(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Now.Date.ToString("yyyy-MM-dd");
            //txtHora.Text = String.Format("{0:G}", DateTime.Now.ToString("hh:mm:hh"));
            txtFecha.Enabled = false;
            //txtHora.Enabled = false;
            txtCarnet.Attributes.Add("autocomplete", "off");
            txtCodigoCurso.Attributes.Add("autocomplete", "off");
            txtCodigoReserva.Attributes.Add("autocomplete", "off");
        }

        protected void bttGudardar_Click(object sender, EventArgs e)
        {
            if (txtCarnet.Text=="" || txtCodigoCurso.Text=="" || txtCodigoReserva.Text=="")
            {
                MessageBox.Show("HAY CAMPOS VACIOS");
            }
            else
            {
                if (bd.validacion_carnetEstudiante(txtCarnet.Text)>0)//validar carnet estudiante
                {
                    if (bd.validacion_codigo_curso(txtCodigoCurso.Text)>0)//validar codigo de curso
                    {
                        if (bd.validacion_codigo_reserva(txtCodigoReserva.Text)>0)//validar codigo de reserva
                        {
                            if (bd.validacion_matriculacion_asistencia(txtCarnet.Text,txtCodigoCurso.Text)>0)//validar matriculacion
                            {
                                if (bd.validacion_fecha_asistencia(txtCodigoReserva.Text,txtFecha.Text)>0)//validar fecha
                                {
                                    if (bd.validacion_hora_asistencia(txtCodigoReserva.Text,txtHora.Text)>0)//validar hora
                                    {
                                        if (bd.validacion_yaguardo_asistencia(txtCarnet.Text,txtFecha.Text)>0)//validar si ya guardo asistencia
                                        {
                                            MessageBox.Show("YA GUARDO LA ASISTENCIA DEL DIA");
                                        }
                                        else
                                        {
                                            txtFecha.Enabled = true;
                                            txtHora.Enabled = true;
                                            bd.insertar_asistencia(txtCodigoCurso.Text, txtCarnet.Text, txtCodigoReserva.Text, txtFecha.Text, txtHora.Text);
                                            MessageBox.Show("ASISTENCIA REGISTRADA CON EXITO");
                                            txtCarnet.Text = "";
                                            txtCodigoCurso.Text = "";
                                            txtCodigoReserva.Text = "";
                                            txtFecha.Enabled = false;
                                            txtHora.Enabled = false;

                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("NO SE PUEDE TOMAR ASISTENCIA, ESTA FUERA DE LA HORA");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("NO SE PUEDE TOMAR ASISTENCIA, ESTA FUERA DE LA FECHA");
                                }
                            }
                            else
                            {
                                MessageBox.Show("NO ESTA MATRICULADO EN EL CURSO");
                            }
                        }
                        else
                        {
                            MessageBox.Show("CODIGO DE RESERVA INVALIDO");
                        }
                    }
                    else
                    {
                        MessageBox.Show("CODIGO DE CURSO INVALIDO");
                    }
                }
                else
                {
                    MessageBox.Show("CARNET INVALIDO");
                }
            }
        }

       

    }
}