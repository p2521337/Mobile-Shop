<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    Hi, This is the Customer Entry Page
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCustomerID" runat="server" height="19px" Text="Customer ID" width="130px"></asp:Label>
            <asp:TextBox ID="txtCustomerID" runat="server" height="22px" style="z-index: 1; left: 176px; top: 58px; position: absolute; width: 225px; margin-left: 51px" ></asp:TextBox>
            <br />
        </div>
        <asp:Label ID="lblFirstName" runat="server" height="19px" Text="First Name" width="130px"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server" height="22px" style="z-index: 1; left: 163px; top: 94px; position: absolute; width: 225px; margin-left: 63px"></asp:TextBox>
        <p style="height: 31px">
            <asp:Label ID="lblLastName" runat="server" height="19px" Text="Last Name" width="130px"></asp:Label>
            <asp:TextBox ID="txtLastName" runat="server" height="22px" style="z-index: 1; left: 165px; top: 129px; position: absolute; width: 225px; margin-left: 61px"></asp:TextBox>
        </p>
        <asp:Label ID="lblCustomerAddress" runat="server" height="19px" Text="Address" width="130px"></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server" height="22px" style="z-index: 1; left: 150px; top: 166px; position: absolute; width: 225px; margin-left: 76px" OnTextChanged="txtAddress_TextChanged"></asp:TextBox>
        <p>
            <asp:Label ID="lblMobileNumber" runat="server" height="19px" Text="Mobile Number" width="130px"></asp:Label>
            <asp:TextBox ID="txtMobileNumber" runat="server" height="22px" style="z-index: 1; left: 194px; top: 208px; position: absolute; bottom: 421px; width: 225px; margin-left: 29px"></asp:TextBox>
        </p>
        <asp:Label ID="lblCustomerDOB" runat="server" Text="DOB" width="130px"></asp:Label>
        <asp:TextBox ID="txtDOB" runat="server" height="22px" style="z-index: 1; left: 130px; top: 253px; position: absolute; width: 236px; margin-left: 88px"></asp:TextBox>
        <p style="height: 29px">
            <asp:CheckBox ID="chkMembership" runat="server" Text="Membership" />
        </p>
        <asp:Label ID="lblError" runat="server" Text="[Error]"></asp:Label>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" Width="46px" />
            <asp:Button ID="btnCancel" runat="server" style="margin-left: 21px" Text="Cancel" OnClick="btnCancel_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        </p>
    </form>
</body>
</html>
