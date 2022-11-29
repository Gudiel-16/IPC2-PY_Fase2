using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto_201404278.base_de_datos;

namespace Proyecto_201404278.interfaz
{
    public partial class administradorVerUsuarios : System.Web.UI.Page
    {
        conexion_metodos bd = new conexion_metodos();
        protected void Page_Load(object sender, EventArgs e)
        {
            bd.mostrar_adminoperadores(gvAdminOperadores);
            bd.mostrar_instructores(gvInstructores);
            bd.mostrar_estudiantes(gvEstudiantes);
        }
    }
}