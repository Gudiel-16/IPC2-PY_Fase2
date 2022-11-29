<%@ Page Title="" Language="C#" MasterPageFile="~/interfaz/instructor/instructor.Master" AutoEventWireup="true" CodeBehind="instructorSubirPresentacion.aspx.cs" Inherits="Proyecto_201404278.interfaz.instructorSubirPresentacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />
    <br />
    .
    <br />
    <h2 style="text-align: center">SUBIR PRESENTACION</h2>
    <br />
    <br />

    <div class="container col-md-5 col-lg-offset-2">
        
        <div>
            <label for="usr">Codigo de Curso:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtcodigoCurso" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
        </div>
        <br />

        <div>
            <label for="pwd">Nombre:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtNombre" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
        </div>
        <br />

        <div>
            <label for="pwd">Descripcion:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtDescripcion" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
        </div>
        <br />

        <div>
            <label for="pwd">Codigo de Reserva:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtCodigoReserva" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
        </div>
        <br />

        <div>
            <label for="pwd">Codigo de Salon:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtCodigoSalon" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
        </div>
        <br />

      <div>
            <label for="pwd">Seleccione Presentacion:</label>
        </div>
        <div class="form-group">
            <asp:FileUpload ID="FileUpload1" runat="server" />
        </div>
        <br />

        <asp:Button ID="bttSubir" runat="server" Text="SUBIR PRESENTACION" OnClick="bttSubir_Click" />
     </div>

        
    
</asp:Content>
