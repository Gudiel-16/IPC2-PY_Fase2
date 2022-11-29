<%@ Page Title="" Language="C#" MasterPageFile="~/interfaz/administrador/administrador.Master" AutoEventWireup="true" CodeBehind="administradorAgregarSalon.aspx.cs" Inherits="Proyecto_201404278.interfaz.administradorAgregarSalon" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <br />
    <br />
    .
    <br />
    <h2 style="text-align: center">AGREGAR SALON</h2>
    <br />
    <br />

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
            <label for="pwd">De baja:</label>
        </div>
        <div class="form-group" >
                    <select class="form-control" id="rolDeBaja" runat="server">
                        <option>Si</option>
                        <option>No</option>
                    </select>
                </div>
          <br />

        

          <div>
            <label for="pwd">Estado:</label>
        </div>
        <div class="form-group" >
                    <select class="form-control" id="rolEstado" runat="server">
                        <option>Disponible</option>
                        <option>Reserva Previa</option>
                        <option>Reserva Completa</option>
                        <option>Ocupado</option>
                    </select>
                </div>
        
          
        <div>
            <label for="pwd">AGREGAR SALON:</label>
        </div>      
        <asp:Button ID="bttAgregarSalon" runat="server" OnClick="bttAgregar_Click" Style="margin-left: 0px" Text="AGREGAR"/>
        <br />
        <br />

        
    </div> 
       

</asp:Content>
