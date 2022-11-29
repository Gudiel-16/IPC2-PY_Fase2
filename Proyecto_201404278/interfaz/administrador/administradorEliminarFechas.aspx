<%@ Page Title="" Language="C#" MasterPageFile="~/interfaz/administrador/administrador.Master" AutoEventWireup="true" CodeBehind="administradorEliminarFechas.aspx.cs" Inherits="Proyecto_201404278.interfaz.administradorEliminarFechas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />
    <br />
    .
    <br />
    <h2 style="text-align: center">ELIMINAR FECHAS RESTRINGIDAS</h2>
    <br />
    <br />

    <div class="row text-center" id="aa2">
        <div>
             <label for="pwd">Ingrese Codigo de Fecha Restringida para Eliminar:</label>
        </div>
        <br />
        <br />
      
        <div>
           <div class="form-group">
                <label for="pwd">Codigo:</label>
            </div>
            <div class="form-group">
                <asp:TextBox ID="txtCodigoEliminar" runat="server" Style="margin-left: 0px" Width="450px"></asp:TextBox>
                <asp:Button ID="bttEliminar" runat="server" Style="margin-left: 10px" Text="ELIMINAR" OnClick="bttEliminar_Click"/>
                <br />
                <br />
                
            </div>
        </div>
    </div>
    
        <asp:GridView ID="GridView1" runat="server" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" HorizontalAlign="Center">
                    <FooterStyle BackColor="#CCCCCC" />
                    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                    <RowStyle BackColor="White" />
                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#808080" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#383838" />
                </asp:GridView>
               

</asp:Content>
