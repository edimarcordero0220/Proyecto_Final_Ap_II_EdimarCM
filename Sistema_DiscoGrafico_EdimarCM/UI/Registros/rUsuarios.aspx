<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="rUsuarios.aspx.cs" Inherits="Sistema_DiscoGrafico_EdimarCM.UI.Registros.rUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            display: block;
            width: 94%;
            height: 39px;
            padding: 8px 12px;
            font-size: 15px;
            line-height: 1.42857143;
            color: #777777;
            background-color: #ffffff;
            background-image: none;
            border: 1px solid #cccccc;
            border-radius: 4px;
            -webkit-box-shadow: inset 0 1px 1px rgba(0,0,0,0.075);
            box-shadow: inset 0 1px 1px rgba(0,0,0,0.075);
            -webkit-transition: border-color ease-in-out .15s,-webkit-box-shadow ease-in-out .15s;
            -o-transition: border-color ease-in-out .15s,box-shadow ease-in-out .15s;
            transition: border-color ease-in-out .15s,box-shadow ease-in-out .15s;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <!DOCTYPE html>
    <html>
    <head>
        <title></title>
        <meta charset="utf-8">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
        <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    </head>

  <body>
      <div class="container">
            <div class="text-center">

                
                    <form class="form-horizontal">
  <fieldset>
    <legend>Llenar Formulario </legend>
      <div class="text-center">
    

       <div class="form-group">
      
         <div class="col-lg-5">
             <asp:Label ID="Label2" runat="server" Text="ID"></asp:Label>
          <asp:TextBox class="auto-style1" ID="IdTextBox" placeholder="Id" runat="server"></asp:TextBox>
             <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
          <asp:TextBox ID="NombreTextBox" class="form-control"  placeholder="Nombre" runat="server"></asp:TextBox>
              <asp:Label ID="Label8" runat="server" Text="Clave"></asp:Label>
          <asp:TextBox class="auto-style1" ID="ClaveTextBox" placeholder="Clave" runat="server"></asp:TextBox>
             <asp:Label ID="Label3" runat="server" Text="Fecha"></asp:Label>
          <asp:TextBox ID="FechaTextBox" class="form-control" runat="server"></asp:TextBox>
             <asp:Label ID="Label4" runat="server" Text="Email"></asp:Label>
          <asp:TextBox ID="EmailTextBox"  class="form-control" placeholder="Email" runat="server"></asp:TextBox>
             <asp:Label ID="Label5" runat="server" Text="Direccion"></asp:Label>
          <asp:TextBox ID="DireccionTextBox" class="form-control" placeholder="Direccion" runat="server"></asp:TextBox>
             <asp:Label ID="Label6" runat="server" Text="Telefono"></asp:Label>
          <asp:TextBox ID="TelefonoTextBox" class="form-control"  placeholder="Telefono" runat="server"></asp:TextBox>
             <asp:Label ID="Label7" runat="server" Text="Celular"></asp:Label>
          <asp:TextBox ID="CelularTextBox" class="form-control"   placeholder="Celular" runat="server"></asp:TextBox>
      </div>

       </div>
  
          

    <div class="form-group">
      <div class="col-lg-9 col-lg-offset-1">
          
          <br></br>
          <asp:Button ID="GuardarButton" class="btn btn-sumit" runat="server" OnClick="GuardarButton_Click" Text="Guardar" />
        <asp:Button ID="BuscarButton" class="btn btn-default" runat="server" Text="Buscar" OnClick="BuscarButton_Click" />
        <asp:Button ID="EliminarButton" class="btn btn-cancel" runat="server" Text="Eliminar" OnClick="EliminarButton_Click" />
         <asp:Button ID="NuevoButton" class="btn btn-cancel" runat="server" Text="Nuevo" OnClick="NuevoButton_Click" />

          <br></br>
          <br></br>
      </div>
    </div>
          </div>
  </fieldset>
</form>
                </div>


                </div></div>

             
       

      </body>
</asp:Content>
