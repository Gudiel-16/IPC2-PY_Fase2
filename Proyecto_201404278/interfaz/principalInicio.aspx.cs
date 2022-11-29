using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Proyecto_201404278.interfaz;
using Proyecto_201404278.base_de_datos;

namespace Proyecto_201404278.interfaz
{
    public partial class principalInicio : System.Web.UI.Page
    {

        conexion_metodos coxm = new conexion_metodos(); 
        protected void Page_Load(object sender, EventArgs e)
        {
             
        }

        
        
        protected void bttacceder_Click(object sender, EventArgs e)
        {

            if (txtCarnet.Text=="" || txtContra.Text=="")//si hay campos vacios
            {
                MessageBox.Show("HAY CAMPOS VACIOS");
            }
            else
            {
                if (rolEntrar.Value.ToString() == "Administrador")//si es administrador
                {
                    if (coxm.validacion_carnet_contra_adminitrador(txtCarnet.Text,txtContra.Text)>0)//si ese usuario existe en BD
                    {
                        Session["Login"] = txtCarnet.Text;
                        Response.Redirect("/interfaz/administrador/principalAdministrador.aspx"); 
                    }
                    else
                    {
                        MessageBox.Show("USUARIO O CONTRASEÑA INCORRECTA");
                    }
                }
                else if (rolEntrar.Value.ToString() == "Operador") //si es operador
                {
                    if (coxm.validacion_carnet_contra_adminitrador(txtCarnet.Text, txtContra.Text) > 0)//si ese usuario existe en BD
                    {
                        Session["Login"] = txtCarnet.Text;
                        Response.Redirect("/interfaz/operador/principalOperador.aspx");
                    }
                    else
                    {
                        MessageBox.Show("USUARIO O CONTRASEÑA INCORRECTA");
                    }
                }//si es instructor
                else if (rolEntrar.Value.ToString() == "Docente" || rolEntrar.Value.ToString() == "Auxiliar" || rolEntrar.Value.ToString() == "Conferencista")
                {
                    if (coxm.validacion_carnet_contra_instructor(txtCarnet.Text, txtContra.Text) > 0)//si ese usuario existe en BD
                    {
                        Session["Login"] = txtCarnet.Text;
                        Response.Redirect("/interfaz/instructor/principalInstructor.aspx");
                    }
                    else
                    {
                        MessageBox.Show("USUARIO O CONTRASEÑA INCORRECTA");
                    }
                }
                else if (rolEntrar.Value.ToString() == "Estudiante")//si es estudiante
                {
                    if (coxm.validacion_carnet_contra_estudiante(txtCarnet.Text, txtContra.Text) > 0)//si ese usuario existe en BD
                    {
                        Session["Login"] = txtCarnet.Text;
                        Response.Redirect("/interfaz/estudiante/principalEstudiante.aspx");
                    }
                    else
                    {
                        MessageBox.Show("USUARIO O CONTRASEÑA INCORRECTA");
                    }
                }
            }

        }

        
    }
}