<%@ Page Title="" Language="C#" MasterPageFile="~/interfaz/instructor/instructor.Master" AutoEventWireup="true" CodeBehind="instructor_descargarQR.aspx.cs" Inherits="Proyecto_201404278.interfaz.instructor_descargarQR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

         <br />
    <br />
    .
    <br />
    <h2 style="text-align: center">DESCARGAR CODIGO QR</h2>
    <br />
    <br />

    <div class="ss text-center">
        <div>
            <label for="usr">Ingrese codigo de Reserva:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtcodigoReserva" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
        </div>
        <br />
        <asp:Button ID="bttCargarqr" runat="server" OnClick="bttCargarQr_Click" style="align-self:center" Text="CARGAR"/>
        <asp:Button ID="bttDescarga" runat="server" OnClick="bttdescargaQr_Click" style="align-self:center" Text="DESCARGA"/>
        </div>
    <br />
    <br />

    <div class="row">
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <div class="aa text-center"> 
                    <center>  
                        <image class="img-responsive" style="width:200px"  src="data:image/gif;base64,<%# Convert.ToBase64String((byte[]) DataBinder.Eval(Container.DataItem,"imagen"))%>"/>
                         <%#DataBinder.Eval(Container.DataItem,"codigo_qr") %>
                    </center>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>

</asp:Content>
