using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Drawing;
using MessagingToolkit.QRCode.Codec;
using Proyecto_201404278.base_de_datos;
using System.Windows.Forms;

namespace Proyecto_201404278.interfaz
{
    public partial class administradorCrearReservacion : System.Web.UI.Page
    {
        conexion_metodos bd = new conexion_metodos();
        byte[] imageBytes;//para la imagen QR
        protected void Page_Load(object sender, EventArgs e)
        {
            //para que los texbox no tengan historial
            txtCodigoacrear.Attributes.Add("autocomplete", "off");
            txtcodigoQrcreado.Attributes.Add("autocomplete", "off");
            txtCarnet.Attributes.Add("autocomplete", "off");
            txtCodigoReserva.Attributes.Add("autocomplete", "off");
            txtDesde.Attributes.Add("autocomplete", "off");
            txtHasta.Attributes.Add("autocomplete", "off");
            txtQuienRegistra.Attributes.Add("autocomplete", "off");
            txtSalon.Attributes.Add("autocomplete", "off");
            
        }

        protected void bttgenerarQR_Click(object sender, EventArgs e)
        {

            if (txtCodigoacrear.Text == "")
            {
                MessageBox.Show("HAY CAMPOS VACIOS");
            }
            else
            {
                if (bd.validacion_codigoQR(txtCodigoacrear.Text) > 0)//para ver si ya existe el codigo qr
                {
                    MessageBox.Show("EL CODIGO DE 'CODIGO QR' YA EXISTE");
                }
                else
                {
                    QRCodeEncoder encoder = new QRCodeEncoder();
                    Bitmap img = encoder.Encode("http://192.168.1.9:1505/interfaz/asistencia.aspx");
                    System.Drawing.Image QR = (System.Drawing.Image)img;

                    using (MemoryStream ms = new MemoryStream())
                    {
                        QR.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        imageBytes = ms.ToArray();
                        bd.inserta_imagen_qr(txtCodigoacrear.Text, imageBytes);
                        imgQR.ImageUrl = "data:image/gif;base64," + Convert.ToBase64String(imageBytes);
                        imgQR.Height = 200;

                    }

                    txtCodigoacrear.Enabled = false;
                    txtcodigoQrcreado.Text = txtCodigoacrear.Text;
                    txtcodigoQrcreado.Enabled = false;
                    brrGenerarQR.Enabled = false;
                    
                }

            }

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            txtDesde.Text = Calendar1.SelectedDate.Date.ToString("yyyy-MM-dd");

        }

        protected void Calendar2_SelectionChanged(object sender, EventArgs e)
        {
            txtHasta.Text = Calendar2.SelectedDate.Date.ToString("yyyy-MM-dd");
        }

        protected void bttCrearresarva_Click(object sender, EventArgs e)
        {
            //para comparar horas
            DateTime horaInicio = Convert.ToDateTime(RolhoraInicio.Value.ToString());
            DateTime horaFinal = Convert.ToDateTime(rolHorafin.Value.ToString());

            if (txtcodigoQrcreado.Text == "" || txtCodigoReserva.Text == "" || txtCarnet.Text == "" || txtSalon.Text == "" || txtDesde.Text == "" || txtHasta.Text == "" || txtQuienRegistra.Text == "")
            {
                MessageBox.Show("HAY CAMPOS VACIOS");
            }
            else
            {
                if (FileUpload1.HasFile) //por si no se a seleccionado la carta
                {


                    if (bd.validacion_codigo_reserva(txtCodigoReserva.Text) > 0)
                    {
                        MessageBox.Show("EL CODIGO DE RESERVA YA EXISTE");//para ver si ya existe el codigo de reserva
                    }
                    else
                    {
                        if (bd.validacion_fecha_enrango_restringido(txtDesde.Text, txtHasta.Text) > 0)//para ver si esta en fecha restringida
                        {
                            MessageBox.Show("QUIERE HACER LA RESERVA EN FECHA RESTRINGIDA");
                        }
                        else
                        {
                            if (bd.validacion_carnetInstructor(txtCarnet.Text) > 0)//para ver si existe el instructor
                            {

                                if (bd.validacion_carnetAdmin_operador(txtQuienRegistra.Text) > 0)//si existe admin o operador
                                {

                                    if (bd.validacion_salon_codigo(Convert.ToInt32(txtSalon.Text)) > 0)//si existe el salon
                                    {
                                        //para verificar si esta ocupado o reservado
                                        if (bd.validacion_salon_estado(Convert.ToInt32(txtSalon.Text)) > 0)
                                        {
                                            MessageBox.Show("SALON ESTA OCUPADO, RESERVADO O DE BAJA");
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
                                                    txtcodigoQrcreado.Enabled = true;

                                                    int tamanio = FileUpload1.PostedFile.ContentLength;
                                                    byte[] imagenoriginal = new byte[tamanio];
                                                    FileUpload1.PostedFile.InputStream.Read(imagenoriginal, 0, tamanio);
                                                    Bitmap imagenBinaria = new Bitmap(FileUpload1.PostedFile.InputStream);

                                                    bd.insertar_reserva(txtCodigoReserva.Text, rolActividad.Value.ToString(), txtDesde.Text, txtHasta.Text, RolhoraInicio.Value.ToString(), rolHorafin.Value.ToString(), imagenoriginal, txtcodigoQrcreado.Text, Convert.ToInt32(txtSalon.Text), txtCarnet.Text, txtQuienRegistra.Text);

                                                    string imagenDataUrl = "data:imaga/jpg;base64," + Convert.ToBase64String(imagenoriginal);
                                                    imgCarta.ImageUrl = imagenDataUrl;

                                                    bd.actualizar_salon_estado(Convert.ToInt32(txtSalon.Text));

                                                    MessageBox.Show("RESERVA REALIZADA EXITO!");
                                                    Response.Redirect("/interfaz/administrador/administradorCrearReservacion.aspx");
                                                }
                                            }

                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("EL SALON NO EXISTE");
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("CARNET DE QUIEN LO REGISTRA NO EXISTE");
                                }

                            }
                            else
                            {
                                MessageBox.Show("EL INSTRUCTOR NO EXISTE!");
                            }
                        }
                    }


                }
                else
                {
                    MessageBox.Show("DEBE AGREGAR LA CARTA ESCANEADA");
                }
            }

            txtCodigoacrear.Enabled = true;


        }
    }
}