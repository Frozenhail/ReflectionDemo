<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VrijwilligerWijzigen.aspx.cs" Inherits="ReflectionDemo.VrijwilligerWijzigen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Voornaam:
        <asp:TextBox ID="tbVoornaam" runat="server"></asp:TextBox>
        <br />
        Achternaam:
        <asp:TextBox ID="tbAchternaam" runat="server"></asp:TextBox>
        <br />
        Schoenmaat:
        <asp:TextBox ID="tbSchoenmaat" runat="server"></asp:TextBox>
        <br />
        Geboortedatum:
        <asp:TextBox ID="tbGeboortedatum" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btOpslaan" runat="server" OnClick="btOpslaan_Click" Text="Opslaan" />
    
    </div>
    </form>
</body>
</html>
