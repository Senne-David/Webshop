<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Webshop_ASP._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>   
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <style>
        body
        {
            background-image: url("./fotos/shop.jpg");
            background-repeat: no-repeat, repeat;
            background-color: #cccccc;
            background-size: cover;
            background-color: lightseagreen;
        }
        .container 
        {
            height: 200px;
            position: relative;
            border: 3px white;
        }
        .center 
        {
            margin: 0;
            position: absolute;
            top: 160%;
            left: 50%;
            -ms-transform: translate(-50%, -50%);
            transform: translate(-50%, -50%);
  
        }
        input[type=text]:focus 
        {
            background-color: lightblue;
            border: 2px solid black;
        }
        input[type=text] 
        {
            width: 100%;
            padding: 12px 20px;
            margin: 8px 0;
            box-sizing: border-box;
            border: 1px solid black;
        }
        .label 
        {
            color: black;
            background-color: white;
        }

    </style>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
          <div class="center">
            <asp:Label ID="Label4" runat="server" Text="" Width="150"></asp:Label>
            <asp:Label ID="Label1" runat="server" Text="Login" Width="250" Font-Size="25" Font-Bold="true"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Gebruikersnaam:" Width="400" Font-Size="20" Font-Bold="true" CssClass="label" BackColor="White" BorderColor="#FFCCCC" BorderWidth="5" ForeColor="Black"></asp:Label>
            <br />
            <asp:TextBox ID="tbxGebruikersnaam" runat="server" Height="50" Width="400" Font-Size="15" BorderColor="#FFCCCC" BorderWidth="5px"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Paswoord:" Width="400" Font-Bold="true" Font-Size="20" CssClass="label" BackColor="White" BorderColor="#FFCCCC" BorderWidth="5" ForeColor="Black" ></asp:Label>
            <br />
            <asp:TextBox ID="tbxpaswoord" TextMode="Password" runat="server" Height="50" Width="400" Font-Size="15" BorderColor="#FFCCCC" BorderWidth="5px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" Height="50" Width="400" Font-Size="15" Font-Bold="true" BackColor="#FFCCCC" BorderColor="White" BorderWidth="5px" ForeColor="Black" />
            <br />
            <br />
            <asp:Button ID="btnRegistreren" runat="server" Text="Registreren" Height="50" OnClick="btnRegistreren_Click" Width="400" Font-Size="15" Font-Bold="true" BorderColor="#FFCCCC" BackColor="White" BorderWidth="5px" ForeColor="Black" />
        </div>
       </div>
    </form>
</body>
</html>
