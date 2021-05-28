<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Verlanglijstje.aspx.cs" Inherits="Webshop_ASP.Verlanglijstje" %>

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
            left: 35%;
            -ms-transform: translate(-50%, -50%);
            transform: translate(-50%, -50%);
        }
        .right 
        {
            margin: 0;
            position: absolute;
            top: 50%;
            left: 90%;
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
                <asp:ListBox ID="lbxVerlanglijstje" runat="server" Width="800" Height="600" BackColor="Black" ForeColor="White" Font-Bold="True" Font-Size="20"></asp:ListBox>
            </div>
            <div class="right">
                <asp:Button ID="btnDeleteFromList" runat="server" Text="Verwijder  product uit verlanglijstje" OnClick="btnDeleteFromList_Click" BackColor="Black" BorderColor="#00CC00" BorderWidth="5px" Font-Bold="true" ForeColor="White" Font-Size="15"/>
            </div>
        </div>
    </form>
</body>
</html>
