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
    public partial class administradorRegistrarUsuario : System.Web.UI.Page
    {
        conexion_metodos bd = new conexion_metodos();
        protected void Page_Load(object sender, EventArgs e)
        {
            //para que no alla historial en el texbox
            txtCarnet.Attributes.Add("autocomplete", "off");
            txtCorreo.Attributes.Add("autocomplete", "off");
            txtFechanac.Attributes.Add("autocomplete", "off");
            txtNombre.Attributes.Add("autocomplete", "off");
            txtPalabraclave.Attributes.Add("autocomplete", "off");
            txtpassword.Attributes.Add("autocomplete", "off");
            txtRepetirpassword.Attributes.Add("autocomplete", "off");
            txtTelefono.Attributes.Add("autocomplete", "off");
            txtUsuario.Attributes.Add("autocomplete", "off");

        }

        protected void bttregistrar_Click(object sender, EventArgs e)
        {
            if (txtCarnet.Text == "" || txtNombre.Text == "" || txtFechanac.Text == "" || txtCorreo.Text == "" || txtTelefono.Text == "" || txtUsuario.Text == "" || txtpassword.Text == "" || txtRepetirpassword.Text == "" || txtPalabraclave.Text == "")
            {
                MessageBox.Show("HAY CAMPOS VACIOS!");
            }
            else
            {
                if (txtpassword.Text.Equals(txtRepetirpassword.Text))// si las contras coinciden
                {
                    if (rolEntrar.Value.ToString()=="Administrador" || rolEntrar.Value.ToString()=="Operador")//si es admin o operador
                    {
                        if (bd.validacion_carnet_usuario_adminoperador(txtCarnet.Text, txtUsuario.Text)>0) //se verifica si ya existe ese carnet o usuario
                        {
                            MessageBox.Show("CARNET O USUARIO INCORRECTO!");
                        }
                        else
                        {
                            bd.insertar_admin_operador(txtCarnet.Text,rolEntrar.Value.ToString(), txtNombre.Text, txtFechanac.Text, txtCorreo.Text, txtTelefono.Text, txtUsuario.Text, txtpassword.Text, txtPalabraclave.Text);
                            MessageBox.Show("USUARIO CREADO CON EXITO!");
                            Response.Redirect("/interfaz/administrador/administradorRegistrarUsuario.aspx");
                        }
                    }
                    else if (rolEntrar.Value.ToString() == "Docente" || rolEntrar.Value.ToString() == "Auxiliar" || rolEntrar.Value.ToString() == "Conferencista") //si es instructor
                    {
                        if (bd.validacion_carnet_usuario_instructor(txtCarnet.Text, txtUsuario.Text) > 0) //se verifica si ya existe ese carnet o usuario
                        {
                            MessageBox.Show("CARNET O USUARIO INCORRECTO!");
                        }
                        else
                        {
                            bd.insertar_instructor(txtCarnet.Text, rolEntrar.Value.ToString(), txtNombre.Text, txtFechanac.Text, txtCorreo.Text, txtTelefono.Text, txtUsuario.Text, txtpassword.Text, txtPalabraclave.Text);
                            MessageBox.Show("USUARIO CREADO CON EXITO!");
                            Response.Redirect("/interfaz/administrador/administradorRegistrarUsuario.aspx");
                        }
                    }
                    else if (rolEntrar.Value.ToString() == "Estudiante")
                    {
                        if (bd.validacion_carnet_usuario_estudiante(txtCarnet.Text, txtUsuario.Text) > 0)//si ya existe ese carnet o usuario
                        {
                            MessageBox.Show("CARNET O USUARIO INCORRECTO!");
                        }
                        else
                        {
                            bd.insertar_estudiante(txtCarnet.Text, rolEntrar.Value.ToString(), txtNombre.Text, txtFechanac.Text, txtCorreo.Text, txtTelefono.Text, txtUsuario.Text, txtpassword.Text, txtPalabraclave.Text);
                            MessageBox.Show("USUARIO CREADO CON EXITO!");
                            Response.Redirect("/interfaz/administrador/administradorRegistrarUsuario.aspx");
                        }
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