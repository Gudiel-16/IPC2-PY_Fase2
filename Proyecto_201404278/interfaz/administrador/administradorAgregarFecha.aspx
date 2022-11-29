<%@ Page Title="" Language="C#" MasterPageFile="~/interfaz/administrador/administrador.Master" AutoEventWireup="true" CodeBehind="administradorAgregarFecha.aspx.cs" Inherits="Proyecto_201404278.interfaz.administradorAgregarFecha" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <br />
    <br />
    .
    <br />
    <h2 style="text-align:center">AGREGAR FECHA RESTRINGIDA</h2>
     <br /> 
    <br />

    <div class="row" id="aa2">
        <div class="col-md-9 col-md-offset-1">
            <label for="pwd">Seleccione rango de fecha a restringir:</label>
        </div>
        <br />
        <br />

        <div class="col-md-3 col-md-offset-1">
            <div class="form-group">
                <label for="pwd">Desde:</label>
            </div>
            <div class="form-group">
                <asp:Calendar ID="Calendar1" OnSelectionChanged="Calendar1_SelectionChanged" runat="server"></asp:Calendar>
                <br />
                <asp:TextBox ID="txtDesde" runat="server" Style="margin-left: 0px" Width="300px"></asp:TextBox>
            </div>
        </div>
        <div class="col-md-3">
            <div class="form-group">
                <label for="pwd">Hasta:</label>
            </div>
            <div class="form-group">
                <asp:Calendar ID="Calendar2" OnSelectionChanged="Calendar2_SelectionChanged" runat="server"></asp:Calendar>
                <br />
                <asp:TextBox ID="txtHasta" runat="server" Style="margin-left: 0px" Width="300px"></asp:TextBox>
            </div>
        </div>

        <div class="col-md-3">
            <div class="form-group">
                <label for="pwd">Descripcion:</label>
            </div>
            <div class="form-group">
                <asp:TextBox ID="txtDescripcion" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
                <br />
                <br />
                <br />
                <div class="form-group">
                    <label for="pwd">Ingrese carnet de quien lo registra:</label>
                </div>
                <div class="form-group">
                    <asp:TextBox ID="txtQuienregistra" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
                    <br />
                </div>
            </div>
        </div>
    </div>

    <br />
    <br />
    <br />
    <div class="ss text-center">
        
        <asp:Button ID="bttAgregar" runat="server" OnClick="bttagregarFecha_Click" Style="margin-left: 10px" Text="AGREGAR FECHA"/>
    </div>
     

    <br />

</asp:Content>
