<%@ Page Title="" Language="C#" MasterPageFile="~/interfaz/principal.Master" AutoEventWireup="true" CodeBehind="principalOlvidarContra.aspx.cs" Inherits="Proyecto_201404278.interfaz.principalOlvidarContra" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


     <br />
    <br />
    .
    <br />
    <h2 style="text-align:center">RECUPERAR CONTRASEÑA</h2>
     <br />

     <div class="row text-center" id="aa2">
        <div>
             <label for="pwd">Ingrese Carnet y Palabra Clave para Recuperar:</label>
        </div>
        <br />
        <br />
         <div class="form-group">
                <label for="pwd">Seleccione Rol:</label>
            </div>
         <div class="form-group col-md-offset-4" >
                    <select class="form-control" id="rolBuscar" style="width:600px" runat="server">
                        <option>Administrador</option>
                        <option>Operador</option>
                        <option>Docente</option>
                        <option>Auxiliar</option>
                        <option>Conferencista</option>
                        <option>Estudiante</option>
                    </select>
                </div>
        <div>
           <div class="form-group">
                <label for="pwd">Carnet:</label>
            </div>
            <div class="form-group">
                <asp:TextBox ID="txtcarnetBuscar" runat="server" Style="margin-left: 0px" Width="450px"></asp:TextBox>
            </div>
        </div>
        <div>
            <div class="form-group">
                <label for="pwd">Palabra Clave:</label>
            </div>
            <div class="form-group">
                <asp:TextBox ID="txtPalabra" runat="server" Style="margin-left: 0px" Width="450px"></asp:TextBox>
            </div>
        </div>
         <div>
            <div class="form-group">
                <label for="pwd">Correo Electronico:</label>
            </div>
            <div class="form-group">
                <asp:TextBox ID="txtCorreo" runat="server" Style="margin-left: 0px" Width="450px"></asp:TextBox>
            </div>
        </div>
         <div>
             <asp:Button ID="bttRecuperar" runat="server" Text="RECUPERAR" OnClick="bttRecuperar_Click" />
         </div>       
    </div>

</asp:Content>
