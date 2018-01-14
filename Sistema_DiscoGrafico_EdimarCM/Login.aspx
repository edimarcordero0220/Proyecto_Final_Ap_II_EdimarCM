<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Sistema_DiscoGrafico_EdimarCM.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <meta charset="utf-8">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
        <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <link rel="stylesheet" href="Diseno/bootstrap.min.css" />
</head>
<body>
     
    <form id="form1" runat="server">
       
        <br></br>
        <br></br>
        <div class="text-center">
            <h3>Login</h3>
        <img id="profile-img" class="profile-img-card" src="//ssl.gstatic.com/accounts/ui/avatar_2x.png" />
        </div>
      
        <br></br>
       
        <div class="text-center">
          <div class="form-group">
        <asp:TextBox ID="NombreTextBox"  placeholder="Nombre" runat="server"></asp:TextBox>
        <asp:TextBox ID="ClaveTextBox" placeholder="Clave" runat="server" TextMode="Password"></asp:TextBox>
        </div>  
            </div>
        <div class="form-group">
        <div class="text-center">
        <asp:Button ID="EntrarButton" runat="server" class="btn btn-success" Text="Entrar" OnClick="EntrarButton_Click" />

        </div>
        </div>

        

          <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta/js/bootstrap.min.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
        

        
    </form>



          </body>
</html>
