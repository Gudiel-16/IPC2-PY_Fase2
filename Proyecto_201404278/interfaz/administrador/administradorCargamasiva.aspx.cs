using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto_201404278.base_de_datos;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.IO;

namespace Proyecto_201404278.interfaz
{
    public partial class administradorCargamasiva : System.Web.UI.Page
    {
        
        conexion_metodos bd = new conexion_metodos();
        DataTable dt1 = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {

          
        }

        //boton para cargar el archivo
        protected void bttabrir2_Click(object sender, EventArgs e)
        {
            if (cargar.HasFile)
            {
                string filename = cargar.FileName;

                //Enviar el Archivo a un Directorio de forma Temporal
                cargar.SaveAs(Server.MapPath("/" + filename));

                //Importar el Archivo Excel a un Gridview con el Metodo ExportToGrid
                ExportToGrid(Server.MapPath("/" + filename), Path.GetExtension(Server.MapPath("/" + filename)));
 
            }
        }
    
        //metodo para que los datos pasen de excel a GridView
        protected void cargar_Click(object sender, EventArgs e)
        {
            string fileExt = System.IO.Path.GetExtension(cargar.FileName);
  
        }

        void ExportToGrid(String path, String Extension)
        {
            OleDbConnection MiConexion = null;
            DataSet DtSet = null;
            OleDbDataAdapter MiComando = null;


            if (Extension == ".xls")
            {
                //Conexion para Formato .xls 2003
                MiConexion = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0; Data Source='" + path + "';Extended Properties=Excel 8.0;");
            }

            else if (Extension == ".xlsx")
            {
                //Conexion para Formato .xlsx 2007 o 2010
                MiConexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + path + "';Extended Properties=Excel 12.0 Xml;");
            }

            //Seleccionar el archivo Excel
            MiConexion.Open();
            DataTable Datable = new DataTable();

            //Seleccionar la Hoja que Esta Activa
            Datable = MiConexion.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            String Nombre_Hoja = Datable.Rows[0]["TABLE_NAME"].ToString();


            MiComando = new System.Data.OleDb.OleDbDataAdapter("select * from [" + Nombre_Hoja + "]", MiConexion);
            DtSet = new System.Data.DataSet();
            //Bindear todo el Contenido del Excel a un Dataset
            MiComando.Fill(DtSet, "[" + Nombre_Hoja + "]");
            dt1 = DtSet.Tables[0];
            MiConexion.Close();
            
            //Verificar si el Datatable Contiene Valores
            if (dt1.Rows.Count > 0)
            {
                GridView GridView2 = new GridView();
                GridView2.DataSource = dt1;
                GridView2.DataBind();
               
                try
                {
                    Label2.Text = mostrarDatos(GridView2);//el label toma el valor de la sintaxis de la tabla
                    
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("aa");
                    
                }

                
            }
            
            //Eliminar el Archivo Excel del Directorio Temporal
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            //Vaciar El Dataset y los Datatable
            dt1 = null;
            DtSet = null;
            Datable = null;
        }

        //metodo para mostrar los datos en el label
        public string mostrarDatos(GridView tabla)
        {
            
            string datos = "<table><tr>  <td> Carnet </td><td>  Nombre Y Apellido  </td> <td> Fecha de Nacimiento </td><td> Email </td><td> Telefono </td><td> Usuario </td><td> Contra  </td><td>Palabra Clave</td></tr>";
            
            foreach (GridViewRow row in tabla.Rows)
            {
                
                    datos += "<tr>  <td> " + row.Cells[0].Text + "</td><td>" + row.Cells[1].Text + "</td><td>" + row.Cells[2].Text + "</td> <td>" + row.Cells[3].Text + "</td><td>" + row.Cells[4].Text + "</td><td>" + row.Cells[5].Text + "</td><td>" + row.Cells[6].Text + "</td><td>" + row.Cells[7].Text + "</tr>";
                    bd.insertar_estudiante(row.Cells[0].Text, "Estudiante", row.Cells[1].Text, row.Cells[2].Text, row.Cells[3].Text, row.Cells[4].Text, row.Cells[5].Text, row.Cells[6].Text, row.Cells[7].Text);
            }

            datos += "</table>";

            return datos;
        }



    }
}