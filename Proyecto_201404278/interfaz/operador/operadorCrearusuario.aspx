<%@ Page Title="" Language="C#" MasterPageFile="~/interfaz/operador/operador.Master" AutoEventWireup="true" CodeBehind="operadorCrearusuario.aspx.cs" Inherits="Proyecto_201404278.interfaz.operadorCrearusuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
 <br />
    <br />
    .
    <br />
    <br />
    <br />

    <div class="container col-md-7 col-lg-offset-2">
        
        <div>
            <h2 style="text-align:center">FORMULARIO DE REGISTRAR USUARIO</h2>
        </div>
        <br />
        <br />
        <div class="form-group" >
                    <select class="form-control" id="rolEntrar" runat="server">
                        <option>Administrador</option>
                        <option>Operador</option>
                        <option>Docente</option>
                        <option>Auxiliar</option>
                        <option>Conferencista</option>
                        <option>Estudiante</option>
                    </select>
                </div>
        <div>
            <label for="usr">Carnet:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtCarnet" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
        </div>
        <br />

        <div>
            <label for="pwd">Nombre y Apellido:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtNombre" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
        </div>
        <br />
                
        <div>
            <label for="pwd">Fecha de Nacimiento:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtFechanac" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
        </div>
        <br />

        <div>
            <label for="pwd">Correo Electronico:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtCorreo" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
        </div>
        <br />

        <div>
            <label for="pwd">Telefono:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtTelefono" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
        </div>
        <br />

        <div>
            <label for="pwd">Usuario:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtUsuario" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
        </div>
        <br />
           
        <div>
            <label for="pwd">Contraseña:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtpassword" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
        </div>
        <br />

        <div>
            <label for="pwd">Repetir Contraseña:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtRepetirpassword" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
        </div>
        <br />

        <div>
            <label for="pwd">Palabra Clave:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtPalabraclave" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
        </div>
        <br />

       
        <asp:Button ID="bttregistrar" OnClick="bttregistrar_Click" runat="server" Style="margin-left: 0px" Text="REGISTRAR"/>

    </div>


</asp:Content>
