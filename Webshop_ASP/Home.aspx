<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Webshop_ASP.Home" %>

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
            left: 30%;
            -ms-transform: translate(-50%, -50%);
            transform: translate(-50%, -50%);
        }
        .right 
        {
            margin: 0;
            position: absolute;
            top: 50%;
            left: 95%;
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
        .btnstyle1
        { 
            background: url("./fotos/winkelkar.png");
        }
        .btnstyle2
        { 
            background: url("./fotos/hart.png");
        }

    </style>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="left">
                <asp:ListBox ID="lbxProducten" runat="server" Height="600" Width="800" Font-Size="15" ForeColor="White" BackColor="Black" ></asp:ListBox>
                <br />
                <asp:Label ID="Label1" runat="server" Text="Aantal:" Font-Size="20pt" Font-Bold="True" Height="50px" Width="150" ForeColor="White"></asp:Label>
                <asp:TextBox ID="tbxAantal" runat="server" Width="100" Height="40" Text="1" BackColor="White" BorderWidth="5" BorderColor="#00CC00" Font-Bold="True"></asp:TextBox>
                <br />
                <asp:Button ID="btnWinkelwagen" runat="server" Text="Toevoegen aan winkelwagen" OnClick="btnWinkelwagen_Click" Width="300" Height="40" BackColor="Black" BorderColor="#00CC00" BorderWidth="5px" ForeColor="White" Font-Bold="true"/>
                <asp:Button ID="btnaddVerlanglijstje" runat="server" Text="Toevoegen aan verlanglijstje" OnClick="btnaddVerlanglijstje_Click" Width="300" Height="40" BackColor="Black" BorderColor="#00CC00" BorderWidth="5px" ForeColor="White" Font-Bold="true" />
            </div>
            <div class="right">
                <asp:Label ID="Label3" runat="server" Text="" Height="100" Width="45"></asp:Label>
                <asp:Button ID="btnVerlanglijstje" runat="server" Text="" OnClick="btnVerlanglijstje_Click" Height="100" Width="100" CssClass="btnstyle2" BorderColor="Black" BorderWidth="5px" />
                <asp:Button ID="btnGoToWinkelwagen" runat="server" Text="" CssClass="btnstyle1" Height="100" Width="100" OnClick="btnGoToWinkelwagen_Click1" BorderColor="Black" BorderWidth="5px" />                
                <asp:Label ID="Label2" runat="server" Text="" Width="300" Height="20" BackColor="Black" BorderColor="#00CC00" BorderWidth="5"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
