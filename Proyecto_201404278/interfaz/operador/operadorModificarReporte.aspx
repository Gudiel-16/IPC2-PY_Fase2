<%@ Page Title="" StylesheetTheme="operador" Language="C#" MasterPageFile="~/interfaz/operador/operador.Master" AutoEventWireup="true" CodeBehind="operadorModificarReporte.aspx.cs" Inherits="Proyecto_201404278.interfaz.operadorModificarReporte" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <br />
    <br />
    .
    <br />
    <h2 style="text-align: center">MODIFICAR REPORTE</h2>
    <br />
    <br />

    <div class="row" id="aa2">
        <div class="col-md-5 col-md-offset-2">
             <label for="pwd">Ingrese Codigo de Incidente para buscar:</label>
        </div>
        <br />
        <br />
      
        <div class="col-md-5 col-md-offset-2">
           <div class="form-group">
                <label for="pwd">Codigo:</label>
            </div>
            <div class="form-group">
                <asp:TextBox ID="txtCodigobuscar" runat="server" Style="margin-left: 0px" Width="450px"></asp:TextBox>
                <asp:Button ID="bttBuscar" runat="server" Style="margin-left: 10px" Text="BUSCAR"/>
            </div>
        </div>
               
    </div>

      <div class="container col-md-5 col-lg-offset-2">
        
          <div>
            <label for="pwd">Tipo de Incidente:</label>
        </div>
        <div class="form-group" >
                    <select class="form-control" id="rolTipo" runat="server">
                        <option>1. Insumo</option>
                        <option>2. Salon</option>
                    </select>
                </div>
          <br />

        <div>
            <label for="usr">Tipo de daño (Descripcion):</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtDescripcion" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
        </div>
        <br />

          <div>
            <label for="pwd">Resuelto:</label>
        </div>
        <div class="form-group" >
                    <select class="form-control" id="rolResuelto" runat="server">
                        <option>1. Si</option>
                        <option>2. No</option>
                    </select>
                </div>
        

        <div>
            <label for="pwd">Fecha:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtFecha" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
        </div>
        <br />

        <div>
            <label for="pwd">Hora:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtHora" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
        </div>
        <br />

        <div>
            <label for="pwd">Carnet a quien va reporte:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtCarnetReporte" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
        </div>
        <br />

        <div>
            <label for="pwd">Codigo de insumo o salon:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtCodigoInsumoSalon" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
        </div>
        <br />

        <div>
            <label for="pwd">Codigo de quien lo registra:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtQuienRegistra" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
        </div>
        <br />

        <div>
            <label for="pwd">MODIFICAR REPORTE:</label>
        </div>      
        <asp:Button ID="bttModificarReserva" runat="server" Style="margin-left: 0px" Text="MODIFICAR"/>
        <br />
        <br />

        
    </div>


</asp:Content>
