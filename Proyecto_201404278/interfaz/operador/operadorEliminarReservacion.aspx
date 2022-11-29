<%@ Page Title="" StylesheetTheme="operador" Language="C#" MasterPageFile="~/interfaz/operador/operador.Master" AutoEventWireup="true" CodeBehind="operadorEliminarReservacion.aspx.cs" Inherits="Proyecto_201404278.interfaz.operadorEliminarReservacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     
    <br />
    <br />
    .
    <br />
    <h2 style="text-align: center">ELIMINAR RESERVACION</h2>
    <br />
    <br />

    <div class="row" id="aa2">
        <div class="col-md-5 col-md-offset-2">
             <label for="pwd">Ingrese Codigo de la reservacion para buscar:</label>
        </div>
        <br />
        <br />
      
        <div class="col-md-5 col-md-offset-2">
           <div class="form-group">
                <label for="pwd">Codigo:</label>
            </div>
            <div class="form-group">
                <asp:TextBox ID="txtCodigobuscar" runat="server" Style="margin-left: 0px" Width="450px"></asp:TextBox>
                <asp:Button ID="bttBuscar" OnClick="bttbuscar_Click" runat="server" Style="margin-left: 10px" Text="BUSCAR"/>
            </div>
        </div>
               
    </div>

    <div class="container col-md-5 col-lg-offset-2">
        
        <div>
            <label for="usr">Carnet:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtCarnet" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
        </div>
        <br />

        <div>
            <label for="pwd">Actividad de la reserva buscada:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtActividad" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
        </div>

        <div>
            <label for="pwd">Codigo de Salon:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtSalon" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
        </div>
        <br />
       
        <div>
            <label for="pwd">Fecha Inicio:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtFechainicio" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
        </div>
        <br />

        <div>
            <label for="pwd">Fecha Final:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtFechafinal" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
        </div>
        <br />

        <div>
            <label for="pwd">Hora Inicio:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtHoraInicio" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
        </div>
        <br />

        <div>
            <label for="pwd">Hora Final:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtHoraFinal" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
        </div>
        <br />

        <div>
            <label for="pwd">''Codigo QR' que pertenece a la reservacion:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtcodigoQr" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
        </div>
        <br />
  
        <asp:Button ID="bttEliminar" runat="server" OnClick="btteliminar_Click" Style="margin-left: 0px" Text="ELIMINAR RESERVACION"/>

    </div>


</asp:Content>
