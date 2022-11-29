<%@ Page Title="" Language="C#" MasterPageFile="~/interfaz/estudiante/estudiante.Master" AutoEventWireup="true" CodeBehind="estudianteCursosMatriculados.aspx.cs" Inherits="Proyecto_201404278.interfaz.estudianteCursosMatriculados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />
    <br />
    .
    <br />
    <h2 style="text-align: center">CURSOS MATRICULADOS</h2>
    <br />
    <br />

    <div class="row text-center" id="aa2">
        <div>
             <label for="pwd">Ingrese su Numero de Carnet:</label>
        </div>
        <br />
        <br />
      
        <div>
           <div class="form-group">
                <label for="pwd">Carnet:</label>
            </div>
            <div class="form-group">
                <asp:TextBox ID="txtcarnet" runat="server" Style="margin-left: 0px" Width="450px"></asp:TextBox>
                <asp:Button ID="bttBuscar" runat="server" OnClick="bttbuscar_Click" Style="margin-left: 10px" Text="BUSCAR"/>
            </div>
        </div>
               
    </div>
    <br />
    <br />
    
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
