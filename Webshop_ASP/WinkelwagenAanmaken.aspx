<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WinkelwagenAanmaken.aspx.cs" Inherits="Webshop_ASP.WinkelwagenAanmaken" %>

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
            background-image: url("./fotos/Achtergrond_1.jpg");
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
            left: 50%;
            -ms-transform: translate(-50%, -50%);
            transform: translate(-50%, -50%);
  
        }
        .right 
        {
            margin: 0;
            position: absolute;
            top: 150%;
            left: 75%;
            -ms-transform: translate(-50%, -50%);
            transform: translate(-50%, -50%);
  
        }
        .bottom 
        {
            margin: 0;
            position: absolute;
            top: 325%;
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
                <asp:Label ID="Label1" runat="server" Text="Winkelwagen aanmaken" Font-Bold="True" Font-Size="20pt" ForeColor="Black" Width="400"></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label2" runat="server" Text="Datum:" Font-Bold="True" Font-Size="15pt" ForeColor="White" Width="400"></asp:Label>
                <br />
                <asp:TextBox ID="tbxDatum" runat="server" Width="400" BackColor="White" BorderColor="Blue" BorderWidth="5px" ForeColor="Black"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label3" runat="server" Text="Kaartnummer:" Font-Bold="True" Font-Size="15pt" ForeColor="White" Width="400"></asp:Label>
                <br />
                <asp:TextBox ID="tbxKaartnummer" runat="server" Width="400" BackColor="White" BorderColor="Blue" BorderWidth="5px" ForeColor="Black" ></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label4" runat="server" Text="Verzendmethode:" Font-Bold="True" Font-Size="15pt" ForeColor="White" Width="400"></asp:Label>
                <br />
                <asp:RadioButton ID="rbtAfhalen" runat="server" OnCheckedChanged="rbtAfhalen_CheckedChanged" />
                <asp:Label ID="Label6" runat="server" Text="Afhalen" Font-Bold="True" Font-Size="15pt" ForeColor="White"></asp:Label>
                <br />
                <asp:RadioButton ID="rbtBezorgen" runat="server" OnCheckedChanged="rbtBezorgen_CheckedChanged" />
                <asp:Label ID="Label5" runat="server" Text="Bezorgen" Font-Bold="True" Font-Size="15pt" ForeColor="White"></asp:Label>
                <br />
                <br />
                <asp:Button ID="btnBevestigen" runat="server" Text="Bevestigen" Width="400" OnClick="btnBevestigen_Click" Font-Bold="True" Font-Size="15" BackColor="Black" BorderColor="Blue" BorderWidth="5px" ForeColor="White" />
            </div>
            <div class="right">

            </div>
        </div>
    </form>
</body>
</html>
