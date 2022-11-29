using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto_201404278.base_de_datos;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace Proyecto_201404278.interfaz
{
    public partial class administradorModificarReservacion : System.Web.UI.Page
    {
        conexion_metodos bd = new conexion_metodos();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bttBuscar_Click(object sender, EventArgs e)
        {
            if (txtCodigobuscar.Text == "")
            {
                MessageBox.Show("DEBE INGRESAR CODIGO A BUSCAR");
            }
            else
            {
                if (bd.validacion_codigo_reserva(txtCodigobuscar.Text) > 0)
                {
                    bd.llenar_TextBox_Reserva_Modificar(txtCodigobuscar.Text, txtCarnet, txtactividad, txtSalon, txtFechaInicio, txtFechaFin, txtHoraInicio, txtHoraFinal, txtcodigoQr, txtQuienregistra);
                    bd.cargarCartaEscaneada(txtCodigobuscar.Text, Repeater1);
                }
                else
                {
                    MessageBox.Show("LA RESERVA NO EXISTE");
                }


            }

        }

        protected void bttModificar_Click(object sender, EventArgs e)
        {
            //para comparar horas
            DateTime horaInicio = Convert.ToDateTime(RolhoraInicio.Value.ToString());
            DateTime horaFinal = Convert.ToDateTime(rolHorafin.Value.ToString());

            if (txtFechaInicio.Text == "" || txtFechaFin.Text == "" || txtSalon.Text == "")
            {
                MessageBox.Show("DEBE INGRESAR AL MENOS, LAS DOS FECHAS Y EL SALON");
            }
            else
            {
                if (FileUpload1.HasFile) //para modificar con carta
                {
                    if (bd.validacion_fecha_enrango_restringido(txtFechaInicio.Text, txtFechaFin.Text) > 0)//si esta en fecha restringida
                    {
                        MessageBox.Show("FECHA INCORRECTA: HAY FECHAS RESTRINGIDAS EN ESE INTERVALO");
                    }
                    else
                    {
                        if (bd.validacion_salon_codigo(Convert.ToInt32(txtSalon.Text)) > 0) // si existe el salon
                        {
                            if (bd.validacion_salon_estado(Convert.ToInt32(txtSalon.Text)) > 0)
                            {
                                MessageBox.Show("EL SALON ESTA RESERVADO,OCUPADAO O DE BAJA");
                            }
                            else
                            {

                                if (RolhoraInicio.Value.ToString().Equals(rolHorafin.Value.ToString()))
                                {
                                    MessageBox.Show("FECHA DE INICIO NO PUEDE SER IGUAL A FECHA FIN");
                                }
                                else
                                {
                                    if (horaInicio.CompareTo(horaFinal) == 1)
                                    {
                                        MessageBox.Show("HORA INICIO NO PUEDE SER MAYOR A HORA FIN");
                                    }
                                    else
                                    {
                                        int tamanio = FileUpload1.PostedFile.ContentLength;
                                        byte[] imagenoriginal = new byte[tamanio];
                                        FileUpload1.PostedFile.InputStream.Read(imagenoriginal, 0, tamanio);
                                        Bitmap imagenBinaria = new Bitmap(FileUpload1.PostedFile.InputStream);

                                        bd.actualizar_reserva_con(txtCodigobuscar.Text, rolactividad.Value.ToString(), txtFechaInicio.Text, txtFechaFin.Text, RolhoraInicio.Value.ToString(), rolHorafin.Value.ToString(), Convert.ToInt32(txtSalon.Text), imagenoriginal);

                                        string imagenDataUrl = "data:imaga/jpg;base64," + Convert.ToBase64String(imagenoriginal);
                                        imgCarta.ImageUrl = imagenDataUrl;

                                        bd.actualizar_salon_estado(Convert.ToInt32(txtSalon.Text));

                                        MessageBox.Show("RESERVA MODIFICADA CON EXITO!");
                                        Response.Redirect("/interfaz/administrador/administradorModificarReservacion.aspx");
                                    }
                                }

                            }
                        }
                        else
                        {
                            MessageBox.Show("EL SALON NO EXISTE");
                        }
                    }
                }
                else //para modificar sin carta (dejar la misma)
                {
                    if (bd.validacion_fecha_enrango_restringido(txtFechaInicio.Text, txtFechaFin.Text) > 0)//si esta en fecha restringida
                    {
                        MessageBox.Show("FECHA INCORRECTA: HAY FECHAS RESTRINGIDAS EN ESE INTERVALO");
                    }
                    else
                    {
                        if (bd.validacion_salon_codigo(Convert.ToInt32(txtSalon.Text)) > 0) // si existe el salon
                        {
                            if (bd.validacion_salon_estado(Convert.ToInt32(txtSalon.Text)) > 0)
                            {
                                MessageBox.Show("EL SALON ESTA RESERVADO,OCUPADAO O DE BAJA");
                            }
                            else
                            {
                                if (RolhoraInicio.Value.ToString().Equals(rolHorafin.Value.ToString()))
                                {
                                    MessageBox.Show("FECHA DE INICIO NO PUEDE SER IGUAL A FECHA FIN");
                                }
                                else
                                {
                                    if (horaInicio.CompareTo(horaFinal) == 1)
                                    {
                                        MessageBox.Show("HORA INICIO NO PUEDE SER MAYOR A HORA FIN");
                                    }
                                    else
                                    {
                                        bd.actualizar_reserva_sin(txtCodigobuscar.Text, rolactividad.Value.ToString(), txtFechaInicio.Text, txtFechaFin.Text, RolhoraInicio.Value.ToString(), rolHorafin.Value.ToString(), Convert.ToInt32(txtSalon.Text));
                                        bd.actualizar_salon_estado(Convert.ToInt32(txtSalon.Text));
                                        MessageBox.Show("RESERVA ACTUALIZADA CORRECTAMENTE");
                                        Response.Redirect("/interfaz/administrador/administradorModificarReservacion.aspx");
                                    }
                                }


                            }
                        }
                        else
                        {
                            MessageBox.Show("EL SALON NO EXISTE");
                        }
                    }
                }
            }
        }
    }
}