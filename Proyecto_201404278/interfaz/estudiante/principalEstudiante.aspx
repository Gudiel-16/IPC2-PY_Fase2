<%@ Page Title="" StylesheetTheme="principalCalendario" Language="C#" MasterPageFile="~/interfaz/estudiante/estudiante.Master" AutoEventWireup="true" CodeBehind="principalEstudiante.aspx.cs" Inherits="Proyecto_201404278.interfaz.principalEstudiante" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
     <br />
    .
    <br />
     <div class="col-md-12">
         <br />
        
        <div class="col-md-2 col-md-offset-1" id="carnetUsuario">
              <img src="/imagenes/logousuario.png" class="img-responsive"  height="1290" width="" />
            <br />
             <asp:Label ID="lblCarnet" Font-Size="50px" runat="server" Text="201404278"></asp:Label>
            </div>
           
    <div class="col-md-3 col-md-offset-2" >
        <h2 style="text-align: center">CALENDARIO</h2>
        <br />
        <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="240px" NextPrevFormat="FullMonth" OnSelectionChanged="Calendar1_SelectionChanged" Width="400px">
            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
            <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
            <TodayDayStyle BackColor="#CCCCCC" />
        </asp:Calendar>
        
     </div>
                     
     </div>

    
    

</asp:Content>
