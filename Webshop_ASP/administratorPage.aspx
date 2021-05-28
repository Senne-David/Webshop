<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="administratorPage.aspx.cs" Inherits="Webshop_ASP.administratorPage" %>

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
            background-image: url("./fotos/Achtergrond_2.jpg");
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
            top: 190%;
            left: 15%;
            -ms-transform: translate(-50%, -50%);
            transform: translate(-50%, -50%);
  
        }
        .right 
        {
            margin: 0;
            position: absolute;
            top: 165%;
            left: 75%;
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
                <asp:ListBox ID="lbxProducten" runat="server" Width="600" Height="600" Font-Bold="true" Font-Size="13"></asp:ListBox>
                <br />
                <asp:Button ID="btnDeleteProduct" runat="server" Height="50" Text="Product verwijderen" Width="600" OnClick="btnDeleteProduct_Click" BackColor="White" BorderColor="Blue" BorderWidth="5" Font-Bold="True" Font-Size="15" ForeColor="Black" />
            </div>
            <div class="right">
                <asp:Label ID="Label1" runat="server" Text="Product toevoegen" Width="300px" Font-Bold="true" Font-Size="20" ForeColor="White"></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label2" runat="server" Font-Bold="true" Font-Size="15" Text="Naam product:" Width="300" ForeColor="White"></asp:Label>
                <br />
                <asp:TextBox ID="tbxNaam" runat="server" Width="300" Font-Bold="True" Font-Size="15" BorderWidth="5" ForeColor="Black" BackColor="White" BorderColor="Blue"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label3" runat="server" Font-Bold="true" Font-Size="15" Text="Categorie product:" Width="300" ForeColor="White"></asp:Label>
                <br />
                <asp:TextBox ID="tbxCategorie" runat="server" Width="300" Font-Bold="True" Font-Size="15" BorderWidth="5" ForeColor="Black" BackColor="White" BorderColor="Blue"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label4" runat="server" Font-Bold="true" Font-Size="15" Text="Omschrijving product:" Width="300" ForeColor="White"></asp:Label>
                <br />
                <asp:TextBox ID="tbxOmschrijving" runat="server" Width="300" Font-Bold="True" Font-Size="15" BorderWidth="5" ForeColor="Black" BackColor="White" BorderColor="Blue"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label5" runat="server" Font-Bold="true" Font-Size="15" Text="Prijs product:" Width="300" ForeColor="White"></asp:Label>
                <br />
                <asp:TextBox ID="tbxPrijs" runat="server" Width="300" Font-Bold="True" Font-Size="15" BorderWidth="5" ForeColor="Black" BackColor="White" BorderColor="Blue"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="btnAddProduct" runat="server" Text="Product toevoegen" OnClick="btnAddProduct_Click" Width="300" BackColor="White" BorderWidth="5" BorderColor="Blue" Font-Bold="True" Font-Size="15" ForeColor="Black" />
                <br />
                <br />
                <br />
                <asp:Button ID="btnKlanten" runat="server" Text="Klantenlijst" OnClick="btnKlanten_Click" Width="300" BackColor="White" BorderWidth="5" BorderColor="Blue" Font-Bold="True" Font-Size="15" ForeColor="Black" />
                <br />
                <asp:Button ID="btnWinkelwagens" runat="server" Text="Bestellingen" OnClick="btnWinkelwagens_Click" Width="300" BackColor="White" BorderWidth="5" BorderColor="Blue" Font-Bold="True" Font-Size="15" ForeColor="Black" />
            </div>
        </div>
    </form>
</body>
</html>
