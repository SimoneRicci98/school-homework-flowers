<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
        <link href="Content/bootstrap.css" type="text/css" rel="stylesheet" />

     <style type="text/css">
        .NuovoStile1 {
            position: center;
            font-variant: normal;
            font-family: "Comic Sans MS";
        }
        .NuovoStile2 {
            font-family: Gabriola;
            font-size: xx-large;
            color: #800000;
            text-decoration: underline;
        }
        .NuovoStile3 {
            font-size: 40px;
            font-family: Gabriola;
        }
        .NuovoStile4 {
            font-size: 40px;
            color: #800000;
            font-family: gabriola;
            text-decoration: underline;
        }
        html {
            border: thick dotted #800000;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
         <div class="container" style="margin-top:2%;">
        <div class="col-md-offset-3">

        <asp:Image ID="image1" runat="server" Height="94px" ImageUrl="~/immagini/cuore pulsante.gif" Width="150px" CssClass="NuovoStile1" />
        <a href="Default.aspx"><span class="NuovoStile4" style="text-align:center"><em><strong>Un Fiore per Sempre</strong></em></span></a>

        <asp:Image ID="image2" runat="server" Height="94px" ImageUrl="~/immagini/cuore pulsante.gif" Width="150px" CssClass="NuovoStile1" />
        </div>
        <div class="col-md-12" style="margin-top:3%">
            <div class="col-md-4" style="background-color:#990000; text-align:center; font-size:20px">
                <a style="color:black" href="Default.aspx"><b><asp:Label ID="lblHome" runat="server" Text="Home"></asp:Label></b></a>
                
            </div>
            <div class="col-md-4" style="background-color:green; text-align:center; font-size:20px">
                <a style="color:black" href="Default.aspx"><b><asp:Label ID="Offerte" runat="server" Text="Offerte"></asp:Label></b></a>
                
            </div>
            <div class="col-md-4" style="background-color:#990000; text-align:center; font-size:20px">
                <a style="color:black" href="login.aspx"><b><asp:Label ID="lblLogin" runat="server" Text="Login"></asp:Label></b></a>
         
            </div>
        </div>

<div class="col-md-12" style="margin-top:3%">
    <div class="col-md-1">
        <div class="row">
           <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>
            <asp:Button ID="Button3" runat="server" CssClass="btn-primary" Text="Visualizza i miei acquisti" />
            <br />
        </div>
        <div class="row" style="margin-top:2%">
           <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Logout" CssClass="btn-warning" />
        </div>
    </div>
           <div class="col-md-3">
        <div class="row">
                    <asp:TextBox ID="TxtEmail" runat="server"></asp:TextBox>
        </div>
        <div class="row" style="margin-top:2%">
                    <asp:TextBox ID="TxtPass" runat="server" TextMode="Password"></asp:TextBox>
        </div>
    </div>

    </div>
          <p>
             &nbsp;&nbsp; <asp:Button ID="Button1" runat="server" Text="Entra" OnClick="Button1_Click" />
              &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblErr" runat="server"></asp:Label>
         </p>
 <div class="col-md-offset-3" style="font-size:18px">
            <asp:Label ID="lblReg" runat="server" Text="Non hai un account? Registrati!"></asp:Label>
             </div>

        <div class="col-md-12" style="margin-top:3%">
            <div class="col-md-1">
        <div class="row">
           <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label>
            <br />
        </div>
        <div class="row" style="margin-top:2%">
           <asp:Label ID="Label4" runat="server" Text="Password"></asp:Label>
        </div>
    </div>
           <div class="col-md-3">
        <div class="row">
                    <asp:TextBox ID="txtEmailReg" runat="server"></asp:TextBox>
        </div>
        <div class="row" style="margin-top:2%">
                    <asp:TextBox ID="txtPswReg" runat="server" TextMode="Password"></asp:TextBox>
        </div>

    </div>

    </div>
         <p>
             &nbsp;&nbsp; 
             <asp:Button ID="Button4" runat="server" Text="Registrati" OnClick="Button4_Click" />
         &nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="lblErr0" runat="server"></asp:Label>
         </p>
    </div>

       
    </div>
    </form>
</body>
</html>
