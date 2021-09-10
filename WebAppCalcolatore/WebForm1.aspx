<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebAppCalcolatore.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Numero 1"></asp:Label>
        &nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Numero 2"></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Somma" />
        <p>
            <asp:Label ID="Label3" runat="server" Text="Somma: "></asp:Label>
            <asp:Label ID="Label4" runat="server"></asp:Label>
        </p>
        <asp:Label ID="Label5" runat="server" Text="Calcoli Effettuati in questa sessione:"></asp:Label>
        <br />
        <asp:ListBox ID="ListBoxCalcoli" runat="server"></asp:ListBox>
    </form>
</body>
</html>
