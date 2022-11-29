<%@ Page Title="" Language="C#" MasterPageFile="~/interfaz/asistencia.Master" AutoEventWireup="true" CodeBehind="asistencia.aspx.cs" Inherits="Proyecto_201404278.interfaz.asistencia1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />
    <br />
    .
    <br />
    <h2 style="text-align: center">TOMA DE ASISTENCIA</h2>
    <br />
    <br />

    <div class="container col-md-5 col-lg-offset-4">
        
        <div>
            <label for="usr">Ingrese su Carnet:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtCarnet" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
        </div>
        <br />

        <div>
            <label for="pwd">Ingrese Codigo de Curso:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtCodigoCurso" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
        </div>

        <div>
            <label for="pwd">Ingrese Codigo de Reserva:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtCodigoReserva" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
        </div>
        <br />
       
        <div>
            <label for="pwd">Fecha Detectada por el sistema:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtFecha" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
        </div>
        <br />
        <div>
            <label for="pwd">Hora Detectada por el sistema:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtHora" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
        </div>
        <br />

        

        <asp:Button ID="bttGudardar" runat="server" Text="GUARDAR ASISTENCIA" OnClick="bttGudardar_Click" />
         </div>
    
        <br />
         

</asp:Content>
