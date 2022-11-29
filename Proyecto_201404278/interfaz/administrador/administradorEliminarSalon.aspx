<%@ Page Title="" StylesheetTheme="administrador" Language="C#" MasterPageFile="~/interfaz/administrador/administrador.Master" AutoEventWireup="true" CodeBehind="administradorEliminarSalon.aspx.cs" Inherits="Proyecto_201404278.interfaz.administradorEliminarSalon" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />
    <br />
    .
    <br />
    <h2 style="text-align: center">ELIMINAR SALON</h2>
    <br />
    <br />

    <div class="row" id="aa2">
        <div class="col-md-5 col-md-offset-2">
             <label for="pwd">Ingrese Codigo del Salon para buscar:</label>
        </div>
        <br />
        <br />
      
        <div class="col-md-5 col-md-offset-2">
           <div class="form-group">
                <label for="pwd">Codigo:</label>
            </div>
            <div class="form-group">
                <asp:TextBox ID="txtCodigobuscar" runat="server" Style="margin-left: 0px" Width="450px"></asp:TextBox>
                <asp:Button ID="bttBuscar" runat="server" OnClick="bttbuscar_Click" Style="margin-left: 10px" Text="BUSCAR"/>
            </div>
        </div>
               
    </div>

     <div class="container col-md-5 col-lg-offset-2">
        
          <div>
            <label for="usr">Edificio</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtEdificio" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
        </div>
        <br />

          <div>
            <label for="usr">Nivel:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtNivel" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
        </div>
        <br />

          <div>
            <label for="usr">Numero de salon:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtNumeroSalon" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
        </div>
        <br />

         <div>
            <label for="usr">De Baja:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtDeBaja" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
        </div>
        <br />

          <div>
            <label for="usr">Estado</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtEstado" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
        </div>
        <br />
        
          
        <div>
            <label for="pwd">ELIMINAR SALON:</label>
        </div>      
        <asp:Button ID="bttEliminarSalon" OnClick="btteliminar_Click" runat="server" Style="margin-left: 0px" Text="ELIMINAR"/>
        <br />
        <br />

        
    </div>
   

</asp:Content>
