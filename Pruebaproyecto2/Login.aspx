<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Pruebaproyecto2.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    
    <title>Inicio de Sesión</title>

<style>
        body {
            background-color: #f00; /* Fondo negro */
            font-family: Arial, sans-serif;
            color: #fff;
            margin: 0;
            padding: 0;
            display: flex;
            align-items: center;
            justify-content: center;
            height: 100vh;
        }
 
        #login-container {
            background-color: rgba(0, 0, 0, 0.7);
            padding: 20px;
            border-radius: 10px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.5);
            text-align: center;
        }
 
        #login-container h2 {
            margin-bottom: 20px;
        }
 
        label {
            display: block;
            margin-bottom: 8px;
        }
 
        input {
            width: 100%;
            padding: 10px;
            margin-bottom: 15px;
            box-sizing: border-box;
        }
 
        .btn {
            background-color: #4CAF50;
            color: #fff;
            padding: 10px 20px;
            border: none;
            border-radius: 5px;
            cursor: pointer;
        }
</style>
</head>
<body>
<form id="form1" runat="server">
<div id="login-container">
<h2>Inicio de Sesión</h2>
<div>
<label for="txtUsername">Usuario:</label>
<asp:TextBox ID="txtUsername" runat="server" OnTextChanged="txtUsername_TextChanged1"></asp:TextBox>
</div>
<div>
<label for="txtPassword">Contraseña:</label>
<asp:TextBox ID="txtPassword" runat="server" TextMode="Password" OnTextChanged="txtPassword_TextChanged1"></asp:TextBox>
</div>
<div>
<asp:Button ID="btnLogin" runat="server" Text="Iniciar Sesión" OnClick="btnLogin_Click" CssClass="btn" />
</div>
<div>
<asp:Button ID="btnCrearUsuario" runat="server" Text="Crear Usuario" OnClick="btnCrearUsuario_Click" CssClass="btn" />
</div>
</div>
</form>
</body>
</html>