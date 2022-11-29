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
    public partial class administradorModificarUsuario : System.Web.UI.Page
    {

        conexion_metodos bd = new conexion_metodos();
        protected void Page_Load(object sender, EventArgs e)
        {
            //para que los texbox no tengan historial
            txtCarnet.Attributes.Add("autocomplete", "off");
            txtcarnetBuscar.Attributes.Add("autocomplete", "off");
            txtContraBuscar.Attributes.Add("autocomplete", "off");
            txtContraseña.Attributes.Add("autocomplete", "off");
            txtCorreo.Attributes.Add("autocomplete", "off");
            txtFechanac.Attributes.Add("autocomplete", "off");
            txtNombre.Attributes.Add("autocomplete", "off");
            txtPalabraclave.Attributes.Add("autocomplete", "off");
            txtRepetirContra.Attributes.Add("autocomplete", "off");
            txtrol.Attributes.Add("autocomplete", "off");
            txtTelefono.Attributes.Add("autocomplete", "off");
            txtUsuario.Attributes.Add("autocomplete", "off");
        }

        protected void bttbuscar_Click(object sender, EventArgs e)
        {
            if (txtcarnetBuscar.Text=="" || txtContraBuscar.Text=="")
            {
                MessageBox.Show("DEBE INGRESAR LOS DATOS!");
            }
            else
            {
                if (rolbuscar.Value.ToString() == "Administrador" || rolbuscar.Value.ToString() == "Operador")
                {
                    if(bd.validacion_carnet_contra_adminitrador(txtcarnetBuscar.Text,txtContraBuscar.Text)>0){//si me encuentra al usuario
                        //me llana los campos de texto
                        bd.llenar_TextBox_adminoperador(txtcarnetBuscar.Text,txtContraBuscar.Text,txtrol,txtCarnet,txtNombre,txtFechanac,txtCorreo,txtTelefono,txtUsuario,txtContraseña,txtRepetirContra,txtPalabraclave);
                    }
                    else
                    {
                        MessageBox.Show("EL USUARIO NO EXISTE!");
                    }
                }
                else if (rolbuscar.Value.ToString() == "Docente" || rolbuscar.Value.ToString() == "Auxiliar" || rolbuscar.Value.ToString() == "Conferencista")
                {
                    if (bd.validacion_carnet_contra_instructor(txtcarnetBuscar.Text,txtContraBuscar.Text)>0)
                    {
                        bd.llenar_TextBox_instructor(txtcarnetBuscar.Text,txtContraBuscar.Text,txtrol,txtCarnet,txtNombre,txtFechanac,txtCorreo,txtTelefono,txtUsuario,txtContraseña,txtRepetirContra,txtPalabraclave);
                    }
                    else
                    {
                        MessageBox.Show("EL USUARIO NO EXISTE!");
                    }
                }
                else if (rolbuscar.Value.ToString() == "Estudiante")
                {
                    if (bd.validacion_carnet_contra_estudiante(txtcarnetBuscar.Text,txtContraBuscar.Text)>0)
                    {
                        bd.llenar_TextBox_estudiante(txtcarnetBuscar.Text,txtContraBuscar.Text,txtrol,txtCarnet,txtNombre,txtFechanac,txtCorreo,txtTelefono,txtUsuario,txtContraseña,txtRepetirContra,txtPalabraclave);
                    }
                    else
                    {
                        MessageBox.Show("EL USUARIO NO EXISTE!");
                    }
                }
            }
        }

        protected void bttmodificar_Click(object sender, EventArgs e)
        {
            if (txtCarnet.Text == "" || txtNombre.Text == ""  || txtFechanac.Text == "" || txtCorreo.Text == "" || txtTelefono.Text == "" || txtUsuario.Text == "" || txtContraseña.Text == "" || txtRepetirContra.Text == "" || txtPalabraclave.Text == "")
            {
                MessageBox.Show("HAY CAMPOS VACIOS!");
            }
            else
            {
                if (txtContraseña.Text.Equals(txtRepetirContra.Text))// si las contras coinciden
                {
                    if (rolbuscar.Value.ToString() == "Administrador" || rolbuscar.Value.ToString() == "Operador")//si es admin o operador
                    {
                        
                        bd.actualizar_adminoperador(txtCarnet.Text, txtNombre.Text,txtFechanac.Text, txtCorreo.Text, txtTelefono.Text, txtUsuario.Text, txtContraseña.Text, txtPalabraclave.Text);
                        MessageBox.Show("USUARIO MODIFICADO CON EXITO!");
                        Response.Redirect("/interfaz/administrador/administradorModificarUsuario.aspx");
                    
                    }
                    else if (rolbuscar.Value.ToString() == "Docente" || rolbuscar.Value.ToString() == "Auxiliar" || rolbuscar.Value.ToString() == "Conferencista") //si es instructor
                    {
                        bd.actualizar_instructor(txtCarnet.Text, txtNombre.Text, txtFechanac.Text, txtCorreo.Text, txtTelefono.Text, txtUsuario.Text, txtContraseña.Text, txtPalabraclave.Text);
                        MessageBox.Show("USUARIO MODIFICADO CON EXITO!");
                        Response.Redirect("/interfaz/administrador/administradorModificarUsuario.aspx");
                    
                    }
                    else if (rolbuscar.Value.ToString() == "Estudiante")
                    {
                        bd.actualizar_estudiante(txtCarnet.Text, txtNombre.Text, txtFechanac.Text, txtCorreo.Text, txtTelefono.Text, txtUsuario.Text, txtContraseña.Text, txtPalabraclave.Text);
                        MessageBox.Show("USUARIO MODIFICADO CON EXITO!");
                        Response.Redirect("/interfaz/administrador/administradorModificarUsuario.aspx");
                    
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