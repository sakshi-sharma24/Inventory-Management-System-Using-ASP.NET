<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Count.aspx.cs" Inherits="InventoryMgmt.Count" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="textcount" runat="server" Height="52px"></asp:TextBox>
        <asp:Button ID="subbtn" runat="server" OnClick="Button1_Click" Text="Submit" />
    </form>
</body>
</html>
