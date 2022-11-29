<%@ Page Title="" Language="C#" MasterPageFile="~/interfaz/instructor/instructor.Master" AutoEventWireup="true" CodeBehind="instructorVerAsistencia.aspx.cs" Inherits="Proyecto_201404278.interfaz.instructorVerAsistencia" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <br />
    <br />
    .
    <br />
    <h2 style="text-align: center">ASISTENCIA</h2>
    <br />
    <br />

    <div class="row">
        
        <div class="col-md-4">
            <div class="form-group">
                <label for="pwd">Buscar Por Curso:</label>
            </div>
            <div class="form-group">
                <asp:TextBox ID="txtBuscarPorCurso" runat="server" Style="margin-left: 0px" Width="450px"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Button ID="bttBuscarPorCurso" runat="server" Text="BUSCAR" OnClick="bttBuscarPorCurso_Click" />
           </div>
        </div>

        <div class="col-md-4">
            <div class="form-group">
                <label for="pwd">Buscar Por Fecha y Curso:</label>
            </div>
            <div class="form-group">
                <label for="pwd">Seleccione Fecha:</label>
            </div>
            <asp:Calendar ID="Calendar2" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="200px" Width="220px" OnSelectionChanged="Calendar2_SelectionChanged">
                <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                <OtherMonthDayStyle ForeColor="#999999" />
                <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                <WeekendDayStyle BackColor="#CCCCFF" />
            </asp:Calendar>
            <br />
          <div class="form-group">
                <asp:TextBox ID="txtFecha" runat="server" Style="margin-left: 0px" Width="450px"></asp:TextBox>
           </div>
            <div class="form-group">
                <label for="pwd">Codigo de Curso:</label>
            </div>
          <div class="form-group">
                <asp:TextBox ID="txtCodigoCurso" runat="server" Style="margin-left: 0px" Width="450px"></asp:TextBox>
           </div>
            <div class="form-group">
                <asp:Button ID="bttBuscarPorfechaycurso" runat="server" Text="BUSCAR" OnClick="bttBuscarPorfechaycurso_Click" />
                <br />
                <br />
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
