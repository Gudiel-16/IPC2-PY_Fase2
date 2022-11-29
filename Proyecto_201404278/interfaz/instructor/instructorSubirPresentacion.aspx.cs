using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Proyecto_201404278.base_de_datos;
using System.IO;
using System.Drawing;

namespace Proyecto_201404278.interfaz
{
    public partial class instructorSubirPresentacion : System.Web.UI.Page
    {
        conexion_metodos bd = new conexion_metodos();
        protected void Page_Load(object sender, EventArgs e)
        {
            txtcodigoCurso.Attributes.Add("autocomplete", "off");
            txtCodigoReserva.Attributes.Add("autocomplete", "off");
            txtDescripcion.Attributes.Add("autocomplete", "off");
            txtNombre.Attributes.Add("autocomplete", "off");
        }

        protected void bttSubir_Click(object sender, EventArgs e)
        {
            if (txtcodigoCurso.Text=="" || txtCodigoReserva.Text=="" || txtDescripcion.Text=="" || txtNombre.Text=="")
            {
                MessageBox.Show("HAY CAMPOS VACIOS");
            }
            else
            {
                if (bd.validacion_codigo_curso(txtcodigoCurso.Text)>0)//validar codigo de curso
                {
                    MessageBox.Show("CODIGO DE CURSO INCORRECTO");
                }
                else
                {
                    if (bd.validacion_codigo_reserva(txtCodigoReserva.Text) > 0)//validar codigo de reserva
                    {
                        if (bd.validacion_codigo_salon_en_reserva(Convert.ToInt32(txtCodigoSalon.Text)) > 0)
                        {
                            int tamanio = FileUpload1.PostedFile.ContentLength;
                            byte[] archivo = new byte[tamanio];
                            FileUpload1.PostedFile.InputStream.Read(archivo, 0, tamanio);
                            //Bitmap imagenBinaria = new Bitmap(FileUpload1.PostedFile.InputStream);
                            bd.insertar_curso(txtcodigoCurso.Text, txtNombre.Text, txtDescripcion.Text, archivo, txtCodigoReserva.Text);
                            bd.actualizar_salon_estado2(Convert.ToInt32(txtCodigoSalon.Text));
                            MessageBox.Show("LA PRESENTACION SE CARGO CON EXITO!");
                        }
                        else
                        {
                            MessageBox.Show("EL SALON NO PERTENECE A LA RESERVA");
                        }

                    }
                    else
                    {
                        MessageBox.Show("CODIGO DE RESERVA INCORRECTO");
                    }
                    
                }
            }
            
        }
    }
}