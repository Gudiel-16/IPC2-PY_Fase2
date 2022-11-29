<%@ Page Title="" StylesheetTheme="operador" Language="C#" MasterPageFile="~/interfaz/operador/operador.Master" AutoEventWireup="true" CodeBehind="operadorModificarSalon.aspx.cs" Inherits="Proyecto_201404278.interfaz.operadorModificarSalon" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />
    <br />
    .
    <br />
    <h2 style="text-align: center">MODIFICAR SALON</h2>
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
                <asp:TextBox ID="txtCodigobuscar" type="number" runat="server" Style="margin-left: 0px" Width="450px"></asp:TextBox>
                <asp:Button ID="bttBuscar" OnClick="bttbuscar_Click" runat="server" Style="margin-left: 10px" Text="BUSCAR"/>
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
            <label for="usr">Muestra si el salon que busco esta 'de baja':</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtDeBaja" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
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
            <label for="usr">Muestra el 'estado' del salon que busco:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtEstado" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
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
            <label for="pwd">MODIFICAR SALON:</label>
        </div>      
        <asp:Button ID="bttModificarSalon" OnClick="bttModificar_Click" runat="server" Style="margin-left: 0px" Text="MODIFICAR"/>
        <br />
        <br />

        
    </div>

</asp:Content>
