<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="GymApp.Details" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <title>Member Details</title>
     <link rel="stylesheet" type="text/css" href="CSS/Details.css" />
</head>
<body>
    <form id="form1" runat="server">
        <asp:HiddenField ID="hfMemberId" runat="server" />
        <div>
            <asp:Label ID="lblMemberId" runat="server" Text="Member ID: "></asp:Label>
            <asp:Label ID="lblMemberIdValue" runat="server"></asp:Label>
            <br />
            <asp:Label ID="lblFirstName" runat="server" Text="First Name: "></asp:Label>
            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblLastName" runat="server" Text="Last Name: "></asp:Label>
            <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblAge" runat="server" Text="Age: "></asp:Label>
            <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblHeight" runat="server" Text="Height: "></asp:Label>
            <asp:TextBox ID="txtHeight" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblWeight" runat="server" Text="Weight: "></asp:Label>
            <asp:TextBox ID="txtWeight" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblSex" runat="server" Text="Sex: "></asp:Label>
            <asp:DropDownList ID="ddlSex" runat="server">
                <asp:ListItem Text="Select gender" Value="Select gender"></asp:ListItem>
                <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
                <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="lblPhone" runat="server" Text="Phone: "></asp:Label>
            <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblEmail" runat="server" Text="Email ID: "></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblExperienceLevel" runat="server" Text="Experience Level: "></asp:Label>
            <asp:DropDownList ID="ddlExperienceLevel" runat="server">
                <asp:ListItem Text="Choose experience" Value="Choose experience"></asp:ListItem>
                <asp:ListItem Text="Beginner" Value="Beginner"></asp:ListItem>
                <asp:ListItem Text="Intermediate" Value="Intermediate"></asp:ListItem>
                <asp:ListItem Text="Pro" Value="Pro"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="lblWorkoutPreference" runat="server" Text="Workout Preference: "></asp:Label>
            <asp:DropDownList ID="ddlWorkoutPreference" runat="server">
                <asp:ListItem Text="Choose workout" Value="Choose workout"></asp:ListItem>
                <asp:ListItem Text="Cardio" Value="Cardio"></asp:ListItem>
                <asp:ListItem Text="Bodybuilding" Value="Bodybuilding"></asp:ListItem>
                <asp:ListItem Text="CrossFit" Value="CrossFit"></asp:ListItem>
                <asp:ListItem Text="Calisthenics" Value="Calisthenics"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
        </div>
    </form>
</body>
</html>
