using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.OleDb;


namespace Proyecto_201404278.base_de_datos
{
    public class conexion_metodos
    {

        SqlConnection cn; //para realizar la conexion
        SqlCommand cmd; //para permitir hacer sentencias con SQL
        SqlDataReader dr;
        //SqlDataAdapter da;
        //DataTable dt;

        //metodo para crear nuestra conexion
        public conexion_metodos()
        {
            try
            {
                cn = new SqlConnection("Data Source=GUDIEL-PC\\SQLEXPRESS;Initial Catalog=Plataforma_CienciasSistemas_USAC;Integrated Security=True");
                cn.Open();
                MessageBox.Show("Conexion con SQL SERVER establecida!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conecto con SQL SERVER " + ex.ToString());
            }

        }

//----------------------------------------------------------------------PARA INSERTAR--------------------------------------------------------------------------------

        //PARA INSERTAR USUARIOS TIPO ADMINISTRADOR O OPERADOR
        public string insertar_admin_operador(string carnet, string rol, string nombre_apellido, string fecha_nacimiento, string email, string telefono, string usuario, string contra, string palabra_clave)
        {
            string salida = "Usuario registrado";
            try
            {
                cmd = new SqlCommand("Insert into administrador_operador(carnet_admin_operador,tipo_admin_operador, nombre_apellido,fecha_nacimiento,email,telefono,usuario,contra,palabra_clave) values('" + carnet + "','" + rol + "','" + nombre_apellido + "','"  + fecha_nacimiento + "','" + email + "','" + telefono + "','" + usuario + "','" + contra + "','"  + palabra_clave + "')", cn);
                cmd.ExecuteNonQuery();//para que se realice nuestra sentencia SQL
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }

        //PARA INSERTAR USUARIOS TIPO INSTRUCTOR
        public string insertar_instructor(string carnet, string rol, string nombre_apellido, string fecha_nacimiento, string email, string telefono, string usuario, string contra, string palabra_clave)
        {
            string salida = "Usuario registrado";
            try
            {
                cmd = new SqlCommand("Insert into instructor(carnet_instructor,tipo_instructor, nombre_apellido,fecha_nacimiento,email,telefono,usuario,contra,palabra_clave) values('" + carnet + "','" + rol + "','" + nombre_apellido + "','" + fecha_nacimiento + "','" + email + "','" + telefono + "','" + usuario + "','" + contra + "','"  + palabra_clave + "')", cn);
                cmd.ExecuteNonQuery();//para que se realice nuestra sentencia SQL
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
                MessageBox.Show(salida);
            }
            return salida;
        }

        //PARA INSERTAR USUARIOS TIPO ESTUDIANTE
        public string insertar_estudiante(string carnet, string rol ,string nombre_apellido, string fecha_nacimiento, string email, string telefono, string usuario, string contra, string palabra_clave)
        {
            string salida = "USUARIO REGISTRADO";
            try
            {
                cmd = new SqlCommand("Insert into estudiante(carnet_estudiante,tipo_estudiante, nombre_apellido,fecha_nacimiento,email,telefono,usuario,contra,palabra_clave) values('" + carnet + "','" + rol + "','" + nombre_apellido + "','" + fecha_nacimiento + "','" + email + "','" + telefono + "','" + usuario + "','" + contra + "','" + palabra_clave + "')", cn);
                cmd.ExecuteNonQuery();//para que se realice nuestra sentencia SQL
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }

        //PARA INSERTAR FECHA RESTRINGIDA
        public string insertar_fecha_restringida(string fecha_inicio, string fecha_final, string descripcion, string quien_registra)
        {
            string salida = "FECHA AGREGADA";
            try
            {
                cmd = new SqlCommand("Insert into fecha_restringida(fecha_inicio,fecha_final, descripcion, carnet_admin_operador) values('" + fecha_inicio + "','" + fecha_final + "','" + descripcion + "','" + quien_registra + "')", cn);
                cmd.ExecuteNonQuery();//para que se realice nuestra sentencia SQL
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }

        //PARA INSERTAR SALON
        public string insertar_salon(string edificio, string nivel, string numero_salon, string de_baja, string estado)
        {
            string salida = "SALON AGREGADO";
            try
            {
                cmd = new SqlCommand("Insert into salon(edificio,nivel, numero_salon, de_baja,estado) values('" + edificio + "','" + nivel + "','" + numero_salon + "','" + de_baja + "','" + estado + "')", cn);
                cmd.ExecuteNonQuery();//para que se realice nuestra sentencia SQL
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }

        //PARA INSERTAR INSUMO
        public string insertar_insumo(string nombre)
        {
            string salida = "INSUMO AGREGADO";
            try
            {
                cmd = new SqlCommand("Insert into insumo(nombre) values('" + nombre + "')", cn);
                cmd.ExecuteNonQuery();//para que se realice nuestra sentencia SQL
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }

        //PARA INSERTAR REPORTE_INCIDENTE_INSTRUCTOR_SALON
        public string inserta_reporte_intructor_salon(string tipo_incidente_salon, string descripcion, string resuelto, string fecha, string hora,string carnet_instructor, string codigo_salon, string quien_registra)
        {
            string salida = "REPORTE AGREGADO";
            try
            {
                cmd = new SqlCommand("Insert into reporte_incidente_instructor_salon(tipo_incidente_salon,tipo_incidente, resuelto, fecha,hora,carnet_instructor,codigo_salon,carnet_admin_operador) values('" + tipo_incidente_salon + "','" + descripcion + "','" + resuelto + "','" + fecha + "','" + hora + "','" + carnet_instructor + "','" + codigo_salon + "','" + quien_registra + "')", cn);
                cmd.ExecuteNonQuery();//para que se realice nuestra sentencia SQL
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }

        //PARA INSERTAR PRESTAMO INSTRUCTOR
        public string inserta_prestamo_instructor(string fecha, string hora, string entregado, string carnet_instructor, string codigo_insumo, string quien_registra)
        {
            string salida = "REPORTE AGREGADO";
            try
            {
                cmd = new SqlCommand("Insert into prestamo_instructor(fecha,hora,entregado,carnet_instructor,codigo_insumo,carnet_admin_operador) values('" + fecha + "','" + hora + "','" + entregado + "','" + carnet_instructor + "','" + codigo_insumo + "','" + quien_registra + "')", cn);
                cmd.ExecuteNonQuery();//para que se realice nuestra sentencia SQL
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }

        //PARA INSERTAR REPORTE_INCIDENTE_INSTRUCTOR_INSUMO
        public string inserta_reporte_intructor_insumo(string tipo_incidente_insumo, string descripcion, string resuelto, string fecha, string hora, string carnet_instructor, string codigo_salon, string quien_registra)
        {
            string salida = "REPORTE AGREGADO";
            try
            {
                cmd = new SqlCommand("Insert into reporte_incidente_instructor_insumo(tipo_incidente_insumo,tipo_incidente, resuelto, fecha,hora,carnet_instructor,codigo_insumo,carnet_admin_operador) values('" + tipo_incidente_insumo + "','" + descripcion + "','" + resuelto + "','" + fecha + "','" + hora + "','" + carnet_instructor + "','" + codigo_salon + "','" + quien_registra + "')", cn);
                cmd.ExecuteNonQuery();//para que se realice nuestra sentencia SQL
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }

        //PARA ENTREGA PRESTAMO_INSTRUCTOR
        public string inserta_entrega_prestamo_instructor(string fecha, string hora, string codigo_prestamo)
        {
            string salida = "REPORTE AGREGADO";
            try
            {
                cmd = new SqlCommand("Insert into entrega_prestamo_instructor(fecha,hora, codigo_prestamo) values('" + fecha + "','" + hora + "','" + codigo_prestamo + "')", cn);
                cmd.ExecuteNonQuery();//para que se realice nuestra sentencia SQL
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }

        //PARA INSERTAR PRESTAMO ESTUDIANTE
        public string inserta_prestamo_estudiante(string fecha, string hora, string entregado, string carnet_estudiante, string codigo_insumo, string quien_registra)
        {
            string salida = "REPORTE AGREGADO";
            try
            {
                cmd = new SqlCommand("Insert into prestamo_estudiante(fecha,hora,entregado,carnet_estudiante,codigo_insumo,carnet_admin_operador) values('" + fecha + "','" + hora + "','" + entregado + "','" + carnet_estudiante + "','" + codigo_insumo + "','" + quien_registra + "')", cn);
                cmd.ExecuteNonQuery();//para que se realice nuestra sentencia SQL
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }

        //PARA INSERTAR REPORTE_INCIDENTE_ESTUDIANTE_INSUMO
        public string inserta_reporte_estudiante_insumo(string tipo_incidente_insumo, string descripcion, string resuelto, string fecha, string hora, string carnet_estudiante, string codigo_salon, string quien_registra)
        {
            string salida = "REPORTE AGREGADO";
            try
            {
                cmd = new SqlCommand("Insert into reporte_incidente_estudiante_insumo(tipo_incidente_insumo,tipo_incidente, resuelto, fecha,hora,carnet_estudiante,codigo_insumo,carnet_admin_operador) values('" + tipo_incidente_insumo + "','" + descripcion + "','" + resuelto + "','" + fecha + "','" + hora + "','" + carnet_estudiante + "','" + codigo_salon + "','" + quien_registra + "')", cn);
                cmd.ExecuteNonQuery();//para que se realice nuestra sentencia SQL
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }

        //PARA ENTREGA PRESTAMO_ESTUDIANTE
        public string inserta_entrega_prestamo_estudiante(string fecha, string hora, string codigo_prestamo)
        {
            string salida = "REPORTE AGREGADO";
            try
            {
                cmd = new SqlCommand("Insert into entrega_prestamo_estudiante(fecha,hora, codigo_prestamo) values('" + fecha + "','" + hora + "','" + codigo_prestamo + "')", cn);
                cmd.ExecuteNonQuery();//para que se realice nuestra sentencia SQL
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }

       //PARA INSERTAR IMAGEN QR
        public string inserta_imagen_qr(string codigo,byte[] imagen)
        {
            string salida = "REPORTE AGREGADO";
            try
            {
                //cmd = new SqlCommand("Insert into codigo_QR(codigo_qr,imagen) values('" + codigo + "',@imagen)");
                
                cmd = new SqlCommand("Insert into codigo_QR(codigo_qr,imagen) values(@codigo_qr,@imagen)");
                cmd.Parameters.Add("@codigo_qr", SqlDbType.Text).Value=codigo;
                cmd.Parameters.Add("@imagen",SqlDbType.Image).Value=imagen;
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }

        //PARA CARGAR IMAGEN QR
        public void cargarQR(string codigo, System.Web.UI.WebControls.Repeater repeater)
        {
            try
            {

                ///cmd = new SqlCommand("select imagen from codigo_QR where codigo_qr ='" + codigo + "')", cn);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select codigo_qr,imagen from codigo_QR where codigo_qr='"+codigo+"'";
                //cmd.CommandType = CommandType.Text;
                cmd.Connection = cn;

                DataTable imagen = new DataTable();
                imagen.Load(cmd.ExecuteReader());

                repeater.DataSource = imagen;
                repeater.DataBind();

                //cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
               string salida = "No se conecto: " + ex.ToString();
               MessageBox.Show(salida);
            }
        }

        //PARA CARGAR CARTA ESCANEADA
        public void cargarCartaEscaneada(string codigo, System.Web.UI.WebControls.Repeater repeater)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select carta_escaneada from reserva where codigo_reserva='" + codigo + "'";
                //cmd.CommandType = CommandType.Text;
                cmd.Connection = cn;

                DataTable imagen = new DataTable();
                imagen.Load(cmd.ExecuteReader());

                repeater.DataSource = imagen;
                repeater.DataBind();

                //cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                string salida = "No se conecto: " + ex.ToString();
                MessageBox.Show(salida);
            }
        }


       

        //para INSERTAR reserva
        public string insertar_reserva(string codigo, string actividad, string fechaInicio, string fechaFin, string horaInicio, string horaFin, byte[] carta, string codigoqr, int codigoSalon, string carnetInstructor, string quienrRegistra)
        {
            string salida = "REPORTE AGREGADO";
            try
            {
                
                cmd = new SqlCommand("Insert into reserva(codigo_reserva,tipo_actividad,fecha_inicio,fecha_fin,hora_inicio,hora_fin,carta_escaneada,codigo_qr,codigo_salon,carnet_instructor,carnet_admin_operador) values(@codigo,@actividad,@fechaInicio,@fechaFin,@horaInicio,@horaFin,@carta,@codigoQR,@codigoSalon,@carnetInstructor,@carnetAdOp)");
                
                cmd.Parameters.Add("@codigo", SqlDbType.Text).Value = codigo;
                cmd.Parameters.Add("@actividad", SqlDbType.Text).Value = actividad;
                cmd.Parameters.Add("@fechaInicio", SqlDbType.Date).Value = fechaInicio;
                cmd.Parameters.Add("@fechaFin", SqlDbType.Date).Value = fechaFin;
                cmd.Parameters.Add("@horaInicio", SqlDbType.Time).Value = horaInicio;
                cmd.Parameters.Add("@horaFin", SqlDbType.Time).Value = horaFin;
                cmd.Parameters.Add("@carta", SqlDbType.Image).Value = carta;
                cmd.Parameters.Add("@codigoQR", SqlDbType.Text).Value = codigoqr;
                cmd.Parameters.Add("@codigoSalon", SqlDbType.Int).Value = codigoSalon;
                cmd.Parameters.Add("@carnetInstructor", SqlDbType.Text).Value = carnetInstructor;
                cmd.Parameters.Add("@carnetAdOp", SqlDbType.Text).Value = quienrRegistra;
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
                MessageBox.Show(salida);
            }
            return salida;
        }

        //PARA INSERTAR CURSO 
        public string insertar_curso(string codigocurso, string nombre, string descripcion, byte[] presentacion, string codigoreserva)
        {
            string salida = "REPORTE AGREGADO";
            try
            {

                cmd = new SqlCommand("Insert into curso(codigo_curso,nombre,descripcion,presentacion_pdf,codigo_reserva) values(@codigocurso,@nombre,@descripcion,@presentacion,@codigoreserva)");

                cmd.Parameters.Add("@codigocurso", SqlDbType.VarChar).Value = codigocurso;
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre;
                cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = descripcion;
                cmd.Parameters.Add("@presentacion", SqlDbType.VarBinary).Value = presentacion;
                cmd.Parameters.Add("@codigoreserva", SqlDbType.VarChar).Value = codigoreserva;
               
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
                MessageBox.Show(salida);
            }
            return salida;
        }

        //PARA INSERTAR MATRICULACION 
        public string insertar_matriculacion(string carnet, string codigocurso)
        {
            string salida = "REPORTE AGREGADO";
            try
            {

                cmd = new SqlCommand("Insert into matriculacion(carnet_estudiante,codigo_curso) values(@carnetestudiante,@codigocurso)");

                cmd.Parameters.Add("@carnetestudiante", SqlDbType.VarChar).Value = carnet;
                cmd.Parameters.Add("@codigocurso", SqlDbType.VarChar).Value = codigocurso;
                

                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
                MessageBox.Show(salida);
            }
            return salida;
        }

        //para INSERTAR ASISTENCIA
        public string insertar_asistencia(string codigocurso, string carnetestudiante, string codigoreserva, string fecha, string hora)
        {
            string salida = "REPORTE AGREGADO";
            try
            {

                cmd = new SqlCommand("Insert into asistencia(codigo_curso,carnet_estudiante,codigo_reserva,fecha,hora) values(@codigocurso,@carnet,@codigoreserva,@fecha,@hora)");

                cmd.Parameters.Add("@codigocurso", SqlDbType.VarChar).Value = codigocurso;
                cmd.Parameters.Add("@carnet", SqlDbType.VarChar).Value = carnetestudiante;
                cmd.Parameters.Add("@codigoreserva", SqlDbType.VarChar).Value = codigoreserva;
                cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = fecha;
                cmd.Parameters.Add("@hora", SqlDbType.Time).Value = hora;
                               
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
                MessageBox.Show(salida);
            }
            return salida;
        }

//----------------------------------------------------------------------PARA LLENAR A MODIFICAR--------------------------------------------------------------------------------

        //para llenar los campos cuando busque (ADMINISTRADOR OPERADOR)
        public void llenar_TextBox_adminoperador(string carnet, string contrabusca, System.Web.UI.WebControls.TextBox txtrol, System.Web.UI.WebControls.TextBox txtcarnet, System.Web.UI.WebControls.TextBox txtnombre_apellido, System.Web.UI.WebControls.TextBox txtfecha, System.Web.UI.WebControls.TextBox txtcorreo, System.Web.UI.WebControls.TextBox txttelefono, System.Web.UI.WebControls.TextBox txtusuario, System.Web.UI.WebControls.TextBox txtcontra, System.Web.UI.WebControls.TextBox txtrepetircontra, System.Web.UI.WebControls.TextBox txtpalabraclave)
        {
            try
            {
                cmd = new SqlCommand("Select * from administrador_operador where carnet_admin_operador='" + carnet + "' and contra='" + contrabusca + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                { //cuento encuentre el registro me llena los campos
                    txtrol.Text = dr["tipo_admin_operador"].ToString();
                    txtcarnet.Text = dr["carnet_admin_operador"].ToString();
                    txtnombre_apellido.Text = dr["nombre_apellido"].ToString();
                    txtfecha.Text = dr["fecha_nacimiento"].ToString();
                    txtcorreo.Text = dr["email"].ToString();
                    txttelefono.Text = dr["telefono"].ToString();
                    txtusuario.Text = dr["usuario"].ToString();
                    txtcontra.Text = dr["contra"].ToString();
                    txtrepetircontra.Text = dr["contra"].ToString();
                    txtpalabraclave.Text = dr["palabra_clave"].ToString();
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron llenar los campos: " + ex.ToString());
            }
        }

        //para llenar los campos cuando busque (INSTRUCTOR)
        public void llenar_TextBox_instructor(string carnet, string contrabusca, System.Web.UI.WebControls.TextBox txtrol, System.Web.UI.WebControls.TextBox txtcarnet, System.Web.UI.WebControls.TextBox txtnombre_apellido, System.Web.UI.WebControls.TextBox txtfecha, System.Web.UI.WebControls.TextBox txtcorreo, System.Web.UI.WebControls.TextBox txttelefono, System.Web.UI.WebControls.TextBox txtusuario, System.Web.UI.WebControls.TextBox txtcontra, System.Web.UI.WebControls.TextBox txtrepetircontra, System.Web.UI.WebControls.TextBox txtpalabraclave)
        {
            try
            {
                cmd = new SqlCommand("Select * from instructor where carnet_instructor='" + carnet + "' and contra='" + contrabusca + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                { //cuento encuentre el registro me llena los campos
                    txtrol.Text = dr["tipo_instructor"].ToString();
                    txtcarnet.Text = dr["carnet_instructor"].ToString();
                    txtnombre_apellido.Text = dr["nombre_apellido"].ToString();
                    txtfecha.Text = dr["fecha_nacimiento"].ToString();
                    txtcorreo.Text = dr["email"].ToString();
                    txttelefono.Text = dr["telefono"].ToString();
                    txtusuario.Text = dr["usuario"].ToString();
                    txtcontra.Text = dr["contra"].ToString();
                    txtrepetircontra.Text = dr["contra"].ToString();
                    txtpalabraclave.Text = dr["palabra_clave"].ToString();
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron llenar los campos: " + ex.ToString());
            }
        }

        //para llenar los campos cuando busque (ESTUDIANTE)
        public void llenar_TextBox_estudiante(string carnet, string contrabusca, System.Web.UI.WebControls.TextBox txtrol, System.Web.UI.WebControls.TextBox txtcarnet, System.Web.UI.WebControls.TextBox txtnombre_apellido, System.Web.UI.WebControls.TextBox txtfecha, System.Web.UI.WebControls.TextBox txtcorreo, System.Web.UI.WebControls.TextBox txttelefono, System.Web.UI.WebControls.TextBox txtusuario, System.Web.UI.WebControls.TextBox txtcontra, System.Web.UI.WebControls.TextBox txtrepetircontra, System.Web.UI.WebControls.TextBox txtpalabraclave)
        {
            try
            {
                cmd = new SqlCommand("Select * from estudiante where carnet_estudiante='" + carnet + "' and contra='" + contrabusca + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                { //cuento encuentre el registro me llena los campos
                    txtrol.Text = dr["tipo_estudiante"].ToString();
                    txtcarnet.Text = dr["carnet_estudiante"].ToString();
                    txtnombre_apellido.Text = dr["nombre_apellido"].ToString();
                    txtfecha.Text = dr["fecha_nacimiento"].ToString();
                    txtcorreo.Text = dr["email"].ToString();
                    txttelefono.Text = dr["telefono"].ToString();
                    txtusuario.Text = dr["usuario"].ToString();
                    txtcontra.Text = dr["contra"].ToString();
                    txtrepetircontra.Text = dr["contra"].ToString();
                    txtpalabraclave.Text = dr["palabra_clave"].ToString();
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron llenar los campos: " + ex.ToString());
            }
        }

        //para llenar los campos cuando busque SALON
        public void llenar_TextBox_salon(int codigo,  System.Web.UI.WebControls.TextBox txtedificio, System.Web.UI.WebControls.TextBox txtnivel, System.Web.UI.WebControls.TextBox txtNumSalon, System.Web.UI.WebControls.TextBox txtDebaja, System.Web.UI.WebControls.TextBox txtEstado)
        {
            try
            {
                cmd = new SqlCommand("Select * from salon where codigo_salon=" + codigo , cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                { //cuento encuentre el registro me llena los campos
                    txtedificio.Text = dr["edificio"].ToString();
                    txtnivel.Text = dr["nivel"].ToString();
                    txtNumSalon.Text = dr["numero_salon"].ToString();
                    txtDebaja.Text = dr["de_baja"].ToString();
                    txtEstado.Text = dr["estado"].ToString();
                    
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron llenar los campos: " + ex.ToString());
            }
        }

        //para llenar los campos cuando busque Reserva (A ELIMINAR)
        public void llenar_TextBox_Reserva(string codigo, System.Web.UI.WebControls.TextBox txtcarnet, System.Web.UI.WebControls.TextBox txtactividad, System.Web.UI.WebControls.TextBox txtsalon, System.Web.UI.WebControls.TextBox txtfechainicio, System.Web.UI.WebControls.TextBox txtfechafin, System.Web.UI.WebControls.TextBox txthorainicio, System.Web.UI.WebControls.TextBox txthorafin, System.Web.UI.WebControls.TextBox txtqr)
        {
            try
            {
                cmd = new SqlCommand("Select * from reserva where codigo_reserva='" + codigo + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                { //cuento encuentre el registro me llena los campos
                    txtcarnet.Text = dr["carnet_instructor"].ToString();
                    txtactividad.Text = dr["tipo_actividad"].ToString();
                    txtsalon.Text = dr["codigo_salon"].ToString();
                    txtfechainicio.Text = dr["fecha_inicio"].ToString();
                    txtfechafin.Text = dr["fecha_fin"].ToString();
                    txthorainicio.Text = dr["hora_inicio"].ToString();
                    txthorafin.Text = dr["hora_fin"].ToString();
                    txtqr.Text = dr["codigo_qr"].ToString();
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron llenar los campos: " + ex.ToString());
            }
        }

        //para llenar los campos cuando busque Reserva (A MODIFICAR)
        public void llenar_TextBox_Reserva_Modificar(string codigo, System.Web.UI.WebControls.TextBox txtcarnet, System.Web.UI.WebControls.TextBox txtactividad, System.Web.UI.WebControls.TextBox txtsalon, System.Web.UI.WebControls.TextBox txtfechainicio, System.Web.UI.WebControls.TextBox txtfechafin, System.Web.UI.WebControls.TextBox txthorainicio, System.Web.UI.WebControls.TextBox txthorafin, System.Web.UI.WebControls.TextBox txtqr, System.Web.UI.WebControls.TextBox txtquienregistra)
        {
            try
            {
                cmd = new SqlCommand("Select * from reserva where codigo_reserva='" + codigo + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                { //cuento encuentre el registro me llena los campos
                    txtcarnet.Text = dr["carnet_instructor"].ToString();
                    txtactividad.Text = dr["tipo_actividad"].ToString();
                    txtsalon.Text = dr["codigo_salon"].ToString();
                    txtfechainicio.Text = dr["fecha_inicio"].ToString();
                    txtfechafin.Text = dr["fecha_fin"].ToString();
                    txthorainicio.Text = dr["hora_inicio"].ToString();
                    txthorafin.Text = dr["hora_fin"].ToString();
                    txtqr.Text = dr["codigo_qr"].ToString();
                    txtquienregistra.Text = dr["carnet_admin_operador"].ToString();
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron llenar los campos: " + ex.ToString());
            }
        }

//----------------------------------------------------------------------PARA MODIFICAR--------------------------------------------------------------------------------

        //metodo para actualizar (modificar) administrador operador
        public string actualizar_adminoperador(string carnet, string nombre_apellido, string fecha, string correo, string telefono, string usuario, string contra, string palabraclave)
        {
            string salida = "Datos actualizados";
            try
            {
                cmd = new SqlCommand("update administrador_operador set nombre_apellido='" + nombre_apellido  + "' ,fecha_nacimiento='" + fecha + "' ,email='" + correo + "' ,telefono='" + telefono + "' ,usuario='" + usuario + "' ,contra='" + contra + "' ,palabra_clave='" +palabraclave + "' where carnet_admin_operador='" + carnet + "'", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se pudo actualizar: " + ex.ToString();
            }

            return salida;
        }

        //metodo para actualizar (modificar)  Instructor
        public string actualizar_instructor(string carnet, string nombre_apellido, string fecha, string correo, string telefono, string usuario, string contra, string palabraclave)
        {
            string salida = "Datos actualizados";
            try
            {
                cmd = new SqlCommand("update instructor set nombre_apellido='" + nombre_apellido +  "' ,fecha_nacimiento='" + fecha + "' ,email='" + correo + "' ,telefono='" + telefono + "' ,usuario='" + usuario + "' ,contra='" + contra + "' ,palabra_clave='" + palabraclave + "' where carnet_instructor='" + carnet + "'", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se pudo actualizar: " + ex.ToString();
            }

            return salida;
        }

        //metodo para actualizar (modificar) estudiante
        public string actualizar_estudiante(string carnet, string nombre_apellido, string fecha, string correo, string telefono, string usuario, string contra, string palabraclave)
        {
            string salida = "Datos actualizados";
            try
            {
                cmd = new SqlCommand("update estudiante set nombre_apellido='" + nombre_apellido + "' ,fecha_nacimiento='" + fecha + "' ,email='" + correo + "' ,telefono='" + telefono + "' ,usuario='" + usuario + "' ,contra='" + contra + "' ,palabra_clave='" + palabraclave + "' where carnet_estudiante='" + carnet + "'", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se pudo actualizar: " + ex.ToString();
            }

            return salida;
        }

        //metodo para actualizar (modificar) salon
        public string actualizar_salon(int codigo, string edificio, string nivel, string numeroSalon, string deBaja, string estado)
        {
            string salida = "Datos actualizados";
            try
            {
                cmd = new SqlCommand("update salon set edificio='" + edificio + "' ,nivel='" + nivel + "' ,numero_salon='" + numeroSalon + "' ,de_baja='" + deBaja + "' where codigo_salon=" + codigo , cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se pudo actualizar: " + ex.ToString();
            }

            return salida;
        }

        //metodo para actualizar (modificar) estado disponible salon a reservado (cuando se haga reserva)
        public string actualizar_salon_estado(int codigo)
        {
            string salida = "Datos actualizados";
            try
            {
                cmd = new SqlCommand("UPDATE salon set estado='Reserva Previa' where codigo_salon="+ codigo, cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se pudo actualizar: " + ex.ToString();
            }

            return salida;
        }

        //metodo para actualizar (modificar) estado disponible salon a reservado (cuando se haga reserva)
        public string actualizar_salon_estado2(int codigo)
        {
            string salida = "Datos actualizados";
            try
            {
                cmd = new SqlCommand("UPDATE salon set estado='Reserva Completa' where codigo_salon=" + codigo, cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se pudo actualizar: " + ex.ToString();
            }

            return salida;
        }

        //metodo para actualizar (modificar) RESERVA (SIN CARTA)
        public string actualizar_reserva_sin(string codigo, string tipoActividad, string fechaInicio, string fechaFin, string horainicio, string horafin, int codigosalon)
        {
            string salida = "Datos actualizados";
            try
            {
                cmd = new SqlCommand("update reserva set tipo_actividad='" + tipoActividad + "' ,fecha_inicio='" + fechaInicio + "' ,fecha_fin='" + fechaFin +"' ,hora_inicio='" + horainicio + "' ,hora_fin='" + horafin + "' ,codigo_salon=" + codigosalon + " where codigo_reserva='" + codigo + "'", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se pudo actualizar: " + ex.ToString();
            }

            return salida;
        }

        //metodo para actualizar (modificar) RESERVA (CON CARTA)
        public string actualizar_reserva_con(string codigo, string tipoActividad, string fechaInicio, string fechaFin, string horainicio, string horafin, int codigosalon, byte[] carta)
        {
            string salida = "REPORTE AGREGADO";
            try
            {

                cmd = new SqlCommand("update reserva set tipo_actividad=@tipoactividad, fecha_inicio=@fechainicio, fecha_fin=@fechafin,hora_inicio=@horainicio,hora_fin=@horafin, codigo_salon=@codigosalon, carta_escaneada=@carta where codigo_reserva=@codigoreserva");

                cmd.Parameters.Add("@codigoreserva", SqlDbType.VarChar).Value = codigo;
                cmd.Parameters.Add("@tipoactividad", SqlDbType.VarChar).Value = tipoActividad;
                cmd.Parameters.Add("@fechainicio", SqlDbType.Date).Value = fechaInicio;
                cmd.Parameters.Add("@fechafin", SqlDbType.Date).Value = fechaFin;
                cmd.Parameters.Add("@horainicio", SqlDbType.Time).Value = horainicio;
                cmd.Parameters.Add("@horafin", SqlDbType.Time).Value = horafin;
                cmd.Parameters.Add("@codigosalon", SqlDbType.Int).Value = codigosalon;
                cmd.Parameters.Add("@carta", SqlDbType.Image).Value = carta;
                
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
                MessageBox.Show(salida);
            }
            return salida;
        }
//----------------------------------------------------------------------PARA ELIMINAR--------------------------------------------------------------------------------

        //metodo para eliminar un registro ADMINISTRADOR OPERADOR
        public string eliminar_adminoperador(string carnet)
        {
            string salida = "Registro eliminado";
            try
            {
                cmd = new SqlCommand("delete from administrador_operador where carnet_admin_operador='" + carnet + "'", cn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                salida = "No se pudo eliminar el registro: " + ex.ToString();
            }

            return salida;
        }

        //metodo para eliminar un registro INSTRUCTOR
        public string eliminar_instructor(string carnet)
        {
            string salida = "Registro eliminado";
            try
            {
                cmd = new SqlCommand("delete from instructor where carnet_instructor='" + carnet + "'", cn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                salida = "No se pudo eliminar el registro: " + ex.ToString();
            }

            return salida;
        }

        //metodo para eliminar un registro ESTUDIANTE
        public string eliminar_estudiante(string carnet)
        {
            string salida = "Registro eliminado";
            try
            {
                cmd = new SqlCommand("delete from estudiante where carnet_estudiante='" + carnet + "'", cn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                salida = "No se pudo eliminar el registro: " + ex.ToString();
            }

            return salida;
        }

        //metodo para eliminar un SALON
        public string eliminar_salon(int codigo)
        {
            string salida = "Registro eliminado";
            try
            {
                cmd = new SqlCommand("delete from salon where codigo_salon=" + codigo, cn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                salida = "No se pudo eliminar el registro: " + ex.ToString();
            }

            return salida;
        }

        //metodo para eliminar un RESERVACION
        public string eliminar_reservacion(string codigo)
        {
            string salida = "Registro eliminado";
            try
            {
                cmd = new SqlCommand("delete from reserva where codigo_reserva='" + codigo + "'", cn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                salida = "No se pudo eliminar el registro: " + ex.ToString();
            }

            return salida;
        }

        //metodo para eliminar FECHA RESTRINGIDA
        public string eliminar_fechaRestringida(string codigo)
        {
            string salida = "Registro eliminado";
            try
            {
                cmd = new SqlCommand("delete from fecha_restringida where codigo_fecha='" + codigo + "'", cn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                salida = "No se pudo eliminar el registro: " + ex.ToString();
            }

            return salida;
        }


 //----------------------------------------------------------------------PARA VALIDACIONES--------------------------------------------------------------------------------

        //para validar si ya hay algun registro con ese carnet y contra en administrador (LOGIN)
        public int validacion_carnet_contra_adminitrador(string carnet, string contra)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from administrador_operador where carnet_admin_operador='" + carnet + "' and contra='" + contra + "'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())//para ver cuantas personas tienen el mismo id
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo consultar bien: " + ex.ToString());
            }
            return contador;
        }

        //para validar si ya hay algun registro con ese carnet y contra en instructor (LOGIN)
        public int validacion_carnet_contra_instructor(string carnet, string contra)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from instructor where carnet_instructor='" + carnet + "' and contra='" + contra + "'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())//para ver cuantas personas tienen el mismo id
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo consultar bien: " + ex.ToString());
            }
            return contador;
        }

        //para validar si ya hay algun registro con ese carnet y contra en estudiante (LOGIN)
        public int validacion_carnet_contra_estudiante(string carnet, string contra)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from estudiante where carnet_estudiante='" + carnet + "' and contra='" + contra + "'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())//para ver cuantas personas tienen el mismo id
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo consultar bien: " + ex.ToString());
            }
            return contador;
        }

        //para validar si ya hay algun registro con ese carnet y usuario en administrador operador (REGISTRO)
        public int validacion_carnet_usuario_adminoperador(string carnet, string usuario)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from administrador_operador where carnet_admin_operador='" + carnet + "' or usuario='" + usuario + "'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())//para ver cuantas personas tienen el mismo id
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo consultar bien: " + ex.ToString());
            }
            return contador;
        }


       //para validar si ya hay algun registro con ese carnet y usuario en instructor (REGISTRO)
        public int validacion_carnet_usuario_instructor(string carnet, string usuario)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from instructor where carnet_instructor='" + carnet + "' or usuario='" + usuario + "'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())//para ver cuantas personas tienen el mismo id
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo consultar bien: " + ex.ToString());
            }
            return contador;
        }

        //para validar si ya hay algun registro con ese carnet y usuario en estudiante (REGISTRO)
        public int validacion_carnet_usuario_estudiante(string carnet, string usuario)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from estudiante where carnet_estudiante='" + carnet + "' or usuario='" + usuario + "'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())//para ver cuantas personas tienen el mismo id
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo consultar bien: " + ex.ToString());
            }
            return contador;
        }

        //para validar si la reserva esta en rango restringido
        public int validacion_fecha_enrango_restringido(string fechaInicio, string fechaFinal)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("select * from fecha_restringida where (fecha_inicio <='" + fechaInicio + "' and fecha_final >= '"+fechaInicio+"') or ((fecha_inicio <='"+fechaFinal+"' and fecha_final >= '"+fechaFinal+"'))", cn);
                
                dr = cmd.ExecuteReader();
                while (dr.Read())//para ver cuantas personas tienen el mismo id
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo consultar bien: " + ex.ToString());
            }
            return contador;
        }

        //para validar el codigo de reserva ya existe
        public int validacion_codigo_reserva(string codigo)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("select * from reserva where codigo_reserva = '"+codigo+"'", cn);

                dr = cmd.ExecuteReader();
                while (dr.Read())//para ver cuantas personas tienen el mismo id
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo consultar bien: " + ex.ToString());
            }
            return contador;
        }

        //para validar el codigo de QR ya existe
        public int validacion_codigoQR(string codigo)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("select * from codigo_QR where codigo_qr = '" + codigo + "'", cn);

                dr = cmd.ExecuteReader();
                while (dr.Read())//para ver cuantas personas tienen el mismo id
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo consultar bien: " + ex.ToString());
            }
            return contador;
        }

        //para validar si el carnet instructor existe
        public int validacion_carnetInstructor(string carnet)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("select * from instructor where carnet_instructor = '" + carnet + "'", cn);

                dr = cmd.ExecuteReader();
                while (dr.Read())//para ver cuantas personas tienen el mismo id
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo consultar bien: " + ex.ToString());
            }
            return contador;
        }

        //para validar si el carnet estudiante existe
        public int validacion_carnetEstudiante(string carnet)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("select * from estudiante where carnet_estudiante = '" + carnet + "'", cn);

                dr = cmd.ExecuteReader();
                while (dr.Read())//para ver cuantas personas tienen el mismo id
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo consultar bien: " + ex.ToString());
            }
            return contador;
        }

        //para validar si el carnet admin_operador existe
        public int validacion_carnetAdmin_operador(string carnet)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("select * from administrador_operador where carnet_admin_operador = '" + carnet + "'", cn);

                dr = cmd.ExecuteReader();
                while (dr.Read())//para ver cuantas personas tienen el mismo id
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo consultar bien: " + ex.ToString());
            }
            return contador;
        }

        //para validar si el codigo de salon existe
        public int validacion_salon_codigo(int codigo)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("select * from salon where codigo_salon = " + codigo , cn);

                dr = cmd.ExecuteReader();
                while (dr.Read())//para ver cuantas personas tienen el mismo id
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo consultar bien: " + ex.ToString());
            }
            return contador;
        }

        //para validar si esta ocupado o reservado el salon
        public int validacion_salon_estado(int codigo)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("select * from salon where ((estado ='Ocupado') or (estado='Reserva Previa') or (estado='Reserva Completa') or (de_baja='Si')) and codigo_salon=" + codigo, cn);

                dr = cmd.ExecuteReader();
                while (dr.Read())//para ver cuantas personas tienen el mismo id
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo consultar bien: " + ex.ToString());
            }
            return contador;
        }

        //para validar si el codigo de salon existe
        public int validacion_codigo_salon_en_reserva(int codigo)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("select * from reserva where codigo_salon= " + codigo, cn);

                dr = cmd.ExecuteReader();
                while (dr.Read())//para ver cuantas personas tienen el mismo id
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo consultar bien: " + ex.ToString());
            }
            return contador;
        }

