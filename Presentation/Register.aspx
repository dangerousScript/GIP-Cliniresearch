﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Presentation.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register CliniresearchDB</title>
    <link rel="stylesheet" href="~/LoginStyleSheet.css" runat="server"/>
    <script src="//cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js"></script>
    
</head>
<body>
<div class="login-page">
  <form runat="server" class="form">
    <div class="register-form">
      <asp:TextBox runat="server" ID="tbName" placeholder="name" CssClass="input"></asp:TextBox>
      <asp:TextBox runat="server" ID="tbEmail" placeholder="email adress" CssClass="input"></asp:TextBox>
      <asp:TextBox runat="server" ID="tbPassword" placeholder="password" TextMode="Password" CssClass="input"></asp:TextBox>
      <asp:Button runat="server" ID="btnRegister" Text="Register" OnClick="BtnRegister_Click" CssClass="button"/>
      <p class="message">Already registered? <a href="/Login.aspx">Sign In</a></p>
    </div>
  </form>
</div>
</body>
</html>