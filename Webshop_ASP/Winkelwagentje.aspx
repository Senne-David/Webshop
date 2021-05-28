<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Winkelwagentje.aspx.cs" Inherits="Webshop_ASP.Winkelwagen" %>

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
            background-image: url("./fotos/Achtergrond_4.jpg");
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
            left: 25%;
            -ms-transform: translate(-50%, -50%);
            transform: translate(-50%, -50%);
        }
        .right 
        {
            margin: 0;
            position: absolute;
            top: 70%;
            left: 85%;
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
                <asp:ListBox ID="lbxWinkelwagen" runat="server" Width="700" Height="600" BackColor="Black" Font-Size="15" Font-Bold="True" ForeColor="White"></asp:ListBox>
                <br />
                <br />
                <asp:Button ID="btnDelete" Width="700" runat="server" Text="Verwijderen" Font-Bold="true" Font-Size="15" Height="50" OnClick="btnDelete_Click" BackColor="Black" BorderColor="#00CC00" BorderWidth="5px" ForeColor="White" />
            </div>
            <div class="right">
                <asp:Label ID="Label1" runat="server" Text="Totaal:" Width="120" Font-Bold="true" Font-Size="20"></asp:Label>
                <br />
                <asp:Label ID="Label2" runat="server" Text="€" Font-Bold="true" Font-Size="20"></asp:Label>
                <asp:Label ID="lblTotaal" runat="server" Text="" Font-Bold="true" Font-Size="20"></asp:Label>
                <br />
                <asp:Button ID="btnAfrekenen" runat="server" Text="Afrekenen" Height="50" Width="200" Font-Bold="true" Font-Size="15" ForeColor="White" BackColor="Black" BorderWidth="5" BorderColor="#00CC00" OnClick="btnAfrekenen_Click" />
            </div>
        </div>
    </form>
</body>
</html>
