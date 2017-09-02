<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FontPage.aspx.cs" Inherits="WebApplication1.FontPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <form id="form1" runat="server">
        <div>
        </div>
        First Name&nbsp;

        <asp:TextBox ID="textName" runat="server" OnTextChanged="Unnamed1_TextChanged"></asp:TextBox>
        <p>
            Email Id&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="textEmail" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
    </form>
</body>
</html>
