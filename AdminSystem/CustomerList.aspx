<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstCustomerList" runat="server" Height="251px" OnSelectedIndexChanged="lstCustomerList_SelectedIndexChanged" Width="179px"></asp:ListBox>
        </div>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
        </p>
        <p>
            Enter a First name
            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="txtClear" runat="server" OnClick="txtClear_Click" Text="Clear" />
            <asp:Button ID="txtApply" runat="server" OnClick="txtApply_Click" Text="Apply" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
        </p>
    </form>
</body>
</html>
