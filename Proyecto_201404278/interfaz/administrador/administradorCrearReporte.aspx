﻿<%@ Page Title="" Language="C#" MasterPageFile="~/interfaz/administrador/administrador.Master" AutoEventWireup="true" CodeBehind="administradorCrearReporte.aspx.cs" Inherits="Proyecto_201404278.interfaz.administradorCrearReporte" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
    <br />
    <br />
    .
    <br />
    <h2 style="text-align: center">CREAR REPORTE</h2>
    <br />
    <br />

      <div class="container col-md-5 col-lg-offset-2">
        
          <div>
            <label for="pwd">Rol a quien va reporte:</label>
        </div>
        <div class="form-group" >
                    <select class="form-control" id="Select1" runat="server">
                        <option>Instructor</option>
                        <option>Estudiante</option>
                    </select>
                </div>
          <br />

          <div>
            <label for="pwd">Tipo de Incidente:</label>
        </div>
        <div class="form-group" >
                    <select class="form-control" id="rolTipo" runat="server">
                        <option>Insumo</option>
                        <option>Salon</option>
                    </select>
                </div>
          <br />

        <div>
            <label for="usr">Tipo de daño (Descripcion):</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtDescripcion" runat="server" Style="margin-left: 0px" Width="600px"></asp:TextBox>
        </div>
        <br />

          <div>
            <label for="pwd">Resuelto:</label>
        </div>
        <div class="form-group" >
                    <select class="form-control" id="rolResuelto" runat="server">
                        <option>Si</option>
                        <option>No</option>
                    </select>
                </div>
        

        <div>
            <label for="pwd">Fecha:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtFecha" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
        </div>
        <br />

        <div>
            <label for="pwd">Hora:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtHora" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
        </div>
        <br />

        <div>
            <label for="pwd">Carnet a quien va reporte:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtCarnetReporte" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
        </div>
        <br />

        <div>
            <label for="pwd">Codigo de insumo o salon:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtCodigoInsumoSalon" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
        </div>
        <br />

        <div>
            <label for="pwd">Codigo de quien lo registra:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtQuienRegistra" runat="server" Style="margin-left: 0px" Width="400px"></asp:TextBox>
        </div>
        <br />

        <div>
            <label for="pwd">CREAR REPORTE:</label>
        </div>      
        <asp:Button ID="bttCrearReserva" runat="server" Style="margin-left: 0px" Text="CREAR"/>
        <br />
        <br />

        
    </div>

</asp:Content>
