<%@ Page Title="" StylesheetTheme="administrador" Language="C#" MasterPageFile="~/interfaz/administrador/administrador.Master" AutoEventWireup="true" CodeBehind="administradorEliminarUsuario.aspx.cs" Inherits="Proyecto_201404278.interfaz.administradorEliminarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
   <br />
    <br />
    .
    <br />
    <h2 style="text-align:center">ELIMINAR USUARIO</h2>
     <br />
   
   
    <div class="row" id="aa2">
        <div class="col-md-9 col-md-offset-0">
             <label for="pwd">Ingrese Carnet y Contraseña para buscar:</label>
        </div>
        <br />
        <br />
      
        <div class="col-md-4">
           <div class="form-group">
                <label for="pwd">Carnet:</label>
            </div>
            <div class="form-group">
                <asp:TextBox ID="txtcarnetBuscar" runat="server" Style="margin-left: 0px" Width="450px"></asp:TextBox>
            </div>
        </div>
        <div class="col-md-4">
            <div class="form-group">
                <label for="pwd">Contraseña:</label>
            </div>
            <div class="form-group">
                <asp:TextBox ID="txtContraBuscar" runat="server" Style="margin-left: 0px" Width="450px"></asp:TextBox>
            </div>
        </div>
        <div class="col-md-4">
            <div class="form-group">
                <label for="pwd">Seleccionar Rol:</label>
            </div>
            <div class="form-group">
                <select class="form-control" id="rolbuscar" runat="server">
                    <option>Administrador</option>
                    <option>Operador</option>
                    <option>Docente</option>
                    <option>Auxiliar</option>
                    <option>Conferencista</option>
                    <option>Estudiante</option>
                </select>
                <br />
                <asp:Button ID="bttBuscar" OnClick="bttbuscar_Click" runat="server" Style="margin-left: 10px" Text="BUSCAR"/>
            </div>
        </div>
    </div>

    <br />

    <br />

    <div class="row">
        <div class="col-md-4">
            <div class="form-group">
                <label for="pwd">Seleccionar Rol:</label>
            </div>
            <div class="form-group">
                <div class="form-group">
                 <asp:TextBox ID="txtrol" runat="server" Style="margin-left: 0px" Width="450px"></asp:TextBox>
            </div>
            </div>
        </div>
        <div class="col-md-4">
            <div class="form-group">
                <label for="pwd">Carnet:</label>
            </div>
            <div class="form-group">
                <asp:TextBox ID="txtCarnet" runat="server" Style="margin-left: 0px" Width="450px"></asp:TextBox>
            </div>
        </div>
        <div class="col-md-4">
            <div class="form-group">
                <label for="pwd">Nombre Y Apellido:</label>
            </div>
            <div class="form-group">
                <asp:TextBox ID="txtNombre" runat="server" Style="margin-left: 0px" Width="450"></asp:TextBox>
            </div>
        </div>
    </div>

    <br />

    <div class="row">
        
        <div class="col-md-4">
            <div class="form-group">
                <label for="pwd">Fecha de Nacimiento:</label>
            </div>
            <div class="form-group">
                <asp:TextBox ID="txtFechanac" runat="server" Style="margin-left: 0px" Width="450px"></asp:TextBox>
            </div>
        </div>
        <div class="col-md-4">
            <div class="form-group">
                <label for="pwd">Correo Electronico:</label>
            </div>
            <div class="form-group">
                <asp:TextBox ID="txtCorreo" runat="server" Style="margin-left: 0px" Width="450"></asp:TextBox>
            </div>
        </div>
        <div class="col-md-4">
            <div class="form-group">
                <label for="pwd">Telefono:</label>
            </div>
          <div class="form-group">
                <asp:TextBox ID="txtTelefono" runat="server" Style="margin-left: 0px" Width="450px"></asp:TextBox>
           </div>
        </div>
    </div>
    
    <br />

    <div class="row">
        
        <div class="col-md-4">
            <div class="form-group">
                <label for="pwd">Usuario:</label>
            </div>
            <div class="form-group">
                <asp:TextBox ID="txtUsuario" runat="server" Style="margin-left: 0px" Width="450px"></asp:TextBox>
            </div>
        </div>
        <div class="col-md-4">
            <div class="form-group">
                <label for="pwd">Contraseña:</label>
            </div>
            <div class="form-group">
                <asp:TextBox ID="txtContraseña" runat="server" Style="margin-left: 0px" Width="450"></asp:TextBox>
            </div>
        </div>
        <div class="col-md-4">
            <div class="form-group">
                <label for="pwd">Repetir Contraseña:</label>
            </div>
          <div class="form-group">
                <asp:TextBox ID="txtRepetirContra" runat="server" Style="margin-left: 0px" Width="450px"></asp:TextBox>
           </div>
        </div>
    </div>
    
    <br />

    <div class="row">
        
        <div class="col-md-4">
            <div class="form-group">
                <label for="pwd">Palabra Clave:</label>
            </div>
            <div class="form-group">
                <asp:TextBox ID="txtPalabraclave" runat="server" Style="margin-left: 0px" Width="450px"></asp:TextBox>
            </div>
        </div>
       
    </div>

    <br />

    <div class="row">
        <div class="col-md-4">
            <div class="form-group">
                 <asp:Button ID="bttEliminar" OnClick="btteliminar_Click" runat="server" Style="margin-left: 0px" Text="ELIMINAR"/>
            </div>
       </div>
        <div class="col-md-4">
            <div class="form-group">
                 <asp:Button ID="bttLimpiar" runat="server" Style="margin-left: 0px" Text="LIMPIAR"/>
            </div>
         </div>
        <div class="col-md-4">
          <div class="form-group">
                 <asp:Button ID="bttMostrar" runat="server" Style="margin-left: 0px" Text="VISUALIZAR USUARIOS"/>
            </div>
        </div>
    </div>

</asp:Content>
