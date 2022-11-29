<%@ Page Title="" Language="C#" MasterPageFile="~/interfaz/administrador/administrador.Master" AutoEventWireup="true" CodeBehind="administradorVerCursos.aspx.cs" Inherits="Proyecto_201404278.interfaz.administradorVerCursos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
    <br />
    <br />
    .
    <br />
    <h2 style="text-align: center">CURSOS DISPONIBLES</h2>
    <br />
    <br />

     <div class="row">
        <div class="col-md-4">
            <div class="form-group">
                <label for="pwd">Ingrese Codigo de curso para buscar:</label>
            </div>
            <div class="form-group">
                 <asp:TextBox ID="txtnombreCursoBuscar" runat="server" Style="margin-left: 0px" Width="450px"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Button ID="bttBuscarCurso" runat="server" Text="BUSCAR" OnClick="bttBuscarCurso_Click" />
            </div>
        </div>
        <div class="col-md-4">
            <div class="form-group">
                <label for="pwd">Ingrese codigo de curso Para descargar su Presentacion:</label>
            </div>
            <div class="form-group">
                <asp:TextBox ID="txtcodigoDescargarPresentacion" runat="server" Style="margin-left: 0px" Width="450px"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Button ID="bttDescargarPresentacion" runat="server" Text="DESCARGAR" OnClick="bttDescargarPresentacion_Click" />
            </div>
        </div>
        <div class="col-md-4">
            <div class="form-group">
                <label for="pwd">Ingrese Carnet y Codigo de Curso Para Matricular Estudiante:</label>
            </div>
            <div class="form-group">
                <label for="pwd">Carnet:</label>
            </div>
            <div class="form-group">
                <asp:TextBox ID="txtCarnetMatricular" runat="server" Style="margin-left: 0px" Width="450px"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="pwd">Codigo de Curso:</label>
            </div>
            <div class="form-group">
                <asp:TextBox ID="txtCodigoCursoMatricular" runat="server" Style="margin-left: 0px" Width="450px"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Button ID="bttMatricularse" runat="server" Text="MATRICULARSE" OnClick="bttMatricularse_Click"/>
            </div>
        </div>
    </div>

    <br />
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
