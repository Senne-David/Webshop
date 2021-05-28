<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registreren.aspx.cs" Inherits="Webshop_ASP.registreren" %>

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
        .left 
        {
            margin: 0;
            position: absolute;
            top: 170%;
            left: 25%;
            -ms-transform: translate(-50%, -50%);
            transform: translate(-50%, -50%);
  
        }
        .right 
        {
            margin: 0;
            position: absolute;
            top: 170%;
            left: 75%;
            -ms-transform: translate(-50%, -50%);
            transform: translate(-50%, -50%);
  
        }
        .bottom 
        {
            margin: 0;
            position: absolute;
            top: 340%;
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
            color: white;
            padding: 8px;
            width: inherit;
            background-color: seagreen;
        }

    </style>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <div class="container">
             <div class="left">
                <asp:Label ID="Label2" runat="server" Text="Gebruikersnaam:" Font-Size="20" Width="350" Font-Bold="true" BackColor="White" BorderWidth="5" BorderColor="#FFCCCC" ForeColor="Black"></asp:Label>
                 <br />
                <asp:TextBox ID="tbxGebruikersnaam" runat="server" Width="350" BorderColor="White" BorderWidth="5" BackColor="#FFCCCC" ForeColor="Black"></asp:TextBox>
                <br />
                <asp:Label ID="Label3" runat="server" Text="Paswoord:" Font-Size="20pt" Width="350px" Font-Bold="True" ForeColor="Black" BackColor="White" BorderWidth="5" BorderColor="#FFCCCC"></asp:Label>
                 <br />
                <asp:TextBox ID="tbxPaswoord" runat="server" Width="350" BorderWidth="5" BackColor="#FFCCCC" ForeColor="Black" BorderColor="White"></asp:TextBox>
                <br />
                <asp:Label ID="Label4" runat="server" Text="Voornaam:" Font-Size="20" Width="350" Font-Bold="true" BackColor="White" BorderWidth="5" BorderColor="#FFCCCC" ForeColor="Black"></asp:Label>
                 <br />
                <asp:TextBox ID="tbxVoornaam" runat="server" Width="350" BorderWidth="5" BackColor="#FFCCCC" ForeColor="Black" BorderColor="White"></asp:TextBox>
                <br />
                <asp:Label ID="Label5" runat="server" Text="Achternaam:" Font-Size="20" Width="350" Font-Bold="true" BackColor="White" BorderWidth="5" BorderColor="#FFCCCC" ForeColor="Black"></asp:Label>
                 <br />
                <asp:TextBox ID="tbxAchternaam" runat="server" Width="350" BorderWidth="5" BackColor="#FFCCCC" ForeColor="Black" BorderColor="White"></asp:TextBox>
                <br />
                <asp:Label ID="Label6" runat="server" Text="Geboortedatum:" Font-Size="20" Width="350" Font-Bold="true" BackColor="White" BorderWidth="5" BorderColor="#FFCCCC" ForeColor="Black"></asp:Label>
                 <br />
                <asp:TextBox ID="tbxGeboortedatum" runat="server" Width="350" BorderWidth="5" BackColor="#FFCCCC" ForeColor="Black" BorderColor="White"></asp:TextBox>            
            </div>
            <div class="right">
                <asp:Label ID="Label7" runat="server" Text="Postcode:" Font-Size="20" Width="350" Font-Bold="true" BackColor="White" BorderWidth="5" BorderColor="#FFCCCC" ForeColor="Black"></asp:Label>
                <br />
                <asp:TextBox ID="tbxPostcode" runat="server" Width="350" BorderWidth="5" BackColor="#FFCCCC" ForeColor="Black" BorderColor="White"></asp:TextBox>
                <br />
                <asp:Label ID="Label8" runat="server" Text="Straat:" Font-Size="20" Width="350" Font-Bold="true" BackColor="White" BorderWidth="5" BorderColor="#FFCCCC" ForeColor="Black"></asp:Label>
                <br />
                <asp:TextBox ID="tbxStraat" runat="server" Width="350" BorderWidth="5" BackColor="#FFCCCC" ForeColor="Black" BorderColor="White"></asp:TextBox>
                <br />
                <asp:Label ID="Label9" runat="server" Text="Huisnummer:" Font-Size="20" Width="350" Font-Bold="true" BackColor="White" BorderWidth="5" BorderColor="#FFCCCC" ForeColor="Black"></asp:Label>
                <br />
                <asp:TextBox ID="tbxHuisnummer" runat="server" Width="350" BorderWidth="5" BackColor="#FFCCCC" ForeColor="Black" BorderColor="White"></asp:TextBox>
                <br />
                <asp:Label ID="Label10" runat="server" Text="E-mail:" Font-Size="20" Width="350" Font-Bold="true" BackColor="White" BorderWidth="5" BorderColor="#FFCCCC" ForeColor="Black"></asp:Label>
                <br />
                <asp:TextBox ID="tbxEmail" runat="server" Width="350" BorderWidth="5" BackColor="#FFCCCC" ForeColor="Black" BorderColor="White"></asp:TextBox>
                <br />
                <asp:Label ID="Label11" runat="server" Text="Telefoonnummer:" Font-Size="20" Width="350" Font-Bold="true" BackColor="White" BorderWidth="5" BorderColor="#FFCCCC" ForeColor="Black"></asp:Label>
                <br />
                <asp:TextBox ID="tbxTelefoonnummer" runat="server" Width="350" BorderWidth="5" BackColor="#FFCCCC" ForeColor="Black" BorderColor="White"></asp:TextBox>
                <br />
          </div>
          <div class="bottom">
              <asp:Button ID="btnRegisteren" runat="server" BorderWidth="5" BackColor="#FFCCCC" ForeColor="Black" Text="Registreren" BorderColor="White" Width="400" Font-Size="20" Font-Bold="true" OnClick="btnRegisteren_Click1" />
          </div>
        </div> 
    </form>
</body>
</html>
