<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeEpicSpiesAssignment.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="logoImage" runat="server" Height="190px" ImageUrl="~/epic-spies-logo.jpg" />
        <br />
        <br />
        <h1 class="auto-style1">Spy New Assignment Form</h1>
        Spy Code Name:&nbsp;
        <asp:TextBox ID="spyTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        New Assignment Name:&nbsp; <asp:TextBox ID="assignmentTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        End Date of Previous Assignment:<asp:Calendar ID="firstCalendar" runat="server"></asp:Calendar>
        <br />
        Start Date of New Assignment:<asp:Calendar ID="secondCalendar" runat="server"></asp:Calendar>
        <br />
        Projected End Date of New Assignment:<asp:Calendar ID="thirdCalendar" runat="server"></asp:Calendar>
        <br />
        <asp:Button ID="assignButton" runat="server" OnClick="assignButton_Click" Text="Assign Spy" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
