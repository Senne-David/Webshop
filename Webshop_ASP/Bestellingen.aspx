<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bestellingen.aspx.cs" Inherits="Webshop_ASP.Bestellingen" %>

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
            background-image: url("./fotos/Achtergrond_3.jpg");
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
            top: 190%;
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
                <asp:Label ID="Label1" runat="server" Text="ID Winkelwagen:" Width="200px" ForeColor="White" Font-Bold="true" Font-Size="15"></asp:Label>
                <asp:TextBox ID="tbxIDWinkelwagen" runat="server" Width="100" Height="25" BackColor="White" BorderColor="Blue" BorderWidth="5px" ForeColor="Black"></asp:TextBox>
                <br />
                <asp:Button ID="btnToonProducten" runat="server" Font-Bold="true" Font-Size="12" Text="Producten" OnClick="btnToonProducten_Click" Width="400" BackColor="White" BorderColor="Blue" BorderWidth="5px" ForeColor="Black" />
                <br />
                <asp:ListBox ID="lbxProducten" runat="server" Height="500" Width="400"></asp:ListBox>
            </div>
            <div class="right">
                <asp:ListBox ID="lbxWinkelwagens" runat="server" Height="550" Width="500"></asp:ListBox>
            </div>
        </div>
    </form>
</body>
</html>