        //para validar si el codigo de reservacion existe
        public int validacion_reservacion_codigo(string codigo)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("select * from reserva where codigo_reserva = '" + codigo + "'", cn);

                dr = cmd.ExecuteReader();
                while (dr.Read())//para ver cuantas personas tienen el mismo id
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo consultar bien: " + ex.ToString());
            }
            return contador;
        }

        //para validar si el codigo de curso existe
        public int validacion_codigo_curso(string codigo)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("select * from curso where codigo_curso = '" + codigo + "'", cn);

                dr = cmd.ExecuteReader();
                while (dr.Read())//para ver cuantas personas tienen el mismo id
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo consultar bien: " + ex.ToString());
            }
            return contador;
        }

        //para validar cuantos alumnos hay en un curso
        public int validacion_curso_cantidad(string codigo)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("select * from matriculacion where codigo_curso = '" + codigo + "'", cn);

                dr = cmd.ExecuteReader();
                while (dr.Read())//para ver cuantas personas tienen el mismo id
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo consultar bien: " + ex.ToString());
            }
            return contador;
        }

        //para validar Si ya esta matriculada en ese curso
        public int validacion_siyaesta_matriculado_encurso(string carnet,string codigo)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("select * from matriculacion where carnet_estudiante='"+carnet+"' and codigo_curso='"+codigo+"'", cn);

                dr = cmd.ExecuteReader();
                while (dr.Read())//para ver cuantas personas tienen el mismo id
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo consultar bien: " + ex.ToString());
            }
            return contador;
        }

        //para validar si el codigo de fecha restringida existe
        public int validacion_fechaRestrigida_codigo(string codigo)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("select * from fecha_restringida where codigo_fecha = " + codigo , cn);

                dr = cmd.ExecuteReader();
                while (dr.Read())//para ver cuantas personas tienen el mismo id
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo consultar bien: " + ex.ToString());
            }
            return contador;
        }

        //para validar si esta en la fecha de la reserva (ASISTENCIA)
        public int validacion_fecha_asistencia(string codigo, string fecha)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("select * from reserva where fecha_inicio <='"+fecha+"' and fecha_fin >= '"+fecha+"' and codigo_reserva='"+codigo+"'", cn);

                dr = cmd.ExecuteReader();
                while (dr.Read())//para ver cuantas personas tienen el mismo id
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo consultar bien: " + ex.ToString());
            }
            return contador;
        }

        //para validar si esta en la hora de la reserva (ASISTENCIA)
        public int validacion_hora_asistencia(string codigo, string hora)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("select * from reserva where hora_inicio <='" + hora + "' and hora_fin >= '" + hora + "' and codigo_reserva='" + codigo + "'", cn);

                dr = cmd.ExecuteReader();
                while (dr.Read())//para ver cuantas personas tienen el mismo id
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo consultar bien: " + ex.ToString());
            }
            return contador;
        }

        //para validar si esta matriculado en el curso (ASISTENCIA)
        public int validacion_matriculacion_asistencia(string carnet, string codigocurso)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("select * from matriculacion where carnet_estudiante='"+carnet+"' and codigo_curso='"+codigocurso+"'", cn);

                dr = cmd.ExecuteReader();
                while (dr.Read())//para ver cuantas personas tienen el mismo id
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo consultar bien: " + ex.ToString());
            }
            return contador;
        }

        //para validar si ya guardo su asistencia (ASISTENCIA)
        public int validacion_yaguardo_asistencia(string carnet, string fecha)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("select * from asistencia where carnet_estudiante='"+carnet+"' and fecha ='"+fecha+"'", cn);

                dr = cmd.ExecuteReader();
                while (dr.Read())//para ver cuantas personas tienen el mismo id
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo consultar bien: " + ex.ToString());
            }
            return contador;
        }

        //para validar CARNET Y PALABRA CLAVE ADMINISTRADOR OPERADOR (RECUPERAR CONTRA)
        public int validacion_recuperarcontra_adminoperador(string carnet, string palabra)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("select * from administrador_operador where carnet_admin_operador='"+carnet+"' and palabra_clave='"+palabra+"'", cn);

                dr = cmd.ExecuteReader();
                while (dr.Read())//para ver cuantas personas tienen el mismo id
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo consultar bien: " + ex.ToString());
            }
            return contador;
        }

        //para validar CARNET Y PALABRA CLAVE INSTRUCTOR (RECUPERAR CONTRA)
        public int validacion_recuperarcontra_instructor(string carnet, string palabra)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("select * from instructor where carnet_instructor='" + carnet + "' and palabra_clave='" + palabra + "'", cn);

                dr = cmd.ExecuteReader();
                while (dr.Read())//para ver cuantas personas tienen el mismo id
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo consultar bien: " + ex.ToString());
            }
            return contador;
        }

        //para validar CARNET Y PALABRA CLAVE ESTUDIANTE (RECUPERAR CONTRA)
        public int validacion_recuperarcontra_estudiante(string carnet, string palabra)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("select * from estudiante where carnet_estudiante='" + carnet + "' and palabra_clave='" + palabra + "'", cn);

                dr = cmd.ExecuteReader();
                while (dr.Read())//para ver cuantas personas tienen el mismo id
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo consultar bien: " + ex.ToString());
            }
            return contador;
        }

        //RECUPERAR CONTRA ADMINISTRADOR OPERADOR 
        public string contra_recuperada_adminoperador(string carnet, string palabra)
        {
            string contra = "";
            try
            {
                cmd = new SqlCommand("Select * from administrador_operador where carnet_admin_operador='" + carnet + "' and palabra_clave='" + palabra + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                { //cuento encuentre el registro me llena los campos
                    contra= dr["contra"].ToString();
                    
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron llenar los campos: " + ex.ToString());
            }
            return contra;
        }

        //RECUPERAR CONTRA INSTRUCTOR
        public string contra_recuperada_instructor(string carnet, string palabra)
        {
            string contra = "";
            try
            {
                cmd = new SqlCommand("Select * from instructor where carnet_instructor='" + carnet + "' and palabra_clave='" + palabra + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                { //cuento encuentre el registro me llena los campos
                    contra = dr["contra"].ToString();

                }
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron llenar los campos: " + ex.ToString());
            }
            return contra;
        }

        //RECUPERAR CONTRA ESTUDIANTE
        public string contra_recuperada_estudiante(string carnet, string palabra)
        {
            string contra = "";
            try
            {
                cmd = new SqlCommand("Select * from estudiante where carnet_estudiante='" + carnet + "' and palabra_clave='" + palabra + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                { //cuento encuentre el registro me llena los campos
                    contra = dr["contra"].ToString();

                }
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron llenar los campos: " + ex.ToString());
            }
            return contra;
        }

//----------------------------------------------------------------------PARA MOSTRAR--------------------------------------------------------------------------------

        //para REPORTES INSTRUCTOR SALON
        public String mostrar_reporte_instructor_salon()
        {
            try
            {

                String info = "<table><tr>  <td> CODIGO </td><td> TIPO </td> <td> DESCRIPCION </td><td> RESUELTO </td><td> FECHA </td> <td> HORA </td><td> QUIEN TIENE REPORTE </td><td> CODIGO SALON </td><td> HORA </td>QUIEN LO REGISTRO</tr>";
                SqlCommand query = new SqlCommand("SELECT * FROM reporte_incidente_instructor_salon", cn);
                SqlDataReader reader;
                reader = query.ExecuteReader();
                while (reader.Read())
                {
                    info += "<tr>  <td> " + reader["codigo_incidente"].ToString() + "</td><td>" + reader["tipo_incidente_salon"].ToString() + "</td><td>" + reader["tipo_incidente"].ToString() + "</td> <td>" + reader["resuelto"].ToString() + "</td><td>" + reader["fecha"].ToString() + "</td><td>" + reader["hora"].ToString() + "</td><td>" + reader["carnet_instructor"].ToString() + "</td><td>" + reader["codigo_salon"].ToString() + "</td><td>" + reader["carnet_admin_operador"].ToString() + "</tr>";
                }
                info += "</table>";

                return info;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al mostrar reporte", "ERROR");
                return "Error al mostrar reporte";
            }


        }

        //para MOSTRAR CURSOS (CUANDO BUSCA)
        public void mostrar_Cursos(System.Web.UI.WebControls.GridView tabla, string nombrecurso)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select curso.codigo_curso,instructor.nombre_apellido as 'Nombre Instructor', curso.nombre as 'Nombre de Curso',curso.descripcion as 'Descripcion',reserva.fecha_inicio as 'Fecha Inicio',reserva.fecha_fin as 'Fecha Final', reserva.hora_inicio as 'Hora Inicio', reserva.hora_fin as 'Hora Fin' from curso join reserva on curso.codigo_curso='"+nombrecurso+"' and curso.codigo_reserva=reserva.codigo_reserva join instructor on reserva.carnet_instructor=instructor.carnet_instructor", cn);
                DataSet ds = new DataSet();
                da.Fill(ds, "academico");
                tabla.DataSource = ds.Tables[0];
                tabla.DataBind();
               
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al mostrar reporte", "ERROR");
                
            }


        }

        //PARA MOSTRAR TODOS LOS CURSOS
        public void mostrar_Cursos2(System.Web.UI.WebControls.GridView tabla)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select curso.codigo_curso,instructor.nombre_apellido as 'Nombre Instructor', curso.nombre as 'Nombre de Curso',curso.descripcion as 'Descripcion',reserva.fecha_inicio as 'Fecha Inicio',reserva.fecha_fin as 'Fecha Final', reserva.hora_inicio as 'Hora Inicio', reserva.hora_fin as 'Hora Fin' from curso join reserva on curso.codigo_reserva=reserva.codigo_reserva join instructor on reserva.carnet_instructor=instructor.carnet_instructor",cn);
                DataSet ds = new DataSet();
                da.Fill(ds, "academico");
                tabla.DataSource = ds.Tables[0];
                tabla.DataBind();
                
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al mostrar reporte"+e.ToString(), "ERROR");
               
            }

        }

        //PARA MOSTRAR USUARIOS ADMIN Y OPERADORES
        public void mostrar_adminoperadores(System.Web.UI.WebControls.GridView tabla)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from administrador_operador", cn);
                DataSet ds = new DataSet();
                da.Fill(ds, "academico");
                tabla.DataSource = ds.Tables[0];
                tabla.DataBind();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al mostrar reporte" + e.ToString(), "ERROR");

            }

        }

        //PARA MOSTRAR USUARIOS INSTRUCTORES
        public void mostrar_instructores(System.Web.UI.WebControls.GridView tabla)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from instructor", cn);
                DataSet ds = new DataSet();
                da.Fill(ds, "academico");
                tabla.DataSource = ds.Tables[0];
                tabla.DataBind();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al mostrar reporte" + e.ToString(), "ERROR");

            }

        }

        //PARA MOSTRAR USUARIOS ESTUDIANTES
        public void mostrar_estudiantes(System.Web.UI.WebControls.GridView tabla)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from estudiante", cn);
                DataSet ds = new DataSet();
                da.Fill(ds, "academico");
                tabla.DataSource = ds.Tables[0];
                tabla.DataBind();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al mostrar reporte" + e.ToString(), "ERROR");

            }

        }

        //PARA MOSTRAR FECHAS RESTRINGIDAS
        public void mostrar_fechasRestringidas(System.Web.UI.WebControls.GridView tabla)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select fecha_restringida.codigo_fecha as 'Codigo',fecha_restringida.fecha_inicio as 'Fecha de Inicio',fecha_restringida.fecha_final as 'Fecha Fin',fecha_restringida.carnet_admin_operador as 'Carnet De Quien Registro',fecha_restringida.descripcion as 'Descripcion' from fecha_restringida", cn);
                DataSet ds = new DataSet();
                da.Fill(ds, "academico");
                tabla.DataSource = ds.Tables[0];
                tabla.DataBind();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al mostrar reporte" + e.ToString(), "ERROR");

            }

        }

        //PARA MOSTRAR SALONES
        public void mostrar_salones(System.Web.UI.WebControls.GridView tabla)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from salon", cn);
                DataSet ds = new DataSet();
                da.Fill(ds, "academico");
                tabla.DataSource = ds.Tables[0];
                tabla.DataBind();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al mostrar reporte" + e.ToString(), "ERROR");

            }

        }

        //PARA MOSTRAR RESERVAS
        public void mostrar_reservas(System.Web.UI.WebControls.GridView tabla)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select reserva.codigo_reserva as 'Codigo Reserva',reserva.tipo_actividad as 'Tipo de Actividad', reserva.fecha_inicio as 'Fecha de Inicio',reserva.fecha_fin as 'Fecha Fin', reserva.hora_inicio as 'Hora Inicio', reserva.hora_fin as 'Hora Fin', reserva.carta_escaneada as 'Carta Escaneada', reserva.codigo_qr as 'Codigo QR', reserva.codigo_salon as 'Codigo de Salon', reserva.carnet_instructor as 'Carnet Instructor', reserva.carnet_admin_operador as 'Carnet De Quien Registro', salon.estado as 'Estado' from reserva join salon on reserva.codigo_salon=salon.codigo_salon", cn);
                DataSet ds = new DataSet();
                da.Fill(ds, "academico");
                tabla.DataSource = ds.Tables[0];
                tabla.DataBind();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al mostrar reporte" + e.ToString(), "ERROR");

            }

        }

        //PARA MOSTRAR CURSOS MATRICULADOS DE ESTUDIANTE
        public void mostrar_cursosMatriculados(System.Web.UI.WebControls.GridView tabla, string carnet)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select estudiante.nombre_apellido as 'Nombre y Apellido', estudiante.carnet_estudiante as 'Carnet', curso.codigo_curso as 'Codigo de Curso', curso.nombre as 'Nombre de Curso', reserva.codigo_reserva as 'Codigo de Reserva',reserva.fecha_inicio as 'Fecha Inicio', reserva.fecha_fin as 'Fecha Fin', reserva.hora_inicio as 'Hora Inicio', reserva.hora_fin as 'Hora Fin', salon.codigo_salon as 'Codigo Salon', salon.numero_salon 'Numero Salon' from estudiante join matriculacion on estudiante.carnet_estudiante=matriculacion.carnet_estudiante and matriculacion.carnet_estudiante='"+carnet+"' join curso on matriculacion.codigo_curso=curso.codigo_curso join reserva on curso.codigo_reserva=reserva.codigo_reserva join salon on reserva.codigo_salon=salon.codigo_salon", cn);
                DataSet ds = new DataSet();
                da.Fill(ds, "academico");
                tabla.DataSource = ds.Tables[0];
                tabla.DataBind();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al mostrar reporte" + e.ToString(), "ERROR");

            }

        }

        //PARA MOSTRAR ASISTENCIA GENERAL
        public void mostrar_asistenciaGeneral(System.Web.UI.WebControls.GridView tabla)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select asistencia.carnet_estudiante as 'Carnet estudiante', estudiante.nombre_apellido as 'Nombre Y Apellido Estudiante', asistencia.codigo_curso as 'Codigo Curso', asistencia.codigo_reserva as 'Codigo de Reserva', asistencia.fecha as 'Fecha de Asistencia', asistencia.hora as 'Hora de Asistencia', curso.nombre as 'Nombre De Curso', instructor.carnet_instructor as 'Carnet Quien Impartio Curso' , instructor.nombre_apellido as 'Nombre Quien Impartio Curso' from asistencia join curso on asistencia.codigo_curso=curso.codigo_curso join reserva on reserva.codigo_reserva=asistencia.codigo_reserva join estudiante on estudiante.carnet_estudiante=asistencia.carnet_estudiante join instructor on reserva.carnet_instructor = instructor.carnet_instructor", cn);
                DataSet ds = new DataSet();
                da.Fill(ds, "academico");
                tabla.DataSource = ds.Tables[0];
                tabla.DataBind();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al mostrar reporte" + e.ToString(), "ERROR");

            }

        }

        //PARA MOSTRAR ASISTENCIA GENERAL POR CURSO
        public void mostrar_asistenciaGeneral_porCurso(System.Web.UI.WebControls.GridView tabla, string codigocurso)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select asistencia.carnet_estudiante as 'Carnet estudiante', estudiante.nombre_apellido as 'Nombre Y Apellido Estudiante', asistencia.codigo_curso as 'Codigo Curso', asistencia.codigo_reserva as 'Codigo de Reserva', asistencia.fecha as 'Fecha de Asistencia', asistencia.hora as 'Hora de Asistencia', curso.nombre as 'Nombre De Curso', instructor.carnet_instructor as 'Carnet Quien Impartio Curso' , instructor.nombre_apellido as 'Nombre Quien Impartio Curso' from asistencia join curso on asistencia.codigo_curso=curso.codigo_curso and curso.codigo_curso='"+codigocurso+"' join reserva on reserva.codigo_reserva=asistencia.codigo_reserva join estudiante on estudiante.carnet_estudiante=asistencia.carnet_estudiante join instructor on reserva.carnet_instructor = instructor.carnet_instructor", cn);
                DataSet ds = new DataSet();
                da.Fill(ds, "academico");
                tabla.DataSource = ds.Tables[0];
                tabla.DataBind();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al mostrar reporte" + e.ToString(), "ERROR");

            }

        }

        //PARA MOSTRAR ASISTENCIA GENERAL POR FECHA
        public void mostrar_asistenciaGeneral_porFecha(System.Web.UI.WebControls.GridView tabla, string fecha)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select asistencia.carnet_estudiante as 'Carnet estudiante', estudiante.nombre_apellido as 'Nombre Y Apellido Estudiante', asistencia.codigo_curso as 'Codigo Curso', asistencia.codigo_reserva as 'Codigo de Reserva', asistencia.fecha as 'Fecha de Asistencia', asistencia.hora as 'Hora de Asistencia', curso.nombre as 'Nombre De Curso', instructor.carnet_instructor as 'Carnet Quien Impartio Curso' , instructor.nombre_apellido as 'Nombre Quien Impartio Curso' from asistencia join curso on asistencia.codigo_curso=curso.codigo_curso and asistencia.fecha='"+fecha+"' join reserva on reserva.codigo_reserva=asistencia.codigo_reserva join estudiante on estudiante.carnet_estudiante=asistencia.carnet_estudiante join instructor on reserva.carnet_instructor = instructor.carnet_instructor", cn);
                DataSet ds = new DataSet();
                da.Fill(ds, "academico");
                tabla.DataSource = ds.Tables[0];
                tabla.DataBind();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al mostrar reporte" + e.ToString(), "ERROR");

            }

        }

        //PARA MOSTRAR ASISTENCIA GENERAL POR FECHA Y CURSO
        public void mostrar_asistenciaGeneral_porFechaYCurso(System.Web.UI.WebControls.GridView tabla, string fecha, string codigocurso)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select asistencia.carnet_estudiante as 'Carnet estudiante', estudiante.nombre_apellido as 'Nombre Y Apellido Estudiante', asistencia.codigo_curso as 'Codigo Curso', asistencia.codigo_reserva as 'Codigo de Reserva', asistencia.fecha as 'Fecha de Asistencia', asistencia.hora as 'Hora de Asistencia', curso.nombre as 'Nombre De Curso', instructor.carnet_instructor as 'Carnet Quien Impartio Curso' , instructor.nombre_apellido as 'Nombre Quien Impartio Curso' from asistencia join curso on asistencia.codigo_curso=curso.codigo_curso and asistencia.fecha='"+fecha+"' and curso.codigo_curso='"+codigocurso+"' join reserva on reserva.codigo_reserva=asistencia.codigo_reserva join estudiante on estudiante.carnet_estudiante=asistencia.carnet_estudiante join instructor on reserva.carnet_instructor = instructor.carnet_instructor", cn);
                DataSet ds = new DataSet();
                da.Fill(ds, "academico");
                tabla.DataSource = ds.Tables[0];
                tabla.DataBind();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al mostrar reporte" + e.ToString(), "ERROR");

            }

        }


    }
}