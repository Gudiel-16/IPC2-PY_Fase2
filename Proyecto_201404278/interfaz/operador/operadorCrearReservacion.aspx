<%@ Page Title="" StylesheetTheme="operador" Language="C#" MasterPageFile="~/interfaz/operador/operador.Master" AutoEventWireup="true" CodeBehind="operadorCrearReservacion.aspx.cs" Inherits="Proyecto_201404278.interfaz.operadorCrearReservacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />
    <br />
    .
    <br />
    <h2 style="text-align: center">CREAR RESERVACION</h2>
    <br />
    <br />

    <div class="row col-md-6 col-md-offset-2" id="aa2">
        <div >
            <label for="pwd">AVISO: Antes de hacer reserva, debe generar CODIGO QR.</label>
        </div>
        <br />
        <br />

         <div>
        <label for="pwd">Generar Codigo QR:</label>
    </div>
    <div class="form-group">
        <label for="pwd">Ingrese un codigo de 'Codigo QR' a crear:</label>
    </div>
    <div class="form-group">
        <asp:TextBox ID="txtCodigoacrear" runat="server" Style="margin-left: 0px" Width="300px"></asp:TextBox>
        <asp:Button ID="brrGenerarQR" runat="server" OnClick="bttgenerarQR_Click" Style="margin-left: 0px" Text="GENERAR" />
    </div>
    
    
    <asp:image runat="server" ImageUrl="/imagenes/sin_QR.jpg" style="width:200px" id="imgQR" />
    
    <br />
    <br />
    </div>
   

      <div class="container col-md-5 col-lg-offset-2">
        
          <br />
        <div>
            <label for="pwd">'Codigo QR' creado anteriormente:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtcodigoQrcreado" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
        </div>
        <br />

        <div>
            <label for="pwd">Codigo de reserva:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtCodigoReserva" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
        </div>
        <br />

        <div>
            <label for="usr">Carnet de Instructor:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtCarnet" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
        </div>
        <br />

        <div>
            <label for="pwd">Salon:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtSalon" runat="server" type="number" Style="margin-left: 0px" Width="400px"></asp:TextBox>

        </div>
        <br />

          <div>
            <label for="pwd">Actividad:</label>
        </div>
        <div class="form-group" >
                    <select class="form-control" id="rolActividad" runat="server">
                        <option>Laboratorio</option>
                        <option>Curso Magistral</option>
                        <option>Taller</option>
                        <option>Conferencia</option>
                    </select>
                </div>
        
           <div>
           <div class="form-group">
                <label for="pwd">FECHA INICIO:</label>
            </div>
            <div class="form-group">
                <asp:Calendar ID="Calendar1" OnSelectionChanged="Calendar1_SelectionChanged" runat="server"></asp:Calendar>
                <br />
                <asp:TextBox ID="txtDesde" runat="server" Style="margin-left: 0px" Width="300px"></asp:TextBox>
            </div>
        </div>
        <div>
            <div class="form-group">
                <label for="pwd">FECHA FIN:</label>
            </div>
            <div class="form-group">
                <asp:Calendar ID="Calendar2" OnSelectionChanged="Calendar2_SelectionChanged" runat="server"></asp:Calendar>
                <br />
                <asp:TextBox ID="txtHasta" runat="server"  Style="margin-left: 0px" Width="300px"></asp:TextBox>
            </div>
        </div>

          <br />

          <div>
            <label for="pwd">HORA INICIO:</label>
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
            <label for="pwd">HORA FIN:</label>
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
            <label for="pwd">Agregar Carta escaneada:</label>
        </div>  
        <div class="row">
            <asp:FileUpload ID="FileUpload1" CssClass="form-control" runat="server" />
            <br />
            <asp:Image ID="imgCarta" ImageUrl="/imagenes/sin_carta.jpg" style="width:200px" runat="server" />
        </div>
        <br />
        <br />

          <div>
            <label for="pwd">Carnet de quien lo registra:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtQuienRegistra" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
        </div>
        <br />

        <asp:Button ID="bttCrearReserva" runat="server" OnClick="bttCrearresarva_Click" Style="margin-left: 0px" Text="CREAR RESERVA"/>

    </div>

</asp:Content>
