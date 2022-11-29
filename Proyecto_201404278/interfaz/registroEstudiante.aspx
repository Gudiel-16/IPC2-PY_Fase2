<%@ Page Title="" Language="C#" MasterPageFile="~/interfaz/principal.Master" AutoEventWireup="true" CodeBehind="registroEstudiante.aspx.cs" Inherits="Proyecto_201404278.interfaz.registroEstudiante" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br/>
    <br />.
    <br />

    
    <div class="container col-md-6 col-lg-offset-2">
        
        <div>
            <label for="usr">FORMULARIO DE REGISTRO ESTUDIANTE</label>
        </div>
        <br />
        <br />

        <div>
            <label for="usr">Carnet:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtCarnet" runat="server" Style="margin-left: 101px" Width="400px"></asp:TextBox>
        </div>
        <br />

        <div>
            <label for="pwd">Nombre y Apellido:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtNombre" runat="server" Style="margin-left: 101px" Width="400px"></asp:TextBox>
        </div>
        <br />
        
        <div>
            <label for="pwd">Fecha de Nacimiento:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtFechanac" runat="server" Style="margin-left: 101px" Width="400px"></asp:TextBox>
        </div>
        <br />

        <div>
            <label for="pwd">Correo Electronico:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtCorreo" runat="server" Style="margin-left: 101px" Width="400px"></asp:TextBox>
        </div>
        <br />

        <div>
            <label for="pwd">Telefono:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtTelefono" runat="server" Style="margin-left: 101px" Width="400px"></asp:TextBox>
        </div>
        <br />

        <div>
            <label for="pwd">Usuario:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtUsuario" runat="server" Style="margin-left: 101px" Width="400px"></asp:TextBox>
        </div>
        <br />
           
        <div>
            <label for="pwd">Contraseña:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtpassword" type="password" runat="server" Style="margin-left: 101px" Width="400px"></asp:TextBox>
        </div>
        <br />

        <div>
            <label for="pwd">Repetir Contraseña:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtRepetirpassword" type="password" runat="server" Style="margin-left: 101px" Width="400px"></asp:TextBox>
        </div>
        <br />

        <div>
            <label for="pwd">Palabra Clave:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtPalabraclave" runat="server" Style="margin-left: 101px" Width="400px"></asp:TextBox>
        </div>
        <br />
        <div class="forgot">
            <a href="#">Recuperar Contraseña</a>
        </div>
        <asp:Button ID="bttregistrar" OnClick="bttRegistrar_Click" runat="server" Style="margin-left: 133px" Text="REGISTRAR"/>

    </div>
</asp:Content>
