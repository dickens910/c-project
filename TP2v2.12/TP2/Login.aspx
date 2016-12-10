<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TP2.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>

    * {
  margin: 0;
  padding: 0;
}

body {
  margin: 0;
  padding: 0;
  font-family: Sans-serif;
  background: #2c3e50;
}

#wrap {
  margin: 0 auto 30px;
}

#regbar {
  height: 67px;
  background: #34495e;
}

#navthing {
  margin-left: 50px;
}

h2 {
  padding: 20px;
  color: #ecf0f1;
}

fieldset {
  border: none;
}

.login {
  position: relative;
  width: 350px;
  display: none;
}

.arrow-up {
  width: 0;
  height: 0;
  border-left: 20px solid transparent;
  border-right: 20px solid transparent;
  border-bottom: 15px solid #ECF0F1;
  left: 10%;
  position: absolute;
  top: -10px;
}

.formholder {
  background: #ecf0f1;
  width: 350px;
  border-radius: 5px;
  padding-top: 5px;
}
.formholder input[type="email"], .formholder input[type="password"] {
  padding: 7px 5px;
  margin: 10px 0;
  width: 96%;
  display: block;
  font-size: 18px;
  border-radius: 5px;
  border: none;
  -webkit-transition: 0.3s linear;
  -moz-transition: 0.3s linear;
  -o-transition: 0.3s linear;
  transition: 0.3s linear;
}
.formholder input[type="email"]:focus, .formholder input[type="password"]:focus {
  outline: none;
  box-shadow: 0 0 1px 1px #1abc9c;
}
.formholder input[type="submit"] {
  background: #1abc9c;
  padding: 10px;
  font-size: 20px;
  display: block;
  width: 100%;
  border: none;
  color: #fff;
  border-radius: 5px;
}
.formholder input[type="submit"]:hover {
  background: #1bc6a4;
}

.randompad {
  padding: 10px;
}

.green {
  color: #1abc9c;
}

a {
  color: #ecf0f1;
  text-decoration: none;
}
a:hover {
  color: #1abc9c;
}
@import "compass/css3";

* {
margin: 0;
padding: 0;
}

body {
  margin: 0;
  padding: 0;
  font-family: Sans-serif;
  background: #2c3e50;
}

#wrap {
  margin: 0 auto 30px;
  
}

#regbar {
  height: 67px;
  background: #34495e;
}

#navthing {
margin-left: 50px;
}

h2 {
  padding: 20px;
  color: #ecf0f1;
}

fieldset {
border: none;
}

.login {
  position: relative;
  width: 350px;
  display: none;
}

.arrow-up {
	width: 0; 
	height: 0; 
	border-left: 20px solid transparent;
	border-right: 20px solid transparent;
	
	border-bottom: 15px solid #ECF0F1;
  left: 10%;
  position: absolute;
  top: -10px;
}

.formholder {
  background: #ecf0f1;
  width: 350px;
  border-radius: 5px;
  padding-top: 5px;
  fieldset {

  }
  
  input[type="email"], input[type="password"] {
    padding: 7px 5px;
    margin: 10px 0;
    width: 96%;
    display: block;
    font-size: 18px;
    border-radius: 5px;
    border: none;
    
    &:focus {
      outline: none;
      box-shadow: 0 0 1px 1px #1abc9c;
      }
   -webkit-transition: 0.3s linear;
    -moz-transition: 0.3s linear;
    -o-transition: 0.3s linear;
    transition: 0.3s linear;
  }
  
  input[type="submit"] {
    background: #1abc9c;
    padding: 10px;
    font-size: 20px;
    display: block;
    width: 100%;
    border: none;
    color: #fff;
    border-radius: 5px;
    &:hover {
      background: #1bc6a4;
      }
  }
  
}

.randompad {
padding: 10px;
}

.green {
  color: #1abc9c;
}

a {
  color: #ecf0f1;
  text-decoration: none;
  
  &:hover {
      color: #1abc9c;
    }
} </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="navthing">
      <h2><a href="#" id="loginform">Login</a> | <a href="/Signup.aspx">Register</a></h2>
        Username :
        <asp:TextBox ID="uName" runat="server"></asp:TextBox>
        <br />
        Password :
        <asp:TextBox ID="psw" runat="server" TextMode="Password"></asp:TextBox> 
        <br />
        <asp:Button ID="bAjouter" runat="server" Text="Se connecter"  
            onclick="bConnecterr_Click" />
        <asp:Label ID="lMessage" runat="server" ForeColor="Red"></asp:Label>
</asp:Content>

