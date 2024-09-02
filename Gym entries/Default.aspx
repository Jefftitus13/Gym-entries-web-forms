<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GymApp._Default" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <title>Members List</title>
    <link rel="stylesheet" type="text/css" href="CSS/Default.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnAddMember" runat="server" Text="Add Member" OnClick="btnAddMember_Click" />
            <asp:GridView ID="GridView1" runat="server" DataKeyNames ="member_id" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand">
                <Columns>
                    <asp:BoundField DataField="member_id" HeaderText="Member ID" />
                    <asp:BoundField DataField="First_name" HeaderText="First Name" />
                    <asp:BoundField DataField="Last_name" HeaderText="Last Name" />
                    <asp:BoundField DataField="Age" HeaderText="Age" />
                    <asp:BoundField DataField="Height" HeaderText="Height" />
                    <asp:BoundField DataField="Weight" HeaderText="Weight" />
                    <asp:BoundField DataField="Sex" HeaderText="Sex" />
                    <asp:BoundField DataField="Phone" HeaderText="Phone" />
                    <asp:BoundField DataField="Email_id" HeaderText="Email ID" />
                    <asp:ButtonField ButtonType="Button" CommandName="Select" Text="Select" />
                    <asp:ButtonField ButtonType="Button" CommandName="Delete" Text="Delete" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
