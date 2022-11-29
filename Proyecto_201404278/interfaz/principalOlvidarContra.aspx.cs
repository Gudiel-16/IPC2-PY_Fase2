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
    public partial class principalOlvidarContra : System.Web.UI.Page
    {
        conexion_metodos bd = new conexion_metodos();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bttRecuperar_Click(object sender, EventArgs e)
        {
            string cuerpo = "";
            cuerpo += "ESCUELA DE CIENCIAS Y SISTEMAS LE RECUERDA QUE SU CONTRASEÑA SOLICITADA ES:\n ";

            if (txtcarnetBuscar.Text=="" || txtPalabra.Text=="")
            {

            }
            else
            {
                if (rolBuscar.Value.ToString()=="Administrador" || rolBuscar.Value.ToString()=="Operador")
                {
                    if (bd.validacion_carnetAdmin_operador(txtcarnetBuscar.Text)>0)
                    {
                        if (bd.validacion_recuperarcontra_adminoperador(txtcarnetBuscar.Text,txtPalabra.Text)>0)
                        {
                            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
                            msg.To.Add(txtCorreo.Text);
                            msg.Subject = "RECUPERAR CONTRASEÑA (PLATAFORMA CIENCIAS Y SISTEMAS USAC)";
                            msg.SubjectEncoding = System.Text.Encoding.UTF8;

                            //cuerpo de mensaje
                            cuerpo += bd.contra_recuperada_adminoperador(txtcarnetBuscar.Text, txtPalabra.Text);
                            msg.Body = cuerpo;
                            msg.BodyEncoding = System.Text.Encoding.UTF8;
                            msg.IsBodyHtml = true;

                            //desde donde se envia
                            msg.From = new System.Net.Mail.MailAddress("ciencias.sitemas.usac@gmail.com");

                            System.Net.Mail.SmtpClient cliente=new System.Net.Mail.SmtpClient();
                            cliente.Credentials = new System.Net.NetworkCredential("ciencias.sitemas.usac@gmail.com", "introduccionalaprogramacion2");
                            cliente.Port = 587;
                            cliente.EnableSsl = true;

                            cliente.Host = "smtp.gmail.com";

                            try
                            {
                                cliente.Send(msg);
                                MessageBox.Show("SE HA ENVIADO LA CONTRASEÑA A SU CORREO!");
                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show("Error al Enviar, pueda que el correo no exista!"+ex.ToString());
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("DATOS INCORRECTOS");
                        }
                    }
                    else
                    {
                        MessageBox.Show("CARNET INCORRECTO");
                    }
                }
                else if (rolBuscar.Value.ToString() == "Docente" || rolBuscar.Value.ToString() == "Auxiliar" || rolBuscar.Value.ToString() == "Conferencista")
                {
                    if (bd.validacion_carnetInstructor(txtcarnetBuscar.Text) > 0)
                    {
                        if (bd.validacion_recuperarcontra_instructor(txtcarnetBuscar.Text, txtPalabra.Text) > 0)
                        {
                            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
                            msg.To.Add(txtCorreo.Text);
                            msg.Subject = "RECUPERAR CONTRASEÑA (PLATAFORMA CIENCIAS Y SISTEMAS USAC)";
                            msg.SubjectEncoding = System.Text.Encoding.UTF8;

                            //cuerpo de mensaje
                            cuerpo += bd.contra_recuperada_adminoperador(txtcarnetBuscar.Text, txtPalabra.Text);
                            msg.Body = cuerpo;
                            msg.BodyEncoding = System.Text.Encoding.UTF8;
                            msg.IsBodyHtml = true;

                            //desde donde se envia
                            msg.From = new System.Net.Mail.MailAddress("ciencias.sitemas.usac@gmail.com");

                            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
                            cliente.Credentials = new System.Net.NetworkCredential("ciencias.sitemas.usac@gmail.com", "introduccionalaprogramacion2");
                            cliente.Port = 587;
                            cliente.EnableSsl = true;

                            cliente.Host = "smtp.gmail.com";

                            try
                            {
                                cliente.Send(msg);
                                MessageBox.Show("SE HA ENVIADO LA CONTRASEÑA A SU CORREO!");
                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show("Error al Enviar, pueda que el correo no exista!" + ex.ToString());
                            }
                        }
                        else
                        {
                            MessageBox.Show("DATOS INCORRECTOS");
                        }
                    }
                    else
                    {
                        MessageBox.Show("CARNET INCORRECTO");
                    
                    }
                }
                else if (rolBuscar.Value.ToString() == "Estudiante")
                {
                    if (bd.validacion_carnetEstudiante(txtcarnetBuscar.Text) > 0)
                    {
                        if (bd.validacion_recuperarcontra_estudiante(txtcarnetBuscar.Text, txtPalabra.Text) > 0)
                        {
                            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
                            msg.To.Add(txtCorreo.Text);
                            msg.Subject = "RECUPERAR CONTRASEÑA (PLATAFORMA CIENCIAS Y SISTEMAS USAC)";
                            msg.SubjectEncoding = System.Text.Encoding.UTF8;

                            //cuerpo de mensaje
                            cuerpo += bd.contra_recuperada_adminoperador(txtcarnetBuscar.Text, txtPalabra.Text);
                            msg.Body = cuerpo;
                            msg.BodyEncoding = System.Text.Encoding.UTF8;
                            msg.IsBodyHtml = true;

                            //desde donde se envia
                            msg.From = new System.Net.Mail.MailAddress("ciencias.sitemas.usac@gmail.com");

                            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
                            cliente.Credentials = new System.Net.NetworkCredential("ciencias.sitemas.usac@gmail.com", "introduccionalaprogramacion2");
                            cliente.Port = 587;
                            cliente.EnableSsl = true;

                            cliente.Host = "smtp.gmail.com";

                            try
                            {
                                cliente.Send(msg);
                                MessageBox.Show("SE HA ENVIADO LA CONTRASEÑA A SU CORREO!");
                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show("Error al Enviar, pueda que el correo no exista!" + ex.ToString());
                            }
                        }
                        else
                        {
                            MessageBox.Show("DATOS INCORRECTOS");
                        }
                    }
                    else
                    {
                        MessageBox.Show("CARNET INCORRECTO");
                    
                    }
                }
            }
        }

    }
}