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
            <asp:Button ID="updateButton" runat="server" Text="Update" OnClick="updateButton_Click" />
            <br />
            <br />
            <asp:DropDownList ID="flowerList" runat="server" TabIndex="3" Visible="False">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="enter" runat="server" Text="Enter" Visible="False" OnClick="enter_Click1" />
            <asp:Button ID="enter2" runat="server" Text="Enter" Visible="False" />
            <br />
            <asp:Label ID="nameLabel" runat="server" Text="Name" Visible="False"></asp:Label>
            <br />
            <asp:TextBox ID="nameTB" runat="server" Visible="False"></asp:TextBox>
            <br />
            <asp:Label ID="personLabel" runat="server" Text="Person" Visible="False"></asp:Label>
            <br />
            <asp:TextBox ID="personTB" runat="server" Visible="False"></asp:TextBox>
            <br />
            <asp:Label ID="locationLabel" runat="server" Text="Location" Visible="False"></asp:Label>
            <br />
            <asp:TextBox ID="locationTB" runat="server" Visible="False"></asp:TextBox>
            <br />
            <asp:Label ID="DateLabel" runat="server" Text="Date" Visible="False"></asp:Label>
            <br />
            <asp:TextBox ID="dateTB" runat="server" Visible="False"></asp:TextBox>
            <br />
            <asp:Button ID="enter3" runat="server" OnClick="enter3_Click" Text="Enter" Visible="False" />
            <br />
            <asp:Table ID="flowers" runat="server">
            </asp:Table>
        </div>
    </form>
</body>
</html>
