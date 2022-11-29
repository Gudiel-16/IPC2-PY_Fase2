<%@ Page Title="" StylesheetTheme="Tema2" Language="C#" MasterPageFile="~/interfaz/principal.Master" AutoEventWireup="true" CodeBehind="principalInicio.aspx.cs" Inherits="Proyecto_201404278.interfaz.principalInicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" rel="stylesheet" href="/estilos/estiloprincipal.css" type="text/css" runat="server">
    
   <br/>
     <br/>
    <br/>
     <br />.
    <br/>
     <br/>
    <br/>
     <br/>
    
    <div class="container col-md-3 col-md-offset-1">
        
        <div class="login-form">
            <div class="main-div">

                <div class="form-group">
                    <asp:TextBox ID="txtCarnet" CssClass="form-control" placeholder="Carnet" runat="server" Style="margin-left: 0px" Width="330px"></asp:TextBox>
                </div>

                <div class="form-group">
                    <asp:TextBox ID="txtContra" type="Password" CssClass="form-control" placeholder="Contraseña" runat="server" Style="margin-left: 0px" Width="330px"></asp:TextBox>
                </div>
                               
                <div class="form-group">
                    <select class="form-control" id="rolEntrar" runat="server">
                        <option>Administrador</option>
                        <option>Operador</option>
                        <option>Docente</option>
                        <option>Auxiliar</option>
                        <option>Conferencista</option>
                        <option>Estudiante</option>
                    </select>
                </div>
                 <div class="forgot">
                    <a href="/interfaz/principalOlvidarContra.aspx">Olvido su contraseña?</a>
                </div>
                <asp:button type="button" class="btn btn-primary" id="bttacceder" text="ACCEDER" OnClick="bttacceder_Click" runat="server"/>

            </div>
          </div>
    </div>
   
    
</asp:Content>
