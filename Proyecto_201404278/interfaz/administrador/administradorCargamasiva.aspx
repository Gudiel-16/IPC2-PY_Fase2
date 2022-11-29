<%@ Page Title="" Language="C#" MasterPageFile="~/interfaz/administrador/administrador.Master" AutoEventWireup="true" CodeBehind="administradorCargamasiva.aspx.cs" Inherits="Proyecto_201404278.interfaz.administradorCargamasiva" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <br />
    <br />
    .
    <br />
    <h2 style="text-align:center">CARGA MASIVA</h2>
     <br />
   
   
    <br />

    <div class="row" id="aa2">
        <div class="col-md-9 col-md-offset-1">
            <label for="pwd">Presione para buscar archivo a cargar (.xls):</label>
        </div>
        <br />
        <br />
    </div>
    <div> 
 
    </div>
    <div class="row">
        <div class="col-md-9 col-md-offset-1">
            <div class="form-group col-md-9 col-md-offset-0">

                <asp:FileUpload ID="cargar" runat="server" />
                <br />
                <br />
                <asp:Button ID="bttabrir2" OnClick="bttabrir2_Click" runat="server" Style="margin-left: 0px" Text="CARGAR ARCHIVO" />
                <br />
                <br />
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                <asp:GridView ID="GridView1" runat="server">
                </asp:GridView>
                <br />
            </div>
        </div>
    </div>

    
     
</asp:Content>
