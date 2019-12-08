<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="Assignment5._3.Homepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Query" />
            <br />
            <br />
            <asp:Button ID="insertButton" runat="server" OnClick="Button2_Click" Text="Insert" />
            <br />
            <br />
            <asp:Button ID="updateButton" runat="server" Text="Update" />
            <br />
            <br />
            <asp:DropDownList ID="flowerList" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="enter" runat="server" Text="Enter" />
        </div>
    </form>
</body>
</html>
