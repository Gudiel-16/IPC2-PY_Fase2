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
    public partial class registroEstudiante : System.Web.UI.Page
    {
        conexion_metodos bd = new conexion_metodos();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bttRegistrar_Click(object sender, EventArgs e)
        {
            if (txtCarnet.Text=="" || txtNombre.Text=="" || txtFechanac.Text=="" || txtCorreo.Text=="" || txtTelefono.Text=="" || txtUsuario.Text=="" || txtpassword.Text=="" || txtRepetirpassword.Text=="" || txtPalabraclave.Text=="")
            {
                MessageBox.Show("HAY CAMPOS VACIOS!");
            }
            else
            {
                if (txtpassword.Text.Equals(txtRepetirpassword.Text))// si las contras coinciden
                {

                    if (bd.validacion_carnet_usuario_estudiante(txtCarnet.Text,txtUsuario.Text)>0)//si ya existe ese carnet o usuario
                    {
                        MessageBox.Show("CARNET O USUARIO INCORRECTO!");
                    }
                    else
                    {
                        bd.insertar_estudiante(txtCarnet.Text,"Estudiante",txtNombre.Text,txtFechanac.Text,txtCorreo.Text,txtTelefono.Text,txtUsuario.Text,txtpassword.Text,txtPalabraclave.Text);
                        MessageBox.Show("CUENTA CREADA CON EXITO");
                        Response.Redirect("/interfaz/registroEstudiante.aspx");
                    }
                }
                else
                {
                    MessageBox.Show("LAS CONTRASEÑAS NO COINCIDEN!");
                }
            }
        }
        
        
     }
}