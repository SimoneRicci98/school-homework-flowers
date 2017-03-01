<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Acquista.aspx.cs" Inherits="Acquista" %>

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
                <a style="color:black" href="Default.aspx"><b><asp:Label ID="lblOfferte" runat="server" Text="Offerte"></asp:Label></b></a>
            </div>
            <div class="col-md-4" style="background-color:#990000; text-align:center; font-size:20px">
                <a style="color:black" href="login.aspx"><b><asp:Label ID="lblLogin" runat="server" Text="Login"></asp:Label></b></a>
            </div>
        </div>
    <div class="col-md-12" style="margin-top:5%;font-size:20px;">
    <div class="col-md-4">
        &nbsp;<asp:Image ID="Image3" runat="server" Height="296px" Width="189px" />
    </div>
    <div class="col-md-offset-4">
        <asp:Label ID="lblPrd" runat="server"></asp:Label>
        <br />
        <br />
    </div>
    <div class="col-md-offset-4">
        <asp:Label ID="lblPrezzo" runat="server"></asp:Label>
        <br />
        <br />
    </div>
    <div class="col-md-offset-4">

        <asp:Label ID="Label1" runat="server" Text="Quantità che si vuole acquistare: "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Width="43px" TextMode="SingleLine" ReadOnly="True">0</asp:TextBox>
        &nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="+" Width="67px" />
&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="-" Width="67px" />
        <br />
        <br />
    </div>
    <div class="col-md-offset-4">

        <asp:Button ID="btnAcquista" runat="server" Text="Acquista!" OnClick="btnAcquista_Click" />

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblbErr" runat="server"></asp:Label>

    </div>
    </div>

</div>
    </form>
</body>
</html>
