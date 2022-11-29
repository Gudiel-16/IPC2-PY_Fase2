<%@ Page Title="" StylesheetTheme="administrador" Language="C#" MasterPageFile="~/interfaz/administrador/administrador.Master" AutoEventWireup="true" CodeBehind="administradorModificarReservacion.aspx.cs" Inherits="Proyecto_201404278.interfaz.administradorModificarReservacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
    
    <br />
    <br />
    .
    <br />
    <h2 style="text-align: center">MODIFICAR RESERVACION</h2>
    <br />
    <br />

    <div class="row" id="aa2">
        <div class="col-md-5 col-md-offset-2">
             <label for="pwd">Ingrese Codigo de la reservacion para buscar:</label>
        </div>
        <br />
        <br />
      
        <div class="col-md-5 col-md-offset-2">
           <div class="form-group">
                <label for="pwd">Codigo:</label>
            </div>
            <div class="form-group">
                <asp:TextBox ID="txtCodigobuscar" runat="server" Style="margin-left: 0px" Width="450px"></asp:TextBox>
                <asp:Button ID="bttBuscar" runat="server" Style="margin-left: 10px" Text="BUSCAR" OnClick="bttBuscar_Click"/>
            </div>
        </div>
               
    </div>

    <div class="container col-md-5 col-lg-offset-2">
        
        <div>
            <label for="usr">Carnet de Instructor (NO SE PUEDE MODIFICAR):</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtCarnet" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
        </div>
        <br />

        <div>
            <label for="pwd">Salon:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtSalon" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
        </div>
        <br />

        <div>
            <label for="pwd">Tipo de Actividad de la reserva buscada:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtactividad" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
        </div>
        <br />

        <div>
            <label for="pwd">Modificar Actividad o Deje seleccionado el mismo tipo de actividad:</label>
        </div>
        <div class="form-group" >
                    <select class="form-control" id="rolactividad" runat="server">
                        <option>Laboratorio</option>
                        <option>Curso Magistral</option>
                        <option>Taller</option>
                        <option>Conferencia</option>
                    </select>
                </div>
        

        <div>
            <label for="pwd">Fecha De Inicio:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtFechaInicio" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
        </div>
        <br />

        <div>
            <label for="pwd">Fecha Final:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtFechaFin" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
        </div>
        <br />

        <div>
            <label for="pwd">Hora Inicio de La reserva Buscadda:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtHoraInicio" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
        </div>
        <br />

        <div>
            <label for="pwd">INGRESE NUEVA HORA INICIO:</label>
        </div>
        <div class="form-group" >
                    <select class="form-control" id="RolhoraInicio" runat="server">
                        <option>07:00:00</option>
                        <option>08:00:00</option>
                        <option>09:00:00</option>
                        <option>10:00:00</option>
                        <option>11:00:00</option>
                        <option>12:00:00</option>
                        <option>13:00:00</option>
                        <option>14:00:00</option>
                        <option>15:00:00</option>
                        <option>16:00:00</option>
                        <option>17:00:00</option>
                        <option>18:00:00</option>
                        <option>19:00:00</option>
                        <option>20:00:00</option>
                        <option>21:00:00</option>
                    </select>
                </div>
          <br />

        <div>
            <label for="pwd">Hora Final de la reserva Buscada:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtHoraFinal" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
        </div>
        <br />

         <div>
            <label for="pwd">INGRESE NUEVA HORA FIN:</label>
        </div>
        <div class="form-group" >
                    <select class="form-control" id="rolHorafin" runat="server">
                        <option>08:00:00</option>
                        <option>09:00:00</option>
                        <option>10:00:00</option>
                        <option>11:00:00</option>
                        <option>12:00:00</option>
                        <option>13:00:00</option>
                        <option>14:00:00</option>
                        <option>15:00:00</option>
                        <option>16:00:00</option>
                        <option>17:00:00</option>
                        <option>18:00:00</option>
                        <option>19:00:00</option>
                        <option>20:00:00</option>
                        <option>21:00:00</option>
                        <option>22:00:00</option>
                    </select>
                </div>        
         
          <br />

        <div>
            <label for="pwd">Codigo Qr (NO SE PUEDE MODIFICAR):</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtcodigoQr" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
        </div>
        <br />
        
        <div>
            <label for="pwd">Carnet de quien lo registro (NO SE PUEDE MODIFICAR):</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtQuienregistra" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
        </div>
        <br />

        <div>
            <label for="pwd">Carta Registrada actualmente:</label>
        </div>
        <div class="row">
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <div class="aa text-center"> 
                    <center>  
                        <image class="img-responsive" style="width:200px"  src="data:image/gif;base64,<%# Convert.ToBase64String((byte[]) DataBinder.Eval(Container.DataItem,"carta_escaneada"))%>"/>
                    </center>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
        <br />
        <br />

    <div>
            <label for="pwd">Si desea modificar la Carta Escaneada seleccione la Nueva:</label>
    </div>
        <br />
     <asp:FileUpload ID="FileUpload1" runat="server" />   
        <br />
        <asp:Image ID="imgCarta" ImageUrl="/imagenes/sin_carta.jpg" style="width:200px" runat="server" />

        <br />
        <br /> 
        <asp:Button ID="bttModificar" runat="server" Style="margin-left: 0px" Text="MODIFICAR RESERVACION" OnClick="bttModificar_Click"/>

    </div>

</asp:Content>
